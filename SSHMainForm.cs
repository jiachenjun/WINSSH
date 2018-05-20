using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using demossh.Properties;
using Newtonsoft.Json;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace demossh
{
	
	public partial class SSHMainForm : Form
	{
		public SSHManager main;
		public STColorFontConfig colorfontconfig;
		public SSHMainForm()
		{
			InitializeComponent();
			colorfontconfig = new STColorFontConfig(label1.BackColor, label1.Font);
			Init_NodeList();
			logQ.Init();
			
			this.tb_hostIP.Text = Resources.HOST;
			this.tb_username.Text = Resources.USERNAME;
			this.tb_pwd.Text = Resources.PASSWORD;

			var now = DateTime.Now;
			this.dateTimePicker_Start.Value = now.AddMinutes(-10);
			this.dateTimePicker_End.Value = now;
			all_session = new List<sessionObj>();
			
			main = new SSHManager(new SSHParam(this.tb_hostIP.Text, this.tb_username.Text, this.tb_pwd.Text)
			                     , tb_output, rtb_log);
			RulesInit();
			ComboBox_commonInit();
		}
		
		public void UpdateSSHParam()
		{
			if (main != null)
				main.param.Update(this.tb_hostIP.Text, this.tb_username.Text, this.tb_pwd.Text);
		}

		public const string FETCH_DEF_NODE_CMD = "echo $HOSTNAME";
		public const string FETCH_NODE_CMD = "cmmcli -n $HOSTNAME -g | grep accepted | grep -v \"UVM-0\" | grep -v \"SN-\" | cut -d \" \" -f1";
		public const string NODENAME_DEFAULT = "[DEFAULT]";
		
		public void Init_NodeList()
		{
			List<string> all_nodes = new List<string>();
			all_nodes.Add(NODENAME_DEFAULT);
			this.listBox_allNodes.DataSource = all_nodes;
		}
		public void Refresh_NodeList()
		{
			string local = main.ExecuteBlockCmd(FETCH_DEF_NODE_CMD);
			string output = main.ExecuteBlockCmd(FETCH_NODE_CMD);
			List<string> all_nodes = new List<string>();
			foreach (var nodename in  output.Split('\n')) {
				all_nodes.Add(nodename);
			}
			if (all_nodes.Count == 0) {
				all_nodes.Add(NODENAME_DEFAULT);
			}
			this.listBox_allNodes.DataSource = all_nodes;
			this.listBox_allNodes.ClearSelected();
			this.listBox_allNodes.SelectedIndex = listBox_allNodes.Items.IndexOf(local);
		}
		
		public List<string> GetSelectedNodes()
		{
			List<string> allnodes = new List<string>();
			foreach (string nodename in  listBox_allNodes.SelectedItems)
			{
				allnodes.Add(nodename);
			}
			return allnodes;
			
		}
		public string get_log_history(string inCmd)
		{
			string output = string.Empty;
			List<string> allnodes = GetSelectedNodes();
			
			foreach (string lnodename in allnodes) {
				if (lnodename.CompareTo(NODENAME_DEFAULT) == 0) {
					output += GetLogHistory(this.tb_hostIP.Text, this.tb_username.Text, this.tb_pwd.Text, inCmd, string.Empty);
				} else {
					output += GetLogHistory(this.tb_hostIP.Text, this.tb_username.Text, this.tb_pwd.Text, inCmd, lnodename);
				}
			}
			return output;
		}
		
		public string GetLogHistory(string inHost, string inUserName, string inPwd, string inCmd, string inNodeName)
		{
			string cmd = inCmd;
			if (inNodeName.TrimEnd().Length > 1) {
				cmd = string.Format(" ssh {0} \" {1}\"", inNodeName, inCmd);
			}
			string output = main.ExecuteBlockCmd(cmd);

			return output;
		}
	
		public void AddNodeRealLog(string inCmd, string inNodename)
		{
			string cmd = inCmd;
			if (inNodename.Length > 0) {
				cmd = string.Format("ssh {0} \" {1}\"", inNodename, inCmd);
			}
			sessionObj obj = new sessionObj(this.tb_hostIP.Text, this.tb_username.Text, this.tb_pwd.Text, cmd);
			all_session.Add(obj);
		}
		
		public void show_realtime_log(string cmd, Button inbt)
		{
			if (timer_refresh.Enabled == false) {
				this.tb_output.Clear();
				all_session.Clear();
				List<string> allnodes = GetSelectedNodes();
			
				foreach (string lnodename in allnodes) {
					if (lnodename.CompareTo(NODENAME_DEFAULT) == 0) {
						AddNodeRealLog(cmd, string.Empty);
					} else {
						AddNodeRealLog(cmd, lnodename.TrimEnd());
					}
				}
				timer_refresh.Enabled = true;
				this.tb_output.Text = cmd + System.Environment.NewLine;
				inbt.Text = inbt.Text.Replace("start", "stop");
				this.bt_run.Enabled = false;
				toolStripStatusLabel1.Text = "fetching runtime log!...";
			} else {
				this.tb_output.Text += string.Format("Command Stoped!");
				timer_refresh.Enabled = false;
				foreach (var item in all_session) {
					item.close();
				}
				all_session.Clear();
				inbt.Text = inbt.Text.Replace("stop", "start");
				this.bt_run.Enabled = true;
				toolStripStatusLabel1.Text = "Done!...";
			}
		}
		List<sessionObj> all_session;

		public void readstring()
		{
			foreach (var obj in all_session) {
				obj.checkOutput();
			}
			string line = string.Empty;
			do {
				line = logQ.get();
				if (line.Length == 0)
					return;
				this.tb_output.AppendText(line + Environment.NewLine);
			} while(true);
		}
		void Timer_refreshTick(object sender, EventArgs e)
		{
			readstring();	
		}
		public void update_dg_color(DataGridView in_dgv)
		{
			foreach (DataGridViewRow row in in_dgv.Rows) {
				int priority = Convert.ToInt32(row.Cells["PRIORITY"].Value);
				row.DefaultCellStyle.ForeColor = colorfontconfig.all_forecolor[priority];
				row.DefaultCellStyle.BackColor = colorfontconfig.all_backcolor[priority];
				row.DefaultCellStyle.Font = colorfontconfig.all_font[priority];
			}			
		}
		void Dgv_showDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			update_dg_color(dgv_show);
			dgv_show.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_show.Columns["DateTime"].Resizable = DataGridViewTriState.True;
			dgv_show.Columns["MESSAGE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_show.Columns["MESSAGE"].Resizable = DataGridViewTriState.True;
		}

		STRule journal_short_rule;
		public void RulesInit()
		{
			journal_short_rule = new STRule();
			journal_short_rule.RuleName = "journalctl rule with short-precise option";
			journal_short_rule.rType = STRuleType.Block;
			journal_short_rule.rFileOption = string.Empty;
			journal_short_rule.rFileName = string.Empty;
			RulesUpdate();
		}
		public void RulesUpdate()
		{
			journal_short_rule.rCmdLine = string.Format("journalctl -o short-precise --since='{0}' --until='{1}' {2}", dateTimePicker_Start.Value.ToString("u").TrimEnd('Z'), dateTimePicker_End.Value.ToString("u").TrimEnd('Z'), tb_filter.Text);
		}
		public void get_simple_log()
		{
			tb_output.Clear();
			main.ClearTask();
			RulesUpdate();
			STTask task;
			List<string> allnodes = GetSelectedNodes();
			
			foreach (string lnodename in allnodes) {
				task = new STTask();
				task.myRule = journal_short_rule;
				if (lnodename.CompareTo(NODENAME_DEFAULT) != 0)
					task.hName = lnodename;
				main.AddTask(task);
			}
			
			main.RunJob();
		}
		
		void Bt_connect_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "fetching node list!...";
			Refresh_NodeList();
			toolStripStatusLabel1.Text = "Done!";
		}

		void Bt_runClick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "fetching log history!...";
			get_simple_log();
			this.tbc_all.SelectedTab = this.tabPage1;
			toolStripStatusLabel1.Text = "Done!";
		}
		
		void Bt_log_history_colorClick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "fetching color log history!...";
			string cmd = string.Format("journalctl -o json --since='{0}' --until='{1}' {2}", dateTimePicker_Start.Value.ToString("u").TrimEnd('Z'), dateTimePicker_End.Value.ToString("u").TrimEnd('Z'), tb_filter.Text);
			string output = get_log_history(cmd);
			rtb_log.Clear();
			DataTable dt = new DataTable();
			/*
        "__CURSOR" : "s=47a690c5a74e41838c44143d0bceb9a0;i=19eee8;b=fd9302db86ba41beb9c5188eabbeb65a;m=2ecef794ea;t=533987267e48f;x=13992f420614b17e",
        "__REALTIME_TIMESTAMP" : "1464104731010191",
        "__MONOTONIC_TIMESTAMP" : "201040827626",
        "_BOOT_ID" : "fd9302db86ba41beb9c5188eabbeb65a",
        "_TRANSPORT" : "syslog",
        "PRIORITY" : "6",
        "_UID" : "0",
        "_GID" : "0",
        "_CAP_EFFECTIVE" : "3fffffffff",
        "_SYSTEMD_SLICE" : "system.slice",
        "_MACHINE_ID" : "6f58ab7818184c14856747f57c8a5a09",
        "_HOSTNAME" : "MMN-0",
        "_SYSTEMD_CGROUP" : "/system.slice/has.service",
        "_SYSTEMD_UNIT" : "has.service",
        "SYSLOG_FACILITY" : "17",
        "SYSLOG_IDENTIFIER" : "slapd",
        "SYSLOG_PID" : "2319",
        "_PID" : "2319",
        "_COMM" : "slapd",
        "_EXE" : "/usr/local/libexec/slapd",
        "_CMDLINE" : "/usr/local/libexec/slapd -d 0 -h ldap://Directory:389 -f fsPlatform.conf -l LOCAL1",
        "MESSAGE" : "May 24 23:45:31.00977 info tid=0x52574700 seq#160127 msg=\"CONNECTION CLOSED\" conn=\"21848\"",
        "_SOURCE_REALTIME_TIMESTAMP" : "1464104731009787"
			 */
			dt.Columns.Add("DateTime");
			dt.Columns.Add("MESSAGE");
			dt.Columns.Add("PRIORITY");
			dt.Columns.Add("_CMDLINE");
			dt.Columns.Add("_PID");
			dt.Columns.Add("SYSLOG_IDENTIFIER");
			dt.Columns.Add("_HOSTNAME");
			DataRow dr = null;
			string[] all_log_string = output.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
			foreach (var line in all_log_string) {
				{
					try {
						dynamic obj = JsonConvert.DeserializeObject(line);
						
						dr = dt.NewRow();
						DateTime dtime = STUtil.FromUnixTime(System.Convert.ToInt64(obj._SOURCE_REALTIME_TIMESTAMP));
						int priority = System.Convert.ToInt32(obj.PRIORITY);
						if (priority > 7)
							priority = 7;
						dr["DateTime"] = dtime.ToString("yyyy-MM-dd hh:mm:ss.ffffff");
						//dr["__REALTIME_TIMESTAMP"] = obj.__REALTIME_TIMESTAMP;
						dr["MESSAGE"] = obj.MESSAGE;
						dr["PRIORITY"] = priority;
						dr["_CMDLINE"] = obj._CMDLINE;
						dr["_PID"] = obj._PID;
						dr["SYSLOG_IDENTIFIER"] = obj.SYSLOG_IDENTIFIER;
						dr["_HOSTNAME"] = obj._HOSTNAME;
						dt.Rows.Add(dr);
						
						string msg = string.Format("{0} {1} {5} {2}[{3}]: {4}", 
							             dr["DateTime"].ToString(), dr["_HOSTNAME"].ToString(),
							             dr["SYSLOG_IDENTIFIER"].ToString(),
							             dr["_PID"].ToString(),
							             dr["MESSAGE"].ToString(),
							             colorfontconfig.all_priority[priority]);
						AddColorLog(rtb_log, msg, priority);
					} catch (Exception exc) {
						tb_debug.Text += exc.Message + Environment.NewLine + "\t" + line + Environment.NewLine;
					}
				}
				
			}
			this.dgv_show.DataSource = dt;
			this.tbc_all.SelectedTab = this.tabPage2;
			toolStripStatusLabel1.Text = "Done!";
		}
		
		public void AddColorLog(RichTextBox rtb, string intxt, int priority)
		{
			rtb.SelectionColor = colorfontconfig.all_forecolor[priority];
			rtb.SelectionBackColor = colorfontconfig.all_backcolor[priority];
			rtb.SelectionFont = colorfontconfig.all_font[priority];
			rtb.AppendText(intxt + Environment.NewLine);
		}
		
		void Bt_bt_runtimeClick(object sender, EventArgs e)
		{
			this.tbc_all.SelectedTab = this.tabPage1;
			show_realtime_log(string.Format(" journalctl -o short-precise -f {0}", tb_filter.Text), this.bt_runtime);	
		}

		void Bt_start_commonClick(object sender, EventArgs e)
		{
			this.tbc_all.SelectedTab = this.tabPage1;
			show_realtime_log(this.tb_common_cmd.Text, this.bt_start_common);	
		}

		void Bt_savelogClick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Saving log!...";
			saveFileDlg.InitialDirectory = Application.ExecutablePath;
			saveFileDlg.DereferenceLinks = false;
			if (this.saveFileDlg.ShowDialog() == DialogResult.OK) {
				File.WriteAllText(this.saveFileDlg.FileName, this.tb_output.Text);
			}
			toolStripStatusLabel1.Text = "Done!";
		}
		void Bt_setting_colorClick(object sender, EventArgs e)
		{
			ColorSelectionForm oform = new ColorSelectionForm(colorfontconfig.clone());
			if (oform.ShowDialog() == DialogResult.OK) {
				colorfontconfig = oform.config;
				update_dg_color(dgv_show);
			}
		}
		List<NonBlockFileSession> alltcpdump = new List<NonBlockFileSession>();
		List<NonBlockFileSession> allmonster = new List<NonBlockFileSession>();
		public void trigger_tcpdump()
		{
			trigger_nonblockfile(bt_tcpdump, alltcpdump, this.tb_tcpdump_cmd.Text, 
				this.tb_tcpdump_op.Text,
				this.tb_tcpdump_filename.Text);
		}
		public void trigger_monster()
		{
			trigger_nonblockfile(bt_monster, alltcpdump, this.tb_monster_cmd.Text, 
				this.tb_monster_op.Text,
				this.tb_monster_filename.Text);
		}
		public void create_new_nonblockfile_obj(List<NonBlockFileSession> inslist, string incmd, string inop, string infilename, string innodename)
		{
			NonBlockFileSession obj = new NonBlockFileSession(
				                          this.tb_hostIP.Text, 
				                          this.tb_username.Text, 
				                          this.tb_pwd.Text,
				                          incmd,
				                          inop,
				                          infilename,
				                          innodename);
			inslist.Add(obj);
			tb_debug.AppendText("[DEBUG] " + obj.myTask.GetCmdLine() + Environment.NewLine);
		}
		public void download_all_nonblockfile(string inHost, string inUserName, string inPwd, string remoteDirectory, string localfoldername)
		{
			using (var sftp = new SftpClient(inHost, inUserName, inPwd)) {
				sftp.Connect();
				var files = sftp.ListDirectory(remoteDirectory);
				string localfilename = string.Empty;
				foreach (var file in files) {
					if (!file.Name.StartsWith(".")) {
						string remoteFileName = file.Name;
						if (file.LastWriteTime.Date == DateTime.Today)
							Console.WriteLine(file.FullName);

						localfilename = Path.Combine(localfoldername, Path.GetFileName(file.Name));
						var file1 = File.OpenWrite(localfilename);
						sftp.DownloadFile(file.FullName, file1);
						file1.Close();
					}
				}			
			}
		}
		public void trigger_nonblockfile(Button inbutton, List<NonBlockFileSession> inslist, string incmd, string inop, string infilename)
		{
			tb_debug.AppendText(Environment.NewLine);
			string remotefolder = string.Format("/tmp/{0}/", DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss-ffffff"));
			if (inslist.Count > 0) {
				foreach (NonBlockFileSession c in inslist) {
					c.close();
					c.savefile(remotefolder);
				}
				inslist.Clear();
				inbutton.Text = inbutton.Text.Replace("stop", "start");
				string status = string.Empty;
				string localfolder = string.Empty;
				if (selectFolderDlg.ShowDialog() == DialogResult.OK) {
					localfolder = selectFolderDlg.SelectedPath;
					download_all_nonblockfile(this.tb_hostIP.Text, 
						this.tb_username.Text, 
						this.tb_pwd.Text,
						remotefolder,
						localfolder);
					status = "all file download to " + localfolder;
					if (MessageBox.Show(status, "Do you want to open the folder?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
						System.Diagnostics.Process.Start("explorer.exe", localfolder);
					}
				} else {
					status = "all file saved to " + remotefolder;
					MessageBox.Show(status, "Please download the file from the host");
				}
				toolStripStatusLabel1.Text = status;
			} else {
				List<string> allnodes = GetSelectedNodes();
			
				foreach (string lnodename in allnodes) {
					if (lnodename.CompareTo(NODENAME_DEFAULT) == 0) {
						create_new_nonblockfile_obj(inslist, incmd, inop, infilename, string.Empty);							
					} else {
						create_new_nonblockfile_obj(inslist, incmd, inop, infilename, lnodename);									
					}

				}
				inbutton.Text = inbutton.Text.Replace("start", "stop");
				toolStripStatusLabel1.Text = "Done!";
			}
		}
		void Bt_tcpdumpClick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "tcpdump function running!...";
			trigger_tcpdump();
		}
		void Bt_monsterClick(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "monster function running!...";
			trigger_monster();
		}
		void Tb_hostIPTextChanged(object sender, EventArgs e)
		{
			UpdateSSHParam();
		}
		
		List<CommonCommand> allCC = new List<CommonCommand>();
		public class CommonCommand
		{
			public string _name;
			public string Name{ get { return _name; } set { _name = value; } }
			public string cli;
			public CommonCommand()
			{
				_name = string.Empty;
				cli = string.Empty;
			}
			public CommonCommand(string inname, string incli)
			{
				_name = inname;
				cli = incli;
			}
		}
		void ComboBox_commonInit()
		{
			CommonCommand cc = new CommonCommand("Custom", "");
			allCC.Add(cc);
			cc = new CommonCommand("alarm", " journalctl -o short-precise -f | grep \" flexalarm\\[\"");
			allCC.Add(cc);
			cc = new CommonCommand("top all", " top -b");
			allCC.Add(cc);
//			cc = new CommonCommand("demo for loop","for((i=0; i<1;))do time;sleep 1;done;");
//			allCC.Add(cc);
//			
			comboBox_common.DataSource = allCC;
			comboBox_common.DisplayMember = "Name";
			comboBox_common.SelectedIndex = 0;
		}
		void ComboBox_commonSelectedIndexChanged(object sender, EventArgs e)
		{
			CommonCommand cc = allCC[comboBox_common.SelectedIndex];
			tb_common_cmd.Text = cc.cli;
			
			if (comboBox_common.SelectedIndex == 0) {
				tb_common_cmd.ReadOnly = false;
			} else {
				tb_common_cmd.ReadOnly = true;
			}
		}
		void Bt_configClick(object sender, EventArgs e)
		{	
			SSHRuleForm oform = new SSHRuleForm();
			oform.Show();
		}
	}
	
	public class SSHManager
	{
		public SSHWrapper runner;
		public SSHParam param;
		public STJob myJob;
		
		public TextBox tb;
		public RichTextBox rtb;
		
		public SSHManager(SSHParam inparam, TextBox intb, RichTextBox inrtb)
		{
			param = inparam;
			tb = intb;
			rtb = inrtb;
			runner = new SSHWrapper();
			myJob = new STJob();
		}
		public void ClearTask()
		{
			myJob.allTasks.Clear();
		}
		public void AddTask(STTask intask)
		{
			myJob.AddTask(intask);
		}
		public void RunJob()
		{
			foreach (STTask task in myJob.allTasks) {
				ExecuteTask(task);
			}
		}
		public string ExecuteTask(STTask intask)
		{
			if (intask.myRule.rType == STRuleType.Block) {
				string cmd = intask.GetCmdLine();
				tb.Text += cmd + Environment.NewLine + ExecuteBlockCmd(cmd).Replace("\n", Environment.NewLine) + Environment.NewLine;
			}
			return string.Empty;
		}
		
		public string ExecuteBlockCmd(string inCmd)
		{
			return runner.BlockExecute(param, inCmd);
		}
	}

}