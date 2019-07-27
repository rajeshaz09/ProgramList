using DevExpress.Xpf.Core;
using ProgramList.DevX.Models;
using ProgramList.DevX.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        const string xaml = "<final:ProgramListView " +
            "xmlns=\"http://schemas.microsoft.com/winfx/2006/xaml/presentation\" " +
            "xmlns:x=\"http://schemas.microsoft.com/winfx/2006/xaml\" " +
            "xmlns:final=\"clr-namespace:ProgramList.DevX.Final;assembly=ProgramList.DevX.Final\" " +
            //"x:Name=\"MyProgramList\" " +
            "DataContext=\"{Binding}\" " +
            "/>";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearGrid_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Columns.Clear();
            InitGrid.IsEnabled = true;
        }

        private void NewGrid_Click(object sender, RoutedEventArgs e)
        {
            var oMemStream = new MemoryStream(Encoding.UTF8.GetBytes(xaml));
            PlaceHolder.Child = XamlReader.Load(oMemStream) as UIElement;
            NewGrid.IsEnabled = false;
            InitGrid.IsEnabled = true;
            Bestfit.IsEnabled = true;
            ClearGrid.IsEnabled = true;
        }

        private void InitGrid_Click(object sender, RoutedEventArgs e)
        {
            var columnCount = int.Parse(ColumnCount.Text);

            if (columnCount < 1) return;

            var columns = new List<IColumnInfo>(columnCount);
            for (var count = 1; count <= columnCount; count++)
                columns.Add(new DefaultColumnInfo(
                    $"Column{count}",
                    EditorType.Default,
                    ListColumnAlignment.Left,
                    count, "" +
                    "table", "windowcontext", "field", count, true, false, true, false,
                    count % 2 == 0,
                    0));

            ViewModel.UpdateDescriptors(columns);
            ViewModel.Columns.BeginUpdate();
            ViewModel.Columns.AddRange(columns);
            //foreach (var col in columns)
            //    ViewModel.Columns.Add(col);
            ViewModel.Columns.EndUpdate();

            InitGrid.IsEnabled = false;
        }

        private void Bestfit_Click(object sender, RoutedEventArgs e)
        {
            if (PlaceHolder.Child == null)
                return;
            var grid = PlaceHolder.Child as ProgramListView;
            grid.ListTableView.BestFitColumns();
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
