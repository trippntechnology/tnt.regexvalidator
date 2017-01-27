using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using TNT.Utilities;
using TNT.Utilities.CommandManagement;

namespace TNT.VSRegexValidator
{
	public partial class Main : Form
	{
		ApplicationRegistry m_Registry = new ApplicationRegistry(Registry.CurrentUser, "Tripp'n Technology", "VSRegexValidator");
		CommandManager m_CommandManager = null;

		public Main()
		{
			InitializeComponent();

			m_CommandManager = new CommandManager(StatusBarHintChanged);

			Command cmd = m_CommandManager.Create("IgnoreCase", null, null);
			cmd.Add(IgnoreCaseMenu);
			cmd.Add(IgnoreCaseButton);

			cmd = m_CommandManager.Create("Open", Open, null);
			cmd.Add(OpenMenu);
			cmd.Add(OpenButton);

			cmd = m_CommandManager.Create("Multiline", null, null);
			cmd.Add(MultilineMenu);
			cmd.Add(MultilineButton);
		}

		private void StatusBarHintChanged(string hint)
		{
			toolStripStatusLabel1.Text = hint;
		}

		private void Open(Command cmd)
		{
			if (OpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader sr = new StreamReader(OpenFileDialog.FileName))
				{
					TextBox.Lines = sr.ReadToEnd().Replace("\r", "\n").Replace("\n\n", "\n").Split('\n');// Regex.Replace(sr.ReadToEnd(), "\r", "\n").Replace('\n'.Split('\n');
				}
			}
		}

		private void Expression_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				m_Registry.WriteString("Expression", Expression.Text);
				Result.Lines = GetValueUsingRegEx(TextBox.Text, Expression.Text).ToArray();
			}
		}

		private List<string> GetValueUsingRegEx(String msg, String regExp)
		{
			List<string> rtnValue = new List<string>();

			rtnValue.Add(string.Format("Exp: {0}", regExp));

			try
			{
				RegexOptions regExOptions = (m_CommandManager["Multiline"].Checked ? RegexOptions.Multiline : 0) |
																		(m_CommandManager["IgnoreCase"].Checked ? RegexOptions.IgnoreCase : 0);
				MatchCollection matches = Regex.Matches(msg, regExp, regExOptions);
				MatchCollection tags = Regex.Matches(regExp, @"\?<(?<tag>[^>]*)>", RegexOptions.Multiline);
				List<string> tagList = new List<string>();

				foreach (Match match in tags)
				{
					if (match.Success)
					{
						tagList.Add(match.Groups["tag"].ToString());
					}
				}

				foreach (Match match in matches)
				{
					if (match.Success)
					{
						foreach (string tag in tagList)
						{
							rtnValue.Add(string.Format("{0}: {1}", tag, match.Groups[tag].ToString()));
						}
					}
				}

				if (matches.Count > 0)
				{
					foreach (Match match in matches)
					{
						if (match.Success)
						{
							for (int groupIndex = 0; groupIndex < match.Groups.Count; groupIndex++)
							{
								rtnValue.Add(string.Format("{0}: {1}", groupIndex, match.Groups[groupIndex].ToString()));
							}
						}
					}
				}
				else
				{
					rtnValue.Add("No match found!");
				}
			}
			catch (Exception e)
			{
				rtnValue.Add(e.Message);
			}

			return rtnValue;
		}

		private void Main_FormLoad(object sender, EventArgs e)
		{
			m_Registry.LoadFormState(this);

			TextBox.Height = m_Registry.ReadInteger("TextBoxHeight", TextBox.Height);
			Expression.Text = m_Registry.ReadString("Expression", "");
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			m_Registry.WriteInteger("TextBoxHeight", TextBox.Height);
			m_Registry.SaveFormState(this);
		}

		private void IgnoreCaseButton_MouseEnter(object sender, EventArgs e)
		{

		}

		private void IgnoreCaseButton_MouseLeave(object sender, EventArgs e)
		{

		}
	}
}
