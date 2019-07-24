using DevExpress.Xpf.Core;
using ProgramList.DevX.Models;
using ProgramList.DevX.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProgramList.DevX.Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        //public IProgramListViewModel ViewModel = new ProgramListViewModel();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearGrid_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Columns.Clear();
        }

        private void InitGrid_Click(object sender, RoutedEventArgs e)
        {
            var columnCount = int.Parse(ColumnCount.Text);
            
            if (columnCount < 1) return;

            var columns = new List<IColumnInfo>(columnCount);
            for (var count = 1; count <= columnCount; count++)
                columns.Add(new DefaultColumnInfo($"Column{count}", EditorType.Default, ListColumnAlignment.Left, count, "table", "windowcontext", "field", count, true, false, true, false, count % 2 == 0, double.NaN));

            ViewModel.UpdateDescriptors(columns);
            ViewModel.Columns.AddRange(columns);

        }

        private void LoadGrid_Click(object sender, RoutedEventArgs e)
        {

        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
