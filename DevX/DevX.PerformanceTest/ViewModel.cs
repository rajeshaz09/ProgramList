using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using System.Windows.Input;

namespace DevX.PerformanceTest
{
    public class ViewModel : ModelBase
    {
        public ObservableCollectionCore<object> GridData { get; set; } = new ObservableCollectionCore<object>();

        public ICommand SearchCommand { get; set; }
        private string _searchString;
        public string SearchString
        {
            get { return _searchString; }
            set { SetProperty(ref _searchString, value); }
        }

        public ViewModel()
        {
            SearchCommand = new DelegateCommand<string>((text) =>
            {
                SearchString = text;
            });
        }
    }
}
