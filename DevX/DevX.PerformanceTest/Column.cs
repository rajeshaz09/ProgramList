namespace DevX.PerformanceTest
{
    public enum SettingsType
    {
        Default,
        TwoStateCheckBox,
        ThreeStateCheckBox,
        ComboBox
    }

    public abstract class Column : ModelBase
    {
        public Column(string uniqueName)
        {
            UniqueName = uniqueName;
            FieldName = $"{uniqueName}.Data";
            Header = uniqueName;
            Width = 20;
        }
        private string _fieldName;
        private SettingsType _settings;
        private string _uniqueName;
        private string _header;
        private double _width;

        public string FieldName { get => _fieldName; set { SetProperty(ref _fieldName, value); } }
        public SettingsType EditSettings { get => _settings; set { SetProperty(ref _settings, value); } }
        public string UniqueName { get => _uniqueName; set { SetProperty(ref _uniqueName, value); } }
        public string Header { get => _header; set { SetProperty(ref _header, value); } }
        public double Width { get => _width; set { SetProperty(ref _width, value); } }
    }

    public class DefaultColumn : Column
    {
        public DefaultColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.Default;
        }
    }

    public class TwoStateCheckBoxColumn : Column
    {
        public TwoStateCheckBoxColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.TwoStateCheckBox;
        }
    }
    public class ThreeStateCheckBoxColumn : Column
    {
        public ThreeStateCheckBoxColumn(string uniqueName) : base(uniqueName)
        {
            EditSettings = SettingsType.ThreeStateCheckBox;
        }
    }
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
