using DevExpress.Mvvm;
using System.ComponentModel;
using System.Windows.Input;

namespace DevX.PerformanceTest
{
    public class ViewModel : ModelBase
    {
        private MyCollection<DynamicModel> _gridData;
        public MyCollection<DynamicModel> GridData
        {
            get { return _gridData; }
            set { SetProperty(ref _gridData, value); }
        }

        private bool _showCloumnChooser;
        public bool ShowCloumnChooser
        {
            get { return _showCloumnChooser; }
            set { SetProperty(ref _showCloumnChooser, value); }
        }

        public ViewModel(PropertyDescriptorCollection propertyInfo)
        {
            GridData = new MyCollection<DynamicModel>(propertyInfo);
        }
    }
}
