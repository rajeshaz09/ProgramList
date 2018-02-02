using DevExpress.Mvvm;
using System.ComponentModel;
using System.Windows.Input;

namespace DevX.PerformanceTest
{
    public class ViewModel : ModelBase
    {
        public MyCollection<DynamicModel> GridData { get; set; } 
        public ViewModel(PropertyDescriptorCollection propertyInfo)
        {
            GridData = new MyCollection<DynamicModel>(propertyInfo);
        }
        
        
    }
}
