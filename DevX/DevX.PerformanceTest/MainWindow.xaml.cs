using System;
using System.Collections.Generic;
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
        ObservableCollectionCore<object> GridData = new ObservableCollectionCore<object>();
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10000; i++)
            {
                var index = i * 10 + 1;
                GridData.Add(
                    new DynamicModel(
                    new Item()
                {
                    Id = index,
                    Active = (i % 2) == 0,
                    Prop01 = $"string{1 + index}",
                    Prop02 = $"string{2 + index}",
                    Prop03 = $"string{3 + index}",
                    Prop04 = $"string{4 + index}",
                    Prop05 = $"string{5 + index}",
                    Prop06 = $"string{6 + index}",
                    Prop07 = $"string{7 + index}",
                    Prop08 = $"string{8 + index}",
                }
                    )
                    );
            }
            ListGrid.DataContext = GridData;
        }
    }
}
