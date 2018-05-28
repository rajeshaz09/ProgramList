using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System.ComponentModel;
using System.Windows.Input;

namespace DevX.PerformanceTest
{
    public class ViewModel : ModelBase
    {
        public ViewModel()
        {
            IntellisenceCommand = new DelegateCommand(() =>
            {
                FocusedElement = Keyboard.FocusedElement;
                IsOpen = true;
            });

            TopRowIndexCommand = new DelegateCommand(() =>
            {

            });
        }
        public object FocusedElement { get => _focusedElement; set => SetProperty(ref _focusedElement, value); }
        public ICommand IntellisenceCommand { get; set; }
        public ICommand TopRowIndexCommand { get; set; }
        private MyCollection<DynamicModel> _gridData;
        public MyCollection<DynamicModel> GridData
        {
            get { return _gridData; }
            set { SetProperty(ref _gridData, value); }
        }
        public ObservableCollectionCore<Column> Columns { get; set; }
            = new ObservableCollectionCore<Column>();


        private bool _isOpen;
        private bool _showCloumnChooser;
        private object _focusedElement;

        public bool ShowCloumnChooser
        {
            get { return _showCloumnChooser; }
            set { SetProperty(ref _showCloumnChooser, value); }
        }

        public bool IsOpen { get => _isOpen; set => SetProperty(ref _isOpen, value); }
        public int TopRowIndex { get => _topRowIndex;
            set => SetProperty(ref _topRowIndex, value); }

        private int _topRowIndex;

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
