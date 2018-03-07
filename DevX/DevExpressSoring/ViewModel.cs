using DevExpress.Xpf.Core;
using System.ComponentModel;

namespace DevExpressSoring
{
    public class ViewModel : ModelBase
    {
        public ViewModel()
        {
        }

        private MyCollection<DynamicModel> _gridData;
        public MyCollection<DynamicModel> GridData
        {
            get { return _gridData; }
            set { SetProperty(ref _gridData, value); }
        }
        public ObservableCollectionCore<Column> Columns { get; set; }
            = new ObservableCollectionCore<Column>();
        

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
