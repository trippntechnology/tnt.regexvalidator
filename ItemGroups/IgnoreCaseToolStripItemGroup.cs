using TNT.ToolStripItemManager;

namespace TNT.VSRegexValidator.ItemGroups;

internal class IgnoreCaseToolStripItemGroup : ToolStripItemGroup
{
	public override string Text => "Ignore Case";

	public override string ToolTipText => Text;

	public override bool CheckOnClick => true;
}
