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
using System.Diagnostics;
using DevExpress.Xpf.Grid;

namespace ProgramList.DevX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        Stopwatch timer = new Stopwatch();

        private void TimerStart()
        {
            timer.Reset();
            timer.Start();
        }

        private void TimerStop()
        {
            timer.Stop();
            LoadTime.Text = $"{timer.ElapsedMilliseconds} ms";
        }
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = ViewModels.ProgramListViewModelHelper.GetRunTimeTypeSampleViewModel();
            //ProgramList.ListGrid.Columns.AddRange(viewModel.Columns.Cast<Telerik.Windows.Controls.GridViewColumn>());
            //foreach (var column in viewModel.Columns)
            //    ProgramList.ListGrid.Columns.Add(column as GridColumn);
            ProgramList.DataContext = viewModel;

        }

        private void ListGrid_LayoutUpdated(object sender, EventArgs e)
        {
            ProgramList.ListGrid.LayoutUpdated -= ListGrid_LayoutUpdated;
            TimerStop();
        }

        private void LoadGrid_Click(object sender, RoutedEventArgs e)
        {
            ProgramList.ListGrid.LayoutUpdated += ListGrid_LayoutUpdated;
            TimerStart();

            var viewModel = ProgramList.DataContext
                as ViewModels.ProgramListViewModel;
            //Task.Run(() =>
            {

                ViewModels.ProgramListViewModelHelper.AssignData(viewModel);

            }
            //).ConfigureAwait(false);
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = ProgramList.DataContext
                as ViewModels.ProgramListViewModel;
            viewModel.GridData.Clear();
        }

        private void ClearAndLoadGrid_Click(object sender, RoutedEventArgs e)
        {
            ProgramList.ListGrid.LayoutUpdated += ListGrid_LayoutUpdated;
            TimerStart();
            var viewModel = ProgramList.DataContext
                   as ViewModels.ProgramListViewModel;
            ViewModels.ProgramListViewModelHelper.ClearAndAssignData(viewModel);

        }
    }
}
