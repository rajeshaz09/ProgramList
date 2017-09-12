using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGrid_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Rows.Text, out int rows);
            int.TryParse(ColumnSets.Text, out int columns);
            if (rows < 0)
            {
                return;
            }
            if (columns < 0)
            {
                return;
            }
            var programListWindow = new Views.ProgramListWindow((FullScreen.IsChecked == true), rows, columns);
            programListWindow.ShowDialog();
        }
    }
}

