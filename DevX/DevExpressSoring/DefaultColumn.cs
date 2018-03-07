namespace DevExpressSoring
{
    public class DefaultColumn : Column
    {
        public DefaultColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.Default;
        }
    }
}
