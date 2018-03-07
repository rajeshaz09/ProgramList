namespace DevExpressSoring
{
    public class TwoStateCheckBoxColumn : Column
    {
        public TwoStateCheckBoxColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.TwoStateCheckBox;
        }
    }
}
