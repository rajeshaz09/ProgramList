using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ScrollIntoViewAsyncMvvm;
using Telerik.Windows.Data;
using System.Collections;
using System.ComponentModel;
using System.Collections.Specialized;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var rounds = 20;
            this.DataContext = new MyViewModel();
            clubsGrid.Columns.Add(AddDropDownColumn("DropDown"));
            for (var count = 0; count < rounds; count++)
            {
                var index = count.ToString();
                if (count < 10)
                    index = "0" + index;
                clubsGrid.Columns.Add(AddColumn($"Name{index}"));
                clubsGrid.Columns.Add(AddDateTimeColumn($"Established{index}"));
            }

            for (var count = 0; count < 1; count++)
            {
                var index = count.ToString();
                if (count < 10)
                    index = "0" + index;
                clubsGrid.Columns.Add(AddColumn($"StadiumCapacity{index}"));
            }
        }

        private GridViewDataColumn AddDateTimeColumn(string name)
        {
            var column = new DateTimeColumnInfo(name)
            {
                UniqueName = name,
                Header = name
            };

            return column;
        }

        private GridViewDataColumn AddColumn(string name)
        {
            var column = new GridViewDataColumn()
            {
                UniqueName = name,
                Header = name
            };

            return column;
        }

        private GridViewColumn AddDropDownColumn(string name)
        {
            var dropDownDataSource = new DropDownItemCollection()
            {
                new DropDownItem("0", "Zero"),
                new DropDownItem("1", "One"),
                new DropDownItem("2", "Two"),
                new DropDownItem("3", "Three"),
            };

            return new DropDownColumnInfo(dropDownDataSource)
            {
                UniqueName = name,
                Header = name
            };
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            clubsGrid.LayoutUpdated += ClubsGrid_LayoutUpdated;
            TimerStart();
            (this.DataContext as MyViewModel).UpdateClubs();
        }

        private void ClubsGrid_LayoutUpdated(object sender, EventArgs e)
        {
            clubsGrid.LayoutUpdated -= ClubsGrid_LayoutUpdated;
            TimerStop();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            (this.DataContext as MyViewModel).Clubs.Clear();
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
    }
}
