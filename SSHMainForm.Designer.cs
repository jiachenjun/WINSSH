namespace demossh
{
    partial class SSHMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SSHMainForm));
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.groupBox7 = new System.Windows.Forms.GroupBox();
        	this.comboBox_common = new System.Windows.Forms.ComboBox();
        	this.bt_start_common = new System.Windows.Forms.Button();
        	this.tb_common_cmd = new System.Windows.Forms.TextBox();
        	this.bt_savelog = new System.Windows.Forms.Button();
        	this.label13 = new System.Windows.Forms.Label();
        	this.groupBox6 = new System.Windows.Forms.GroupBox();
        	this.bt_monster = new System.Windows.Forms.Button();
        	this.tb_monster_filename = new System.Windows.Forms.TextBox();
        	this.label10 = new System.Windows.Forms.Label();
        	this.label11 = new System.Windows.Forms.Label();
        	this.tb_monster_op = new System.Windows.Forms.TextBox();
        	this.label12 = new System.Windows.Forms.Label();
        	this.tb_monster_cmd = new System.Windows.Forms.TextBox();
        	this.groupBox5 = new System.Windows.Forms.GroupBox();
        	this.bt_tcpdump = new System.Windows.Forms.Button();
        	this.tb_tcpdump_filename = new System.Windows.Forms.TextBox();
        	this.label9 = new System.Windows.Forms.Label();
        	this.label8 = new System.Windows.Forms.Label();
        	this.tb_tcpdump_op = new System.Windows.Forms.TextBox();
        	this.label7 = new System.Windows.Forms.Label();
        	this.tb_tcpdump_cmd = new System.Windows.Forms.TextBox();
        	this.groupBox4 = new System.Windows.Forms.GroupBox();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.bt_setting_color = new System.Windows.Forms.Button();
        	this.bt_log_history_color = new System.Windows.Forms.Button();
        	this.label6 = new System.Windows.Forms.Label();
        	this.tb_filter = new System.Windows.Forms.TextBox();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.dateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
        	this.dateTimePicker_End = new System.Windows.Forms.DateTimePicker();
        	this.label1 = new System.Windows.Forms.Label();
        	this.bt_run = new System.Windows.Forms.Button();
        	this.bt_runtime = new System.Windows.Forms.Button();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.tb_hostIP = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.tb_pwd = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.tb_username = new System.Windows.Forms.TextBox();
        	this.splitContainer_Bottom = new System.Windows.Forms.SplitContainer();
        	this.listBox_allNodes = new System.Windows.Forms.ListBox();
        	this.bt_connect = new System.Windows.Forms.Button();
        	this.tbc_all = new System.Windows.Forms.TabControl();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.tb_output = new System.Windows.Forms.TextBox();
        	this.tabPage3 = new System.Windows.Forms.TabPage();
        	this.rtb_log = new System.Windows.Forms.RichTextBox();
        	this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.dgv_show = new System.Windows.Forms.DataGridView();
        	this.tabPage4 = new System.Windows.Forms.TabPage();
        	this.tb_debug = new System.Windows.Forms.TextBox();
        	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.timer_refresh = new System.Windows.Forms.Timer(this.components);
        	this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
        	this.selectFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
        	this.bt_config = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.groupBox7.SuspendLayout();
        	this.groupBox6.SuspendLayout();
        	this.groupBox5.SuspendLayout();
        	this.groupBox4.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.groupBox3.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer_Bottom)).BeginInit();
        	this.splitContainer_Bottom.Panel1.SuspendLayout();
        	this.splitContainer_Bottom.Panel2.SuspendLayout();
        	this.splitContainer_Bottom.SuspendLayout();
        	this.tbc_all.SuspendLayout();
        	this.tabPage1.SuspendLayout();
        	this.tabPage3.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
        	this.tabPage4.SuspendLayout();
        	this.statusStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer1.Name = "splitContainer1";
        	this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.bt_config);
        	this.splitContainer1.Panel1.Controls.Add(this.groupBox7);
        	this.splitContainer1.Panel1.Controls.Add(this.bt_savelog);
        	this.splitContainer1.Panel1.Controls.Add(this.label13);
        	this.splitContainer1.Panel1.Controls.Add(this.groupBox6);
        	this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
        	this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
        	this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.splitContainer_Bottom);
        	this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
        	this.splitContainer1.Size = new System.Drawing.Size(1056, 625);
        	this.splitContainer1.SplitterDistance = 209;
        	this.splitContainer1.SplitterWidth = 5;
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// groupBox7
        	// 
        	this.groupBox7.Controls.Add(this.comboBox_common);
        	this.groupBox7.Controls.Add(this.bt_start_common);
        	this.groupBox7.Controls.Add(this.tb_common_cmd);
        	this.groupBox7.Location = new System.Drawing.Point(193, 140);
        	this.groupBox7.Name = "groupBox7";
        	this.groupBox7.Size = new System.Drawing.Size(894, 59);
        	this.groupBox7.TabIndex = 28;
        	this.groupBox7.TabStop = false;
        	this.groupBox7.Text = "RunTime Common Command:";
        	// 
        	// comboBox_common
        	// 
        	this.comboBox_common.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox_common.FormattingEnabled = true;
        	this.comboBox_common.Location = new System.Drawing.Point(683, 21);
        	this.comboBox_common.Name = "comboBox_common";
        	this.comboBox_common.Size = new System.Drawing.Size(121, 24);
        	this.comboBox_common.TabIndex = 28;
        	this.comboBox_common.SelectedIndexChanged += new System.EventHandler(this.ComboBox_commonSelectedIndexChanged);
        	// 
        	// bt_start_common
        	// 
        	this.bt_start_common.Location = new System.Drawing.Point(6, 22);
        	this.bt_start_common.Name = "bt_start_common";
        	this.bt_start_common.Size = new System.Drawing.Size(107, 23);
        	this.bt_start_common.TabIndex = 27;
        	this.bt_start_common.Text = "start cmd";
        	this.bt_start_common.UseVisualStyleBackColor = true;
        	this.bt_start_common.Click += new System.EventHandler(this.Bt_start_commonClick);
        	// 
        	// tb_common_cmd
        	// 
        	this.tb_common_cmd.Location = new System.Drawing.Point(119, 23);
        	this.tb_common_cmd.Name = "tb_common_cmd";
        	this.tb_common_cmd.Size = new System.Drawing.Size(558, 22);
        	this.tb_common_cmd.TabIndex = 21;
        	this.tb_common_cmd.Text = "top -b";
        	// 
        	// bt_savelog
        	// 
        	this.bt_savelog.Location = new System.Drawing.Point(12, 128);
        	this.bt_savelog.Name = "bt_savelog";
        	this.bt_savelog.Size = new System.Drawing.Size(107, 25);
        	this.bt_savelog.TabIndex = 17;
        	this.bt_savelog.Text = "SaveLog";
        	this.bt_savelog.UseVisualStyleBackColor = true;
        	this.bt_savelog.Click += new System.EventHandler(this.Bt_savelogClick);
        	// 
        	// label13
        	// 
        	this.label13.AutoSize = true;
        	this.label13.Location = new System.Drawing.Point(506, 140);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(34, 16);
        	this.label13.TabIndex = 21;
        	this.label13.Text = "cmd:";
        	// 
        	// groupBox6
        	// 
        	this.groupBox6.Controls.Add(this.bt_monster);
        	this.groupBox6.Controls.Add(this.tb_monster_filename);
        	this.groupBox6.Controls.Add(this.label10);
        	this.groupBox6.Controls.Add(this.label11);
        	this.groupBox6.Controls.Add(this.tb_monster_op);
        	this.groupBox6.Controls.Add(this.label12);
        	this.groupBox6.Controls.Add(this.tb_monster_cmd);
        	this.groupBox6.Location = new System.Drawing.Point(876, 12);
        	this.groupBox6.Name = "groupBox6";
        	this.groupBox6.Size = new System.Drawing.Size(174, 122);
        	this.groupBox6.TabIndex = 26;
        	this.groupBox6.TabStop = false;
        	this.groupBox6.Text = "monster:";
        	// 
        	// bt_monster
        	// 
        	this.bt_monster.Location = new System.Drawing.Point(10, 86);
        	this.bt_monster.Name = "bt_monster";
        	this.bt_monster.Size = new System.Drawing.Size(107, 27);
        	this.bt_monster.TabIndex = 15;
        	this.bt_monster.Text = "start monster";
        	this.bt_monster.UseVisualStyleBackColor = true;
        	this.bt_monster.Click += new System.EventHandler(this.Bt_monsterClick);
        	// 
        	// tb_monster_filename
        	// 
        	this.tb_monster_filename.Location = new System.Drawing.Point(70, 62);
        	this.tb_monster_filename.Name = "tb_monster_filename";
        	this.tb_monster_filename.Size = new System.Drawing.Size(68, 22);
        	this.tb_monster_filename.TabIndex = 25;
        	this.tb_monster_filename.Text = "m.bin";
        	// 
        	// label10
        	// 
        	this.label10.AutoSize = true;
        	this.label10.Location = new System.Drawing.Point(8, 68);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(56, 16);
        	this.label10.TabIndex = 24;
        	this.label10.Text = "file name";
        	// 
        	// label11
        	// 
        	this.label11.AutoSize = true;
        	this.label11.Location = new System.Drawing.Point(8, 46);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(107, 16);
        	this.label11.TabIndex = 22;
        	this.label11.Text = "file option(-o or >)";
        	// 
        	// tb_monster_op
        	// 
        	this.tb_monster_op.Location = new System.Drawing.Point(123, 43);
        	this.tb_monster_op.Name = "tb_monster_op";
        	this.tb_monster_op.Size = new System.Drawing.Size(40, 22);
        	this.tb_monster_op.TabIndex = 23;
        	this.tb_monster_op.Text = "-o";
        	// 
        	// label12
        	// 
        	this.label12.AutoSize = true;
        	this.label12.Location = new System.Drawing.Point(6, 24);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(34, 16);
        	this.label12.TabIndex = 21;
        	this.label12.Text = "cmd:";
        	// 
        	// tb_monster_cmd
        	// 
        	this.tb_monster_cmd.Location = new System.Drawing.Point(46, 21);
        	this.tb_monster_cmd.Name = "tb_monster_cmd";
        	this.tb_monster_cmd.Size = new System.Drawing.Size(117, 22);
        	this.tb_monster_cmd.TabIndex = 21;
        	this.tb_monster_cmd.Text = "monster  -f ALL";
        	// 
        	// groupBox5
        	// 
        	this.groupBox5.Controls.Add(this.bt_tcpdump);
        	this.groupBox5.Controls.Add(this.tb_tcpdump_filename);
        	this.groupBox5.Controls.Add(this.label9);
        	this.groupBox5.Controls.Add(this.label8);
        	this.groupBox5.Controls.Add(this.tb_tcpdump_op);
        	this.groupBox5.Controls.Add(this.label7);
        	this.groupBox5.Controls.Add(this.tb_tcpdump_cmd);
        	this.groupBox5.Location = new System.Drawing.Point(687, 12);
        	this.groupBox5.Name = "groupBox5";
        	this.groupBox5.Size = new System.Drawing.Size(183, 125);
        	this.groupBox5.TabIndex = 22;
        	this.groupBox5.TabStop = false;
        	this.groupBox5.Text = "tcpdump:";
        	// 
        	// bt_tcpdump
        	// 
        	this.bt_tcpdump.Location = new System.Drawing.Point(10, 90);
        	this.bt_tcpdump.Name = "bt_tcpdump";
        	this.bt_tcpdump.Size = new System.Drawing.Size(107, 27);
        	this.bt_tcpdump.TabIndex = 15;
        	this.bt_tcpdump.Text = "start tcpdump";
        	this.bt_tcpdump.UseVisualStyleBackColor = true;
        	this.bt_tcpdump.Click += new System.EventHandler(this.Bt_tcpdumpClick);
        	// 
        	// tb_tcpdump_filename
        	// 
        	this.tb_tcpdump_filename.Location = new System.Drawing.Point(70, 62);
        	this.tb_tcpdump_filename.Name = "tb_tcpdump_filename";
        	this.tb_tcpdump_filename.Size = new System.Drawing.Size(68, 22);
        	this.tb_tcpdump_filename.TabIndex = 25;
        	this.tb_tcpdump_filename.Text = "abc.pcap";
        	// 
        	// label9
        	// 
        	this.label9.AutoSize = true;
        	this.label9.Location = new System.Drawing.Point(8, 68);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(56, 16);
        	this.label9.TabIndex = 24;
        	this.label9.Text = "file name";
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(8, 46);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(109, 16);
        	this.label8.TabIndex = 22;
        	this.label8.Text = "file option(-w or >)";
        	// 
        	// tb_tcpdump_op
        	// 
        	this.tb_tcpdump_op.Location = new System.Drawing.Point(123, 43);
        	this.tb_tcpdump_op.Name = "tb_tcpdump_op";
        	this.tb_tcpdump_op.Size = new System.Drawing.Size(40, 22);
        	this.tb_tcpdump_op.TabIndex = 23;
        	this.tb_tcpdump_op.Text = "-w";
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(6, 24);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(34, 16);
        	this.label7.TabIndex = 21;
        	this.label7.Text = "cmd:";
        	// 
        	// tb_tcpdump_cmd
        	// 
        	this.tb_tcpdump_cmd.Location = new System.Drawing.Point(46, 21);
        	this.tb_tcpdump_cmd.Name = "tb_tcpdump_cmd";
        	this.tb_tcpdump_cmd.Size = new System.Drawing.Size(133, 22);
        	this.tb_tcpdump_cmd.TabIndex = 21;
        	this.tb_tcpdump_cmd.Text = "tcpdump -i any sctp";
        	// 
        	// groupBox4
        	// 
        	this.groupBox4.Controls.Add(this.groupBox2);
        	this.groupBox4.Controls.Add(this.label6);
        	this.groupBox4.Controls.Add(this.tb_filter);
        	this.groupBox4.Controls.Add(this.groupBox3);
        	this.groupBox4.Controls.Add(this.bt_runtime);
        	this.groupBox4.Location = new System.Drawing.Point(193, 9);
        	this.groupBox4.Name = "groupBox4";
        	this.groupBox4.Size = new System.Drawing.Size(488, 125);
        	this.groupBox4.TabIndex = 21;
        	this.groupBox4.TabStop = false;
        	this.groupBox4.Text = "journal log:";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.bt_setting_color);
        	this.groupBox2.Controls.Add(this.bt_log_history_color);
        	this.groupBox2.Location = new System.Drawing.Point(318, 43);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(158, 79);
        	this.groupBox2.TabIndex = 19;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "colorlog";
        	// 
        	// bt_setting_color
        	// 
        	this.bt_setting_color.Location = new System.Drawing.Point(21, 15);
        	this.bt_setting_color.Name = "bt_setting_color";
        	this.bt_setting_color.Size = new System.Drawing.Size(122, 23);
        	this.bt_setting_color.TabIndex = 0;
        	this.bt_setting_color.Text = "Set Color";
        	this.bt_setting_color.UseVisualStyleBackColor = true;
        	this.bt_setting_color.Click += new System.EventHandler(this.Bt_setting_colorClick);
        	// 
        	// bt_log_history_color
        	// 
        	this.bt_log_history_color.Location = new System.Drawing.Point(21, 42);
        	this.bt_log_history_color.Name = "bt_log_history_color";
        	this.bt_log_history_color.Size = new System.Drawing.Size(122, 30);
        	this.bt_log_history_color.TabIndex = 18;
        	this.bt_log_history_color.Text = "get color log history";
        	this.bt_log_history_color.UseVisualStyleBackColor = true;
        	this.bt_log_history_color.Click += new System.EventHandler(this.Bt_log_history_colorClick);
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(17, 18);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(84, 16);
        	this.label6.TabIndex = 15;
        	this.label6.Text = "journal param:";
        	// 
        	// tb_filter
        	// 
        	this.tb_filter.Location = new System.Drawing.Point(104, 15);
        	this.tb_filter.Name = "tb_filter";
        	this.tb_filter.Size = new System.Drawing.Size(245, 22);
        	this.tb_filter.TabIndex = 16;
        	this.tb_filter.Text = " -p4";
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Controls.Add(this.label2);
        	this.groupBox3.Controls.Add(this.dateTimePicker_Start);
        	this.groupBox3.Controls.Add(this.dateTimePicker_End);
        	this.groupBox3.Controls.Add(this.label1);
        	this.groupBox3.Controls.Add(this.bt_run);
        	this.groupBox3.Location = new System.Drawing.Point(17, 43);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(295, 79);
        	this.groupBox3.TabIndex = 20;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "simplelog";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(90, 54);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(31, 16);
        	this.label2.TabIndex = 4;
        	this.label2.Text = "End:";
        	// 
        	// dateTimePicker_Start
        	// 
        	this.dateTimePicker_Start.CustomFormat = "yyyy-MM-dd hh:mm:ss";
        	this.dateTimePicker_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.dateTimePicker_Start.Location = new System.Drawing.Point(131, 27);
        	this.dateTimePicker_Start.Name = "dateTimePicker_Start";
        	this.dateTimePicker_Start.Size = new System.Drawing.Size(155, 22);
        	this.dateTimePicker_Start.TabIndex = 1;
        	// 
        	// dateTimePicker_End
        	// 
        	this.dateTimePicker_End.CustomFormat = "yyyy-MM-dd hh:mm:ss";
        	this.dateTimePicker_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.dateTimePicker_End.Location = new System.Drawing.Point(131, 52);
        	this.dateTimePicker_End.Name = "dateTimePicker_End";
        	this.dateTimePicker_End.Size = new System.Drawing.Size(155, 22);
        	this.dateTimePicker_End.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(90, 28);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(35, 16);
        	this.label1.TabIndex = 3;
        	this.label1.Text = "Start:";
        	// 
        	// bt_run
        	// 
        	this.bt_run.Location = new System.Drawing.Point(7, 21);
        	this.bt_run.Name = "bt_run";
        	this.bt_run.Size = new System.Drawing.Size(77, 28);
        	this.bt_run.TabIndex = 12;
        	this.bt_run.Text = " log history";
        	this.bt_run.UseVisualStyleBackColor = true;
        	this.bt_run.Click += new System.EventHandler(this.Bt_runClick);
        	// 
        	// bt_runtime
        	// 
        	this.bt_runtime.Location = new System.Drawing.Point(355, 10);
        	this.bt_runtime.Name = "bt_runtime";
        	this.bt_runtime.Size = new System.Drawing.Size(107, 27);
        	this.bt_runtime.TabIndex = 14;
        	this.bt_runtime.Text = "start runtime";
        	this.bt_runtime.UseVisualStyleBackColor = true;
        	this.bt_runtime.Click += new System.EventHandler(this.Bt_bt_runtimeClick);
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.tb_hostIP);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.tb_pwd);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.label5);
        	this.groupBox1.Controls.Add(this.tb_username);
        	this.groupBox1.Location = new System.Drawing.Point(12, 12);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(175, 110);
        	this.groupBox1.TabIndex = 13;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Host configuration:";
        	// 
        	// tb_hostIP
        	// 
        	this.tb_hostIP.Location = new System.Drawing.Point(55, 21);
        	this.tb_hostIP.Name = "tb_hostIP";
        	this.tb_hostIP.Size = new System.Drawing.Size(102, 22);
        	this.tb_hostIP.TabIndex = 5;
        	this.tb_hostIP.TextChanged += new System.EventHandler(this.Tb_hostIPTextChanged);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(10, 26);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(36, 16);
        	this.label3.TabIndex = 7;
        	this.label3.Text = "Host:";
        	// 
        	// tb_pwd
        	// 
        	this.tb_pwd.Location = new System.Drawing.Point(81, 75);
        	this.tb_pwd.Name = "tb_pwd";
        	this.tb_pwd.Size = new System.Drawing.Size(76, 22);
        	this.tb_pwd.TabIndex = 11;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(10, 47);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(65, 16);
        	this.label4.TabIndex = 8;
        	this.label4.Text = "UserName:";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(14, 72);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(61, 16);
        	this.label5.TabIndex = 10;
        	this.label5.Text = "Password:";
        	// 
        	// tb_username
        	// 
        	this.tb_username.Location = new System.Drawing.Point(81, 47);
        	this.tb_username.Name = "tb_username";
        	this.tb_username.Size = new System.Drawing.Size(76, 22);
        	this.tb_username.TabIndex = 9;
        	// 
        	// splitContainer_Bottom
        	// 
        	this.splitContainer_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer_Bottom.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer_Bottom.Name = "splitContainer_Bottom";
        	// 
        	// splitContainer_Bottom.Panel1
        	// 
        	this.splitContainer_Bottom.Panel1.Controls.Add(this.listBox_allNodes);
        	this.splitContainer_Bottom.Panel1.Controls.Add(this.bt_connect);
        	// 
        	// splitContainer_Bottom.Panel2
        	// 
        	this.splitContainer_Bottom.Panel2.Controls.Add(this.tbc_all);
        	this.splitContainer_Bottom.Size = new System.Drawing.Size(1056, 389);
        	this.splitContainer_Bottom.SplitterDistance = 100;
        	this.splitContainer_Bottom.TabIndex = 3;
        	// 
        	// listBox_allNodes
        	// 
        	this.listBox_allNodes.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.listBox_allNodes.FormattingEnabled = true;
        	this.listBox_allNodes.ItemHeight = 16;
        	this.listBox_allNodes.Location = new System.Drawing.Point(0, 37);
        	this.listBox_allNodes.Name = "listBox_allNodes";
        	this.listBox_allNodes.ScrollAlwaysVisible = true;
        	this.listBox_allNodes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        	this.listBox_allNodes.Size = new System.Drawing.Size(100, 352);
        	this.listBox_allNodes.TabIndex = 0;
        	// 
        	// bt_connect
        	// 
        	this.bt_connect.Dock = System.Windows.Forms.DockStyle.Top;
        	this.bt_connect.Location = new System.Drawing.Point(0, 0);
        	this.bt_connect.Name = "bt_connect";
        	this.bt_connect.Size = new System.Drawing.Size(100, 37);
        	this.bt_connect.TabIndex = 0;
        	this.bt_connect.Text = "加载Node";
        	this.bt_connect.UseVisualStyleBackColor = true;
        	this.bt_connect.Click += new System.EventHandler(this.Bt_connect_Click);
        	// 
        	// tbc_all
        	// 
        	this.tbc_all.Controls.Add(this.tabPage1);
        	this.tbc_all.Controls.Add(this.tabPage3);
        	this.tbc_all.Controls.Add(this.tabPage2);
        	this.tbc_all.Controls.Add(this.tabPage4);
        	this.tbc_all.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tbc_all.Location = new System.Drawing.Point(0, 0);
        	this.tbc_all.Name = "tbc_all";
        	this.tbc_all.SelectedIndex = 0;
        	this.tbc_all.Size = new System.Drawing.Size(952, 389);
        	this.tbc_all.TabIndex = 2;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.tb_output);
        	this.tabPage1.Location = new System.Drawing.Point(4, 25);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage1.Size = new System.Drawing.Size(944, 360);
        	this.tabPage1.TabIndex = 0;
        	this.tabPage1.Text = "log";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// tb_output
        	// 
        	this.tb_output.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tb_output.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tb_output.Location = new System.Drawing.Point(3, 3);
        	this.tb_output.MaxLength = 100;
        	this.tb_output.Multiline = true;
        	this.tb_output.Name = "tb_output";
        	this.tb_output.ReadOnly = true;
        	this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.tb_output.Size = new System.Drawing.Size(938, 354);
        	this.tb_output.TabIndex = 0;
        	this.tb_output.WordWrap = false;
        	// 
        	// tabPage3
        	// 
        	this.tabPage3.Controls.Add(this.rtb_log);
        	this.tabPage3.Location = new System.Drawing.Point(4, 22);
        	this.tabPage3.Name = "tabPage3";
        	this.tabPage3.Size = new System.Drawing.Size(944, 363);
        	this.tabPage3.TabIndex = 2;
        	this.tabPage3.Text = "color log";
        	this.tabPage3.UseVisualStyleBackColor = true;
        	// 
        	// rtb_log
        	// 
        	this.rtb_log.ContextMenuStrip = this.contextMenuStrip1;
        	this.rtb_log.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.rtb_log.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.rtb_log.Location = new System.Drawing.Point(0, 0);
        	this.rtb_log.Name = "rtb_log";
        	this.rtb_log.ReadOnly = true;
        	this.rtb_log.Size = new System.Drawing.Size(944, 363);
        	this.rtb_log.TabIndex = 0;
        	this.rtb_log.Text = "";
        	this.rtb_log.WordWrap = false;
        	// 
        	// contextMenuStrip1
        	// 
        	this.contextMenuStrip1.Name = "contextMenuStrip1";
        	this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.dgv_show);
        	this.tabPage2.Location = new System.Drawing.Point(4, 22);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(944, 363);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "color table";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// dgv_show
        	// 
        	this.dgv_show.AllowUserToOrderColumns = true;
        	this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgv_show.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dgv_show.Location = new System.Drawing.Point(3, 3);
        	this.dgv_show.Name = "dgv_show";
        	this.dgv_show.ReadOnly = true;
        	this.dgv_show.RowTemplate.Height = 23;
        	this.dgv_show.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgv_show.Size = new System.Drawing.Size(938, 357);
        	this.dgv_show.TabIndex = 0;
        	this.dgv_show.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Dgv_showDataBindingComplete);
        	// 
        	// tabPage4
        	// 
        	this.tabPage4.Controls.Add(this.tb_debug);
        	this.tabPage4.Location = new System.Drawing.Point(4, 22);
        	this.tabPage4.Name = "tabPage4";
        	this.tabPage4.Size = new System.Drawing.Size(944, 363);
        	this.tabPage4.TabIndex = 3;
        	this.tabPage4.Text = "debug";
        	this.tabPage4.UseVisualStyleBackColor = true;
        	// 
        	// tb_debug
        	// 
        	this.tb_debug.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tb_debug.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tb_debug.Location = new System.Drawing.Point(0, 0);
        	this.tb_debug.Multiline = true;
        	this.tb_debug.Name = "tb_debug";
        	this.tb_debug.ReadOnly = true;
        	this.tb_debug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        	this.tb_debug.Size = new System.Drawing.Size(944, 363);
        	this.tb_debug.TabIndex = 0;
        	this.tb_debug.Text = "有bug啦!";
        	this.tb_debug.WordWrap = false;
        	// 
        	// statusStrip1
        	// 
        	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.toolStripStatusLabel1});
        	this.statusStrip1.Location = new System.Drawing.Point(0, 389);
        	this.statusStrip1.Name = "statusStrip1";
        	this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
        	this.statusStrip1.TabIndex = 1;
        	this.statusStrip1.Text = "statusStrip1";
        	// 
        	// toolStripStatusLabel1
        	// 
        	this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        	this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
        	this.toolStripStatusLabel1.Text = "Done!...";
        	// 
        	// timer_refresh
        	// 
        	this.timer_refresh.Tick += new System.EventHandler(this.Timer_refreshTick);
        	// 
        	// saveFileDlg
        	// 
        	this.saveFileDlg.DereferenceLinks = false;
        	this.saveFileDlg.FileName = "log.txt";
        	this.saveFileDlg.InitialDirectory = ".";
        	this.saveFileDlg.RestoreDirectory = true;
        	// 
        	// selectFolderDlg
        	// 
        	this.selectFolderDlg.Description = "Select folder to store the file";
        	// 
        	// bt_config
        	// 
        	this.bt_config.Location = new System.Drawing.Point(12, 163);
        	this.bt_config.Name = "bt_config";
        	this.bt_config.Size = new System.Drawing.Size(107, 23);
        	this.bt_config.TabIndex = 29;
        	this.bt_config.Text = "配置";
        	this.bt_config.UseVisualStyleBackColor = true;
        	this.bt_config.Click += new System.EventHandler(this.Bt_configClick);
        	// 
        	// SSHMainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(1056, 625);
        	this.Controls.Add(this.splitContainer1);
        	this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "SSHMainForm";
        	this.Text = "SSH journal Tools";
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel1.PerformLayout();
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.Panel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        	this.splitContainer1.ResumeLayout(false);
        	this.groupBox7.ResumeLayout(false);
        	this.groupBox7.PerformLayout();
        	this.groupBox6.ResumeLayout(false);
        	this.groupBox6.PerformLayout();
        	this.groupBox5.ResumeLayout(false);
        	this.groupBox5.PerformLayout();
        	this.groupBox4.ResumeLayout(false);
        	this.groupBox4.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox3.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.splitContainer_Bottom.Panel1.ResumeLayout(false);
        	this.splitContainer_Bottom.Panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.splitContainer_Bottom)).EndInit();
        	this.splitContainer_Bottom.ResumeLayout(false);
        	this.tbc_all.ResumeLayout(false);
        	this.tabPage1.ResumeLayout(false);
        	this.tabPage1.PerformLayout();
        	this.tabPage3.ResumeLayout(false);
        	this.tabPage2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
        	this.tabPage4.ResumeLayout(false);
        	this.tabPage4.PerformLayout();
        	this.statusStrip1.ResumeLayout(false);
        	this.statusStrip1.PerformLayout();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.TabControl tbc_all;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.Button bt_savelog;
        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_End;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Start;
        private System.Windows.Forms.TextBox tb_hostIP;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer_refresh;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_runtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_filter;
        private System.Windows.Forms.Button bt_log_history_color;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_setting_color;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bt_tcpdump;
        private System.Windows.Forms.TextBox tb_tcpdump_filename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_tcpdump_op;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_tcpdump_cmd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button bt_monster;
        private System.Windows.Forms.TextBox tb_monster_filename;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_monster_op;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_monster_cmd;
        private System.Windows.Forms.FolderBrowserDialog selectFolderDlg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_common_cmd;
        private System.Windows.Forms.Button bt_start_common;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBox_common;
        private System.Windows.Forms.SplitContainer splitContainer_Bottom;
        private System.Windows.Forms.ListBox listBox_allNodes;
        private System.Windows.Forms.Button bt_config;
    }
}

