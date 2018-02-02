using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace DevX.PerformanceTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {

        public static string[] _properties = new string[]
        {
            "Id",
            "Active",
            "Prop01",
            "Prop02",
            "Prop03",
            "Prop04",
            "Prop05",
            "Prop06",
            "Prop07",
            "Prop08",
        };
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new Item();
            var descriptors = new PropertyDescriptor[10];
            for (var count = 0; count < descriptors.Length; count++)
                descriptors[count] = new CellInfoDescriptor(_properties[count]);
            var descriptorCollection = new PropertyDescriptorCollection(descriptors);

            var viewModel = new ViewModel(descriptorCollection);

            for (int i = 0; i < 10000; i++)
            {
                var index = i * 10 + 1;
                var model = new DynamicModel(descriptorCollection);

                for (var count = 1; count <= _properties.Length; count++)
                {
                    if (count == 1)
                        model.SetValue(_properties[count - 1], new CellInfo() { Data = index });

                    else if (count == 2)
                        model.SetValue(_properties[count - 1], new CellInfo() { Data = ((i % 2) == 0) });
                    else
                        model.SetValue(_properties[count - 1], new CellInfo() { Data = $"string{count + index}" });

                }
                viewModel.GridData.Add(model);
            }

            DataContext = viewModel;
        }
    }
}
