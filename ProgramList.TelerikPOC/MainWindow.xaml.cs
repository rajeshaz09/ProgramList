using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace ProgramList.TelerikPOC

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object _data;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //PlaceHolder.Child = new Views.ProgramWindowView();
            PlaceHolder.Child = new Views.ProgramListView(null);
        }

        private void PrepateData_Click(object sender, RoutedEventArgs e)
        {
            _data = ViewModels.ProgramListViewModelHelper.GetRunTimeTypeSampleViewModel();
        }

        private void LoadGrid_Click(object sender, RoutedEventArgs e)
        {
            //(PlaceHolder.Child as FrameworkElement).DataContext = _data;
            PlaceHolder.Child = new Views.ProgramListView(ViewModels.ProgramListViewModelHelper.GetRunTimeTypeSampleViewModel());
            ToggleChart.Visibility = Visibility.Visible;
        }

        private void ToggleChart_Click(object sender, RoutedEventArgs e)
        {
            var grid = (PlaceHolder.Child as Views.ProgramListView).ListGrid;
            var columns = grid
                .Columns
                .Cast<Telerik.Windows.Controls.GridViewBoundColumnBase>()
                .Where((column) => column.UniqueName == "Chart");
            if (columns.Any())
            {
                columns.First().IsVisible = !columns.First().IsVisible;
            }
        }
    }
}
