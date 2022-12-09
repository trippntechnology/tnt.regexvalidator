using TNT.ToolStripItemManager;

namespace TNT.VSRegexValidator.ItemGroups;

internal class MultilineToolStripItemGroup : ToolStripItemGroup
{
	public override string Text => "Multiline";

	public override string ToolTipText => Text;

	public override bool CheckOnClick => true;
}
