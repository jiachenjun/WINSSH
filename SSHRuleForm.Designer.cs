/*
 * Created by SharpDevelop.
 * User: chenjia
 * Date: 2016/5/31
 * Time: 8:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace demossh
{
	partial class SSHRuleForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListBox listBox_allrules;
		private System.Windows.Forms.Button bt_delrule;
		private System.Windows.Forms.Button bt_editrule;
		private System.Windows.Forms.Button bt_newrule;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label_show_ruleitem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_filename;
		private System.Windows.Forms.TextBox tb_rulefoption;
		private System.Windows.Forms.RadioButton rb_ruletype3;
		private System.Windows.Forms.RadioButton rb_ruletype2;
		private System.Windows.Forms.RadioButton rb_ruletype1;
		private System.Windows.Forms.TextBox tb_rulecmd;
		private System.Windows.Forms.TextBox tb_rulename;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button bt_save;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.listBox_allrules = new System.Windows.Forms.ListBox();
			this.bt_delrule = new System.Windows.Forms.Button();
			this.bt_editrule = new System.Windows.Forms.Button();
			this.bt_newrule = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_filename = new System.Windows.Forms.TextBox();
			this.tb_rulefoption = new System.Windows.Forms.TextBox();
			this.rb_ruletype3 = new System.Windows.Forms.RadioButton();
			this.rb_ruletype2 = new System.Windows.Forms.RadioButton();
			this.rb_ruletype1 = new System.Windows.Forms.RadioButton();
			this.tb_rulecmd = new System.Windows.Forms.TextBox();
			this.tb_rulename = new System.Windows.Forms.TextBox();
			this.label_show_ruleitem = new System.Windows.Forms.Label();
			this.bt_save = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listBox_allrules);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.bt_delrule);
			this.splitContainer1.Panel2.Controls.Add(this.bt_editrule);
			this.splitContainer1.Panel2.Controls.Add(this.bt_newrule);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.label_show_ruleitem);
			this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			this.splitContainer1.Size = new System.Drawing.Size(890, 364);
			this.splitContainer1.SplitterDistance = 321;
			this.splitContainer1.TabIndex = 0;
			// 
			// listBox_allrules
			// 
			this.listBox_allrules.DisplayMember = "RuleName";
			this.listBox_allrules.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox_allrules.FormattingEnabled = true;
			this.listBox_allrules.ItemHeight = 16;
			this.listBox_allrules.Location = new System.Drawing.Point(0, 0);
			this.listBox_allrules.Name = "listBox_allrules";
			this.listBox_allrules.Size = new System.Drawing.Size(321, 364);
			this.listBox_allrules.TabIndex = 0;
			this.listBox_allrules.SelectedIndexChanged += new System.EventHandler(this.ListBox_allrulesSelectedIndexChanged);
			// 
			// bt_delrule
			// 
			this.bt_delrule.Location = new System.Drawing.Point(176, 103);
			this.bt_delrule.Name = "bt_delrule";
			this.bt_delrule.Size = new System.Drawing.Size(75, 23);
			this.bt_delrule.TabIndex = 4;
			this.bt_delrule.Text = "Del";
			this.bt_delrule.UseVisualStyleBackColor = true;
			this.bt_delrule.Click += new System.EventHandler(this.Bt_delruleClick);
			// 
			// bt_editrule
			// 
			this.bt_editrule.Location = new System.Drawing.Point(95, 103);
			this.bt_editrule.Name = "bt_editrule";
			this.bt_editrule.Size = new System.Drawing.Size(75, 23);
			this.bt_editrule.TabIndex = 3;
			this.bt_editrule.Text = "Edit";
			this.bt_editrule.UseVisualStyleBackColor = true;
			this.bt_editrule.Click += new System.EventHandler(this.Bt_editruleClick);
			// 
			// bt_newrule
			// 
			this.bt_newrule.Location = new System.Drawing.Point(14, 103);
			this.bt_newrule.Name = "bt_newrule";
			this.bt_newrule.Size = new System.Drawing.Size(75, 23);
			this.bt_newrule.TabIndex = 2;
			this.bt_newrule.Text = "New";
			this.bt_newrule.UseVisualStyleBackColor = true;
			this.bt_newrule.Click += new System.EventHandler(this.Bt_newruleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bt_save);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tb_filename);
			this.groupBox1.Controls.Add(this.tb_rulefoption);
			this.groupBox1.Controls.Add(this.rb_ruletype3);
			this.groupBox1.Controls.Add(this.rb_ruletype2);
			this.groupBox1.Controls.Add(this.rb_ruletype1);
			this.groupBox1.Controls.Add(this.tb_rulecmd);
			this.groupBox1.Controls.Add(this.tb_rulename);
			this.groupBox1.Location = new System.Drawing.Point(14, 132);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(539, 210);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Edit property:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "File Name:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(7, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "File Option:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Rule type:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Rule command line:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Rule Name:";
			// 
			// tb_filename
			// 
			this.tb_filename.Location = new System.Drawing.Point(127, 138);
			this.tb_filename.Name = "tb_filename";
			this.tb_filename.Size = new System.Drawing.Size(396, 22);
			this.tb_filename.TabIndex = 6;
			// 
			// tb_rulefoption
			// 
			this.tb_rulefoption.Location = new System.Drawing.Point(127, 107);
			this.tb_rulefoption.Name = "tb_rulefoption";
			this.tb_rulefoption.Size = new System.Drawing.Size(86, 22);
			this.tb_rulefoption.TabIndex = 5;
			// 
			// rb_ruletype3
			// 
			this.rb_ruletype3.Location = new System.Drawing.Point(359, 80);
			this.rb_ruletype3.Name = "rb_ruletype3";
			this.rb_ruletype3.Size = new System.Drawing.Size(137, 24);
			this.rb_ruletype3.TabIndex = 4;
			this.rb_ruletype3.Text = "backgrand file fetch";
			this.rb_ruletype3.UseVisualStyleBackColor = true;
			// 
			// rb_ruletype2
			// 
			this.rb_ruletype2.Location = new System.Drawing.Point(235, 79);
			this.rb_ruletype2.Name = "rb_ruletype2";
			this.rb_ruletype2.Size = new System.Drawing.Size(118, 24);
			this.rb_ruletype2.TabIndex = 3;
			this.rb_ruletype2.Text = "continue output";
			this.rb_ruletype2.UseVisualStyleBackColor = true;
			// 
			// rb_ruletype1
			// 
			this.rb_ruletype1.Checked = true;
			this.rb_ruletype1.Location = new System.Drawing.Point(127, 79);
			this.rb_ruletype1.Name = "rb_ruletype1";
			this.rb_ruletype1.Size = new System.Drawing.Size(104, 24);
			this.rb_ruletype1.TabIndex = 2;
			this.rb_ruletype1.TabStop = true;
			this.rb_ruletype1.Text = "simple output";
			this.rb_ruletype1.UseVisualStyleBackColor = true;
			this.rb_ruletype1.CheckedChanged += new System.EventHandler(this.Rb_ruletype1CheckedChanged);
			// 
			// tb_rulecmd
			// 
			this.tb_rulecmd.Location = new System.Drawing.Point(127, 51);
			this.tb_rulecmd.Name = "tb_rulecmd";
			this.tb_rulecmd.Size = new System.Drawing.Size(396, 22);
			this.tb_rulecmd.TabIndex = 1;
			// 
			// tb_rulename
			// 
			this.tb_rulename.Location = new System.Drawing.Point(127, 22);
			this.tb_rulename.Name = "tb_rulename";
			this.tb_rulename.Size = new System.Drawing.Size(396, 22);
			this.tb_rulename.TabIndex = 0;
			// 
			// label_show_ruleitem
			// 
			this.label_show_ruleitem.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_show_ruleitem.Location = new System.Drawing.Point(14, 9);
			this.label_show_ruleitem.Name = "label_show_ruleitem";
			this.label_show_ruleitem.Size = new System.Drawing.Size(523, 91);
			this.label_show_ruleitem.TabIndex = 0;
			this.label_show_ruleitem.Text = "No item selected";
			// 
			// bt_save
			// 
			this.bt_save.Location = new System.Drawing.Point(7, 167);
			this.bt_save.Name = "bt_save";
			this.bt_save.Size = new System.Drawing.Size(75, 23);
			this.bt_save.TabIndex = 12;
			this.bt_save.Text = "Save";
			this.bt_save.UseVisualStyleBackColor = true;
			this.bt_save.Click += new System.EventHandler(this.Bt_saveClick);
			// 
			// SSHRuleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 364);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "SSHRuleForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SSHRule Configuration";
			this.Load += new System.EventHandler(this.SSHRuleFormLoad);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
