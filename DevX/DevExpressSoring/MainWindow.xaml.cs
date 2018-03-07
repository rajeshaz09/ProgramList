using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace DevExpressSoring
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow
    {
        ObservableCollectionCore<object> DC = new ObservableCollectionCore<object>();

        ViewModel VM = new ViewModel();
        public MainWindow()
        {
            //DataContext = DC;
            DataContext = VM;
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            for (var i = 0; i < 10; i++)
                DC.Add(
                    new
                    {
                        Id = i,
                        Name = $"Name{i}",
                        Acttive = (i % 2 == 0)
                    }
                    );
                    */


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
                VM.Columns.Add(column);
            VM.GeneratePropertyDescriptors();

            var rows = 1000;
            for (var loops = 0; loops < 2; loops++)
                for (int i = 0; i < rows; i++)
                {
                    var index = i * 10 + 1;
                    var model = new DynamicModel(VM.GridData.PropertyInfo);

                    for (var count = 1; count <= VM.Columns.Count; count++)
                    {
                        if (count == 1)
                            model.SetValue(VM.Columns[count - 1].UniqueName, new CellInfo() { Data = index });

                        else if (count == 2 || count == 3)
                            if (i % 3 == 0)
                                continue;
                            else
                                model.SetValue(VM.Columns[count - 1].UniqueName, new CellInfo() { Data = (((i - 1) % 2) == 0) });
                        else if (count == 11)
                            model.SetValue(VM.Columns[count - 1].UniqueName, new CellInfo() { Data = (i % 2 == 0) ? "A" : "B" });
                        else
                            model.SetValue(VM.Columns[count - 1].UniqueName, new CellInfo() { Data = $"string{count + index}" });

                    }
                    VM.GridData.Add(model);
                }
            

        }
    }
}
