namespace DevExpressSoring
{
    public class ComboColumn : Column
    {
        public ComboColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.ComboBox;
        }

        public DevExpress.Xpf.Core.ObservableCollectionCore<string> ItemsSource { get; set; }
            = new DevExpress.Xpf.Core.ObservableCollectionCore<string>();
    }
}
