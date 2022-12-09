using TNT.ToolStripItemManager;

namespace TNT.VSRegexValidator.ItemGroups;

internal class OpenToolStripItemGroup : ToolStripItemGroup
{
	public override string Text => "Open";

	public override string ToolTipText => "Open File";

	public override void OnMouseClick(object? sender, EventArgs e)
	{
		base.OnMouseClick(sender, e);

		using (OpenFileDialog ofd = new OpenFileDialog())
		{
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader sr = new StreamReader(ofd.FileName))
				{
					if (ExternalObject is Main mainForm)
					{
						mainForm.TextBox.Lines = sr.ReadToEnd().Replace("\r", "\n").Replace("\n\n", "\n").Split('\n');// Regex.Replace(sr.ReadToEnd(), "\r", "\n").Replace('\n'.Split('\n');
					}
				}
			}
		}
	}
}
