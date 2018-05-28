using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;

namespace DevX.PerformanceTest
{

    public class ColumnTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Column column = (Column)item;
            return (DataTemplate)((Control)container).FindResource(column.EditSettings + "ColumnTemplate");
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {

        public static string[] _propertiees = new string[]
        {
            "Id",
            "Active1",
            "Active2",
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
            GridControl.AllowInfiniteGridSize = true;
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = new ViewModel();

            var columns = new Column[]
            {
                new DefaultColumn               ("Id"      ),
                new TwoStateCheckBoxColumn      ("Active1" ),
                new ThreeStateCheckBoxColumn    ("Active2" ),
                new DefaultColumn               ("Prop01"  ),
                new DefaultColumn               ("Prop02"  ),
                new DefaultColumn               ("Prop03"  ),
                new DefaultColumn               ("Prop04"  ),
                new DefaultColumn               ("Prop05"  ),
                new DefaultColumn               ("Prop06"  ),
                new DefaultColumn               ("Prop07"  ),
                new ComboColumn                 ("Prop08"  ),
            };
            (columns.Last() as ComboColumn).ItemsSource.Add("A");
            (columns.Last() as ComboColumn).ItemsSource.Add("B");
            (columns.Last() as ComboColumn).ItemsSource.Add("C");
            (columns.Last() as ComboColumn).ItemsSource.Add("D");

            foreach (var column in columns)
                viewModel.Columns.Add(column);
            viewModel.GeneratePropertyDescriptors();

            var rows = 1000;
            for (var loops = 0; loops < 2; loops++)
                for (int i = 0; i < rows; i++)
                {
                    var index = i * 10 + 1;
                    var model = new DynamicModel(viewModel.GridData.PropertyInfo);

                    for (var count = 1; count <= viewModel.Columns.Count; count++)
                    {
                        if (count == 1)
                            model.SetValue(viewModel.Columns[count - 1].UniqueName, new CellInfo() { Data = index });

                        else if (count == 2 || count == 3)
                            if (i % 3 == 0)
                                continue;
                            else
                                model.SetValue(viewModel.Columns[count - 1].UniqueName, new CellInfo() { Data = (((i - 1) % 2) == 0) });
                        else if (count == 11)
                            model.SetValue(viewModel.Columns[count - 1].UniqueName, new CellInfo() { Data = (i % 2 == 0) ? "A" : "B" });
                        else
                            model.SetValue(viewModel.Columns[count - 1].UniqueName, new CellInfo() { Data = $"string{count + index}" });

                    }
                    viewModel.GridData.Add(model);
                }

            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = true;
            return;
            var viewModel = DataContext as ViewModel;
            viewModel.ShowCloumnChooser = !viewModel.ShowCloumnChooser;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //ListGrid.SaveLayoutToStream()
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyPopup_Opened(object sender, System.EventArgs e)
        {
        }
    }

    public class TableViewEx: TableView
    {
    }
}
