using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
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
        public ObservableCollectionCore<Column> Columns { get; set; }
            = new ObservableCollectionCore<Column>();


        private bool _showCloumnChooser;
        public bool ShowCloumnChooser
        {
            get { return _showCloumnChooser; }
            set { SetProperty(ref _showCloumnChooser, value); }
        }

        public void GeneratePropertyDescriptors()
        {
            var descriptors = new PropertyDescriptor[Columns.Count];
            for (var count = 0; count < descriptors.Length; count++)
                descriptors[count] = new CellInfoDescriptor(Columns[count].UniqueName);

            var descriptorCollection = new PropertyDescriptorCollection(descriptors);

            GridData = new MyCollection<DynamicModel>(descriptorCollection);
        }
    }
}
