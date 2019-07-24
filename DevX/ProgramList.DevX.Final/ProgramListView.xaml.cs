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

namespace ProgramList.DevX.Final
{
    /// <summary>
    /// Interaction logic for ProgramListView.xaml
    /// </summary>
    public partial class ProgramListView : UserControl
    {
        public ProgramListView()
        {
            InitializeComponent();
        }

        private void ListGrid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //e.Handled = true;
        }

        private void ListGrid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            //e.Handled = true;
        }

        private void ContextMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            e.Handled = true;
        }
    }
}
