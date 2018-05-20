/*
 * Created by SharpDevelop.
 * User: chenjia
 * Date: 2016/5/26
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Renci.SshNet;

namespace demossh
{
	/// <summary>
	/// Description of STComponent.
	/// </summary>
	public class STComponent
	{
		public STComponent()
		{
		}
	}
	public class sessionObj
	{
		public SshClient sshclient;
		public string sshcmdline;
		public SshCommand sshcmd;
		public string remainText;
			
		public sessionObj(string inHost, string inUserName, string inPwd, string inCmd)
		{
			try {
				sshclient = new SshClient(inHost, inUserName, inPwd);
				if (sshclient == null) {
					return;
				}
				sshclient.Connect();
				sshcmdline = inCmd;
				sshcmd = sshclient.CreateCommand(sshcmdline);
				var result = sshcmd.BeginExecute();
			} catch (Exception exc) {
				exc.ToString();
			}
				
		}
			
		public void checkOutput()
		{
			if (sshclient == null) {
				return;
			}
			StreamReader reader = new StreamReader(sshcmd.OutputStream);
			remainText += reader.ReadToEnd();
			string[] all_line = remainText.Split('\n');
			int all_line_size = all_line.Length;
			if (all_line_size < 1)
				return;
			
			remainText = all_line[all_line_size - 1];
			Array.Resize(ref all_line, all_line_size - 1);
			logQ.add(all_line);
		}
			
		public void close()
		{
			if (sshclient == null) {
				return;
			}
			sshclient.Disconnect();
		}
			
	}
	public class NonBlockFileSession
	{
		public SshClient sshclient;
		public SshCommand sshcmd;
		public IAsyncResult ssharesult;
		
		public SSHParam sshParam;
		public STTask myTask;
		
		public string filestorefolder;
		
		public NonBlockFileSession(string inHost, string inUserName, string inPwd, string inCmd, string inOP, string infilename, string innodename)
		{
			SSHParam para = new SSHParam(inHost, inUserName, inPwd);
			STRule rule = new STRule();
			rule.rCmdLine = inCmd;
			rule.rFileOption = inOP;
			rule.rFileName = infilename;
			rule.rType = STRuleType.NonBlockFile;
			rule.rName = "NonBlockFileSession internal";
			Init(para, rule, innodename);
		}
		
		public void Init(SSHParam inparam, STRule inrule, string innodename)
		{
			sshParam = inparam;
			string filepathname = string.Format("/tmp/{0}{1}{2}", innodename, DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss"), inrule.rFileName);
			inrule.rFileName = filepathname;
			STTask task = new STTask();
			task.myRule = inrule;
			task.hName = innodename;
			task.GetCmdLine();
			myTask = task;
			try {
				sshclient = new SshClient(sshParam.hostIP, sshParam.userName, sshParam.userPWD);
				if (sshclient == null) {
					return;
				}
				sshclient.Connect();
				sshcmd = sshclient.CreateCommand(task.GetCmdLine());
				ssharesult = sshcmd.BeginExecute();
			} catch (Exception exc) {
				exc.ToString();
			}
		}
		public void savefile(string inlocalfolder)
		{
			using(SshClient tmpclient = new SshClient(sshParam.hostIP, sshParam.userName, sshParam.userPWD))
			{
				tmpclient.Connect();
				string tmpcli = string.Format("mkdir -p {0}", inlocalfolder);
				SshCommand tmpcmd = tmpclient.CreateCommand(tmpcli);
				tmpcmd.Execute();
				tmpcli = string.Format("mv {0} {1}", myTask.myRule.rFileName, inlocalfolder);
				if(myTask.hName.Length>0)
				{
					tmpcli = string.Format("scp {0}:{1} {2}", myTask.hName, myTask.myRule.rFileName, inlocalfolder);
				}
				tmpcmd.Execute(tmpcli);
				if(myTask.hName.Length>0)
				{
					tmpcli = string.Format("ssh {0} rm {1}", myTask.hName, myTask.myRule.rFileName);
					tmpcmd.Execute(tmpcli);
				}
			}
		}
		public void close()
		{
			if (sshclient == null) {
				return;
			}
			using(SshClient tmpclient = new SshClient(sshParam.hostIP, sshParam.userName, sshParam.userPWD))
			{
				tmpclient.Connect();
				string killcmd = string.Format("ps -ef | grep '{0}' | grep -v grep | awk '{{print $2}}'", myTask.myRule.rFileName);
				if(myTask.hName.Length>0)
				{
					killcmd = string.Format("ssh {0} \" {1} \"", myTask.hName, killcmd);
				}
				killcmd = string.Format("kill  `{0}`", killcmd);
				if(myTask.hName.Length>0)
				{
					killcmd = string.Format("ssh {0} \" {1} \"", myTask.hName, killcmd);
				}
				SshCommand tmpcmd = tmpclient.CreateCommand(killcmd);
				tmpcmd.Execute();
				tmpcmd.Execute();
			}
			try
			{
			//sshcmd.CancelAsync();
			sshcmd.EndExecute(ssharesult);
			sshclient.Disconnect();
			}
			catch(Exception exc)
			{
				
			}
		}
			
	}
		
	public class logQ
	{
		public static void Init()
		{
			all_logs = new List<string>();
		}
		public static List<string> all_logs;
		public static void add(string[] inlogs)
		{
			if ((inlogs != null) && (inlogs.Length > 0)) {
				lock (all_logs) {
					foreach (var line in inlogs) {
						all_logs.Add(line);
					}
				}
			}
		}
		public static string get()
		{
			string value = string.Empty;
			lock (all_logs) {
				if (all_logs.Count > 0) {
					value = all_logs[0];
					all_logs.Remove(value);
				}
			}
			return value;
		}
	}
	public enum STRuleType
	{
		Block,
		NonBlockShow,
		NonBlockFile
	}

	public class STRule
	{

		public string rName;
		public STRuleType rType;
		public string rCmdLine;
		public string rFileOption;
		public string rFileName;
		public STRule()
		{
			rName = "NoName";
			rType = STRuleType.Block;
			rCmdLine = "echo ?";
			rFileOption = ">";
			rFileName = string.Empty;
			
		}
		public string RuleName{ get { return rName; } set { rName = value; } }
		public STRuleType RuleType{ get { return rType; } set { rType = value; } }
		public string RuleCmdLine{ get { return rCmdLine; } set { rCmdLine = value; } }
		public string RuleFileOption{ get { return rFileOption; } set { rFileOption = value; } }
		public string RuleFileName{ get { return rFileName; } set { rFileName = value; } }
		
		public string GetCmdLine()
		{
			return string.Format("{0} {1} {2}", rCmdLine, rFileOption, rFileName);
		}
	
	}
	
	public class STTask
	{
		public string hName;
		public int hPort;
		public STRule myRule;
		public string HostName{ get { return hName; } set { value = hName; } }
		public STTask()
		{
			hName = string.Empty;
			hPort = 22;
			myRule = null;
		}
		
		public string GetCmdLine()
		{
			if (myRule == null)
				return string.Empty;
			
			if (hName.Length == 0) {
				return myRule.GetCmdLine();
			} else {
				return string.Format("ssh {0} \" {1} \"", hName, myRule.GetCmdLine());
			}
		}
	}
	public class STJob
	{
		public string jobName;
		public List<STTask> allTasks;
		public STJob()
		{
			jobName = string.Empty;
			allTasks = new List<STTask>();
		}
		public void AddTask(STTask inTask)
		{
			allTasks.Add(inTask);
		}
			
	}
	
	public class SSHParam
	{
		public string hostIP;
		public string userName;
		public string userPWD;
		public SSHParam(string inIP, string inusername, string inuserpwd)
		{
			Update(inIP, inusername, inuserpwd);
		}
		
		public void Update(string inIP, string inusername, string inuserpwd)
		{
			hostIP = inIP;
			userName = inusername;
			userPWD = inuserpwd;
		}
	}
	
	public class SSHWrapper
	{
		public string _Error;
		public string ErrorInof{ get { return _Error; } }
		public SSHWrapper()
		{
			_Error = string.Empty;
		}
		public string BlockExecute(SSHParam inparam, string inCmd)
		{
			string lOutput = string.Empty;
			try {
				using (var client = new SshClient(inparam.hostIP, inparam.userName, inparam.userPWD)) {
					client.Connect();
					SshCommand cmd = client.CreateCommand(inCmd);
					lOutput = cmd.Execute().TrimEnd();
				}
			} catch (Exception exc) {
				_Error += "ExecuteCmdOnSSHServer failed " + exc.Message + Environment.NewLine;
			}
			return lOutput;
		}
		

	}
	
	public static class STUtil
	{
		public static DateTime epoch;
		
		static STUtil()
		{
			epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddHours(8);
		}
		
		public static DateTime FromUnixTime(long unixTime)
		{
			return epoch.AddTicks(unixTime * 10);
		}
	}
}
