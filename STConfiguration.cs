/*
 * Created by SharpDevelop.
 * User: chenjia
 * Date: 2016/5/27
 * Time: 1:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace demossh
{
	/// <summary>
	/// Description of STConfiguration.
	/// </summary>
	public class STConfiguration
	{
		public STConfiguration()
		{
		}
	}
	
	public class STColorFontConfig
	{
		public string[] all_priority;
		
		public Color[] all_forecolor;
		public Color[] all_backcolor;
		public Font[] all_font;
		
		public STColorFontConfig(Color inbackcolor, Font infont)
		{
			all_priority = new string[] {
				"emerg",
				"alert",
				"crit",
				"err",
				"warning",
				"notice",
				"info",
				"debug"
			};
			all_forecolor = new Color[] {
				Color.Red,
				Color.Red,
				Color.DarkRed,
				Color.DarkRed,
				Color.Blue,
				Color.Black,
				Color.Black,
				Color.Gray
			};
			Color defcolor = inbackcolor;
			all_backcolor = new Color[] {
				defcolor,
				defcolor,
				defcolor,
				defcolor,
				defcolor,
				defcolor,
				defcolor,
				defcolor
			};
			Font oldfont = infont;
			all_font = new Font[] {
				oldfont,
				oldfont,
				oldfont,
				oldfont,
				oldfont,
				oldfont,
				oldfont,
				oldfont
			};
		}
		
		public STColorFontConfig clone()
		{
			STColorFontConfig obj = new STColorFontConfig(all_backcolor[0], all_font[0]);
			obj.all_forecolor = this.all_forecolor.Clone() as Color[];
			obj.all_backcolor = this.all_backcolor.Clone() as Color[];
			obj.all_font = this.all_font.Clone() as Font[];
			return obj;
		}
	}
	[Serializable]
	public class SColor
	{
		public SColor()
		{
			_color = Color.FromArgb(0, 0, 0);
		}
		public SColor(Color in_color)
		{
			_color = in_color;
		}
		Color _color;
		[XmlIgnore]
		public Color color {
			get { return _color; }
			set { _color = value; }
		}
		[XmlElement("color")]
		public string ClrGridHtml {
			get { return ColorTranslator.ToHtml(_color); }
			set { color = ColorTranslator.FromHtml(value); }
		}

	}

	[Serializable]
	public class SFont
	{
		public string FontFamily { get; set; }
		public GraphicsUnit GraphicsUnit { get; set; }
		public float Size { get; set; }
		public FontStyle Style { get; set; }

		/// <summary>
		/// Intended for xml serialization purposes only
		/// </summary>
		private SFont()
		{
		}

		public SFont(Font f)
		{
			FontFamily = f.FontFamily.Name;
			GraphicsUnit = f.Unit;
			Size = f.Size;
			Style = f.Style;
		}

		public static SFont FromFont(Font f)
		{
			return new SFont(f);
		}

		public Font ToFont()
		{
			return new Font(FontFamily, Size, Style,
				GraphicsUnit);
		}
	}
	[Serializable]
	public class color_config_data
	{
		public string[] all_priority;
		public SColor[] all_forecolor;
		public SColor[] all_backcolor;
		public SFont[] all_font;

		public void reset_value()
		{
		}
			
		public void serialize_param(string in_configfilename, FileMode in_filemode = FileMode.Create)
		{
			var l_s = new XmlSerializer(GetType());
			Stream l_stream = new FileStream(in_configfilename, in_filemode, FileAccess.Write, FileShare.Read);
			l_s.Serialize(l_stream, this);
			l_stream.Close();
		}
			
		public static color_config_data deserialize_param(string in_configfilename, Type in_type)
		{
			var l_s = new XmlSerializer(in_type);
			color_config_data l_object;
			try {
				Stream l_stream = new FileStream(in_configfilename, FileMode.Open, FileAccess.Read, FileShare.Read);
				l_object = l_s.Deserialize(l_stream) as color_config_data;
				l_stream.Close();
			} catch (Exception exc) {
				exc.ToString();
				l_object = null;
			}
			return l_object;
		}
			
		public static color_config_data deserialize_param(string in_configfilename)
		{
			return deserialize_param(in_configfilename, typeof(color_config_data)) as color_config_data;
		}
	}
}
