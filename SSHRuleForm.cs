/*
 * Created by SharpDevelop.
 * User: chenjia
 * Date: 2016/5/31
 * Time: 8:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace demossh
{
	/// <summary>
	/// Description of SSHRuleForm.
	/// </summary>
	public partial class SSHRuleForm : Form
	{
		public SSHRuleForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			allRules = new List<STRule>();
			editRule = null;
			dummy();
			listBox_allrules.DataSource = allRules;
			groupBox1.Enabled = false;
		}
		public void dummy()
		{
			STRule obj = null;
			obj = new STRule();
			obj.rCmdLine = "ls -lah";
			obj.rType = STRuleType.Block;
			obj.rFileOption = string.Empty;
			obj.rName= "show ls result";
			allRules.Add(obj);
			obj = new STRule();
			obj.rCmdLine = "ps -ef";
			obj.rType = STRuleType.Block;
			obj.rFileOption = string.Empty;
			obj.rName= "show ps result";
			allRules.Add(obj);
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		void SSHRuleFormLoad(object sender, EventArgs e)
		{
			update_ruleitem_show();
		}
		
		public List<STRule> allRules;
		public STRule editRule;
		public void update_ruleitem_show()
		{
			if(listBox_allrules.SelectedIndex >= 0)
			{
				STRule selectedruleitem = listBox_allrules.SelectedItem as STRule;
				this.label_show_ruleitem.Text = string.Format("{0}\n\tRuleName:{1}\n\tRuleCmd:{2} {3} {4}\n\tRuleType:{5}",
				                               listBox_allrules.SelectedIndex.ToString(),
				                               selectedruleitem.RuleName,
				                               selectedruleitem.RuleCmdLine,
				                               selectedruleitem.RuleFileOption,
				                               selectedruleitem.RuleFileName,
				                               selectedruleitem.RuleType.ToString());
			}
			else
			{
				this.label_show_ruleitem.Text = "No rule item selected";
			}
		}
		
		void ListBox_allrulesSelectedIndexChanged(object sender, EventArgs e)
		{
			update_ruleitem_show();
		}
		
		void Rb_ruletype1CheckedChanged(object sender, EventArgs e)
		{
	
		}
		public void ctrl_2_param(STRule inrule)
		{
			inrule.RuleName     =  this.tb_rulename.Text;
			inrule.RuleCmdLine  =  this.tb_rulecmd.Text ;
			inrule.RuleFileName =  this.tb_filename.Text;
		}
		public void param_2_ctrl(STRule inrule)
		{
			this.tb_rulename.Text = inrule.RuleName;
			this.tb_rulecmd.Text = inrule.RuleCmdLine;
			this.tb_filename.Text = inrule.RuleFileName;
		}
		void Bt_newruleClick(object sender, EventArgs e)
		{
	
		}
		void Bt_editruleClick(object sender, EventArgs e)
		{
			if(listBox_allrules.SelectedIndex >= 0)
			{
				editRule = listBox_allrules.SelectedItem as STRule;
				param_2_ctrl(editRule);
			}
	
		}
		void Bt_delruleClick(object sender, EventArgs e)
		{
			if(listBox_allrules.SelectedIndex >= 0)
			{
				editRule = listBox_allrules.SelectedItem as STRule;
				allRules.Remove(editRule);
			}
		}
		void Bt_saveClick(object sender, EventArgs e)
		{
			if(editRule != null)
			{
				if(this.allRules.Contains(editRule) == false)
					this.allRules.Add(editRule);
			}
			editRule = null;
			this.groupBox1.Enabled = false;
		}
	}
}
