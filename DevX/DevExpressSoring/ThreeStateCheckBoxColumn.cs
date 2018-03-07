namespace DevExpressSoring
{
    public class ThreeStateCheckBoxColumn : Column
    {
        public ThreeStateCheckBoxColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.ThreeStateCheckBox;
        }
    }
}
