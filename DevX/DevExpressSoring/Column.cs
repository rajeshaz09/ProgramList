using DevExpress.Utils;

namespace DevExpressSoring
{
    public abstract class Column : ModelBase
    {
        public Column(string uniqueName)
        {
            UniqueName = uniqueName;
            FieldName = $"{uniqueName}.Data";
            Header = uniqueName;
            Width = 100;
            AllowSorting = DefaultBoolean.True;
        }
        private string _fieldName;
        private SettingsType _settings;
        private string _uniqueName;
        private string _header;
        private double _width;
        private DefaultBoolean _allowSorting;

        public string FieldName { get => _fieldName; set { SetProperty(ref _fieldName, value); } }
        public SettingsType EditSettings { get => _settings; set { SetProperty(ref _settings, value); } }
        public string UniqueName { get => _uniqueName; set { SetProperty(ref _uniqueName, value); } }
        public string Header { get => _header; set { SetProperty(ref _header, value); } }
        public double Width { get => _width; set { SetProperty(ref _width, value); } }

        public DefaultBoolean AllowSorting { get => _allowSorting; set => SetProperty(ref _allowSorting, value); }
    }
}
