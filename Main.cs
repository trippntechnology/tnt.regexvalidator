using Microsoft.Win32;
using System.Text.RegularExpressions;
using TNT.ToolStripItemManager;
using TNT.Utilities;
using TNT.VSRegexValidator.ItemGroups;

namespace TNT.VSRegexValidator;

public partial class Main : Form
{
	ApplicationRegistry m_Registry;
	ToolStripItemGroupManager itemGroupManager;
	IgnoreCaseToolStripItemGroup? ignoreCaseToolStripItemGroup;
	MultilineToolStripItemGroup? multilineToolStripItemGroup;

	public Main()
	{
		InitializeComponent();

		m_Registry = new ApplicationRegistry(this, Registry.CurrentUser, "Tripp'n Technology", "VSRegexValidator");

		itemGroupManager = new ToolStripItemGroupManager(toolStripStatusLabel1);
		itemGroupManager.Create<OpenToolStripItemGroup>(new ToolStripItem[] { OpenMenu, OpenButton }, OpenButton.Image, this);
		ignoreCaseToolStripItemGroup = itemGroupManager.Create<IgnoreCaseToolStripItemGroup>(new ToolStripItem[] { IgnoreCaseMenu, IgnoreCaseButton }, IgnoreCaseButton.Image);
		multilineToolStripItemGroup = itemGroupManager.Create<MultilineToolStripItemGroup>(new ToolStripItem[] { MultilineMenu, MultilineButton }, MultilineButton.Image);
	}

	private void StatusBarHintChanged(string hint)
	{
		toolStripStatusLabel1.Text = hint;
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
			RegexOptions regExOptions = (multilineToolStripItemGroup?.Checked == true ? RegexOptions.Multiline : 0) |
																	(ignoreCaseToolStripItemGroup?.Checked == true ? RegexOptions.IgnoreCase : 0);
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
		TextBox.Height = m_Registry.ReadInteger("TextBoxHeight", TextBox.Height);
		Expression.Text = m_Registry.ReadString("Expression", "");
	}

	private void Main_FormClosing(object sender, FormClosingEventArgs e)
	{
		m_Registry.WriteInteger("TextBoxHeight", TextBox.Height);
	}
}