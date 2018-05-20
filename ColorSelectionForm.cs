/*
 * Created by SharpDevelop.
 * User: chenjia
 * Date: 2016/5/26
 * Time: 8:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace demossh
{
	/// <summary>
	/// Description of ColorSelectionForm.
	/// </summary>
	public partial class ColorSelectionForm : Form
	{
		public Label[] all_label;

		public STColorFontConfig config;
		
		DataTable demodata;
		public ColorSelectionForm(STColorFontConfig inconfig)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			config = inconfig;
			this.DialogResult = DialogResult.Cancel;

			demodata = new DataTable();
			demodata.Columns.Add("DateTime");
			demodata.Columns.Add("PRIORITY");
			demodata.Columns.Add("MESSAGE");
			DataRow dr = null;
			string msg = string.Empty;
			int priority = 0;
			all_label = new Label[8];
			all_label[0] = label0;
			all_label[1] = label1;
			all_label[2] = label2;
			all_label[3] = label3;
			all_label[4] = label4;
			all_label[5] = label5;
			all_label[6] = label6;
			all_label[7] = label7;
			for (int i = 0; i < 8; i++) {
				priority = i;
				msg = string.Format("This is the demo message with priority {0}", config.all_priority[priority]);
				dr = demodata.NewRow();
				dr["DateTime"] = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.ffffff");
				dr["MESSAGE"] = msg;
				dr["PRIORITY"] = priority;
				demodata.Rows.Add(dr);			
				all_label[i].Text = config.all_priority[i];
				all_label[i].ForeColor = config.all_forecolor[i];
				all_label[i].BackColor = config.all_backcolor[i];
				all_label[i].Font = config.all_font[i];
			}
		}
		void ColorSelectionFormLoad(object sender, EventArgs e)
		{	
			LoadData();
		}
		public void AppendColorText(RichTextBox rtb, string intxt, int index)
		{
			rtb.SelectionColor = config.all_forecolor[index];
			rtb.SelectionBackColor = config.all_backcolor[index];
			rtb.SelectionFont = config.all_font[index];
			rtb.AppendText(intxt + Environment.NewLine);
		}
		public void LoadData()
		{
			int max = all_label.Length;
			for(int i = 0 ; i < max; i++)
			{
				all_label[i].ForeColor = config.all_forecolor[i];
				all_label[i].BackColor = config.all_backcolor[i];
				all_label[i].Font = config.all_font[i];
			}
			dgv_demo.DataSource = null;
			dgv_demo.Refresh();
			dgv_demo.DataSource = demodata;
			dgv_demo.Refresh();
			
			rtb_demo.Clear();
			string line = string.Empty;
			int priority = 0;
			foreach (DataRow dr in demodata.Rows) {
				priority = System.Convert.ToInt32(dr["PRIORITY"].ToString());
				line = string.Format("{0} {1} {2}", dr["DateTime"].ToString(), priority, dr["MESSAGE"].ToString());
				AppendColorText(rtb_demo, line, priority);
			}
		}
		public void update_dg_color(DataGridView in_dgv)
		{
			foreach (DataGridViewRow row in in_dgv.Rows) {
				int priority = Convert.ToInt32(row.Cells["PRIORITY"].Value);
				row.DefaultCellStyle.ForeColor = config.all_forecolor[priority];
				row.DefaultCellStyle.BackColor = config.all_backcolor[priority];
				row.DefaultCellStyle.Font = config.all_font[priority];
			}
		}
		void Dgv_demoDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			update_dg_color(dgv_demo);
			dgv_demo.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_demo.Columns["DateTime"].Resizable = DataGridViewTriState.True;
			dgv_demo.Columns["MESSAGE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_demo.Columns["MESSAGE"].Resizable = DataGridViewTriState.True;
			dgv_demo.Columns["PRIORITY"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			dgv_demo.Columns["PRIORITY"].Resizable = DataGridViewTriState.True;
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
		
		public void updatelable(Label inlb, Color infc, Color inbc, Font inf)
		{
			inlb.ForeColor = infc;
			inlb.BackColor = inbc;
			inlb.Font = inf;
		}

		public void set_forecolor(int index)
		{
			colorDialog1.Color = config.all_forecolor[index];
			if (colorDialog1.ShowDialog() == DialogResult.OK) {
				config.all_forecolor[index] = colorDialog1.Color;
				updatelable(all_label[index], config.all_forecolor[index], config.all_backcolor[index], config.all_font[index]);
			}
			LoadData();
		}
		public void set_backcolor(int index)
		{
			colorDialog1.Color = config.all_backcolor[index];
			if (colorDialog1.ShowDialog() == DialogResult.OK) {
				config.all_backcolor[index] = colorDialog1.Color;
				updatelable(all_label[index], config.all_forecolor[index], config.all_backcolor[index], config.all_font[index]);
			}
			LoadData();
		}
		public void set_font(int index)
		{
			fontDialog1.Font = config.all_font[index];
			if (fontDialog1.ShowDialog() == DialogResult.OK) {
				config.all_font[index] = fontDialog1.Font;
				updatelable(all_label[index], config.all_forecolor[index], config.all_backcolor[index], config.all_font[index]);
			}
			LoadData();
		}
		void Bt_ForeColor_0Click(object sender, EventArgs e)
		{
			set_forecolor(0);
		}
		void Bt_ForeColor_1Click(object sender, EventArgs e)
		{
			set_forecolor(1);
		}
		void Bt_ForeColor_2Click(object sender, EventArgs e)
		{
			set_forecolor(2);
		}
		void Bt_ForeColor_3Click(object sender, EventArgs e)
		{
			set_forecolor(3);
		}
		void Bt_ForeColor_4Click(object sender, EventArgs e)
		{
			set_forecolor(4);
		}
		void Bt_ForeColor_5Click(object sender, EventArgs e)
		{
			set_forecolor(5);
		}
		void Bt_ForeColor_6Click(object sender, EventArgs e)
		{
			set_forecolor(6);
		}
		void Bt_ForeColor_7Click(object sender, EventArgs e)
		{
			set_forecolor(7);
		}
		void Bt_backcolor_0Click(object sender, EventArgs e)
		{
			set_backcolor(0);
		}
		void Bt_backcolor_1Click(object sender, EventArgs e)
		{
			set_backcolor(1);
		}
		void Bt_backcolor_2Click(object sender, EventArgs e)
		{
			set_backcolor(2);
		}
		void Bt_backcolor_3Click(object sender, EventArgs e)
		{
			set_backcolor(3);
		}
		void Bt_backcolor_4Click(object sender, EventArgs e)
		{
			set_backcolor(4);
		}
		void Bt_backcolor_5Click(object sender, EventArgs e)
		{
			set_backcolor(5);
		}
		void Bt_backcolor_6Click(object sender, EventArgs e)
		{
			set_backcolor(6);
		}
		void Bt_backcolor_7Click(object sender, EventArgs e)
		{
			set_backcolor(7);
		}
		void Bt_Font_0Click(object sender, EventArgs e)
		{
			set_font(0);
		}
		void Bt_Font_1Click(object sender, EventArgs e)
		{
			set_font(1);
		}
		void Bt_Font_2Click(object sender, EventArgs e)
		{
			set_font(2);
		}
		void Bt_Font_3Click(object sender, EventArgs e)
		{
			set_font(3);
		}
		void Bt_Font_4Click(object sender, EventArgs e)
		{
			set_font(4);
		}
		void Bt_Font_5Click(object sender, EventArgs e)
		{
			set_font(5);
		}
		void Bt_Font_6Click(object sender, EventArgs e)
		{
			set_font(6);
		}
		void Bt_Font_7Click(object sender, EventArgs e)
		{
			set_font(7);
		}
		void Bt_OKClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
		void Bt_CancelClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
		}
		void Bt_exportClick(object sender, EventArgs e)
		{
			saveFileDialog1.InitialDirectory = Application.ExecutablePath;
			saveFileDialog1.DereferenceLinks = false;
			saveFileDialog1.ShowHelp = true;
			saveFileDialog1.CreatePrompt = true;
			saveFileDialog1.OverwritePrompt =true;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
				string cfgfilename = saveFileDialog1.FileName;
				
				color_config_data obj = new color_config_data();
				int max = config.all_priority.Length;
				obj.all_backcolor = new SColor[max];
				obj.all_forecolor = new SColor[max];
				obj.all_font = new SFont[max];
				for(int i = 0; i<max; i++)
				{
					obj.all_backcolor[i] = new SColor(config.all_backcolor[i]);
					obj.all_forecolor[i] = new SColor(config.all_forecolor[i]);
					obj.all_font[i] = new SFont(config.all_font[i]);
				}
				obj.serialize_param(cfgfilename);
			}
		}
		
		void Bt_importClick(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Application.ExecutablePath;
			openFileDialog1.DereferenceLinks = false;
			openFileDialog1.ShowHelp = true;
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				string cfgfilename = openFileDialog1.FileName;
				color_config_data obj = color_config_data.deserialize_param(cfgfilename,typeof(color_config_data)) as color_config_data;
				int max = config.all_priority.Length;
				for(int i = 0; i<max; i++)
				{
					config.all_backcolor[i] = obj.all_backcolor[i].color;
					config.all_forecolor[i] = obj.all_forecolor[i].color;
					config.all_font[i] = obj.all_font[i].ToFont();
				}
			}
			LoadData();
		}


	}
}
