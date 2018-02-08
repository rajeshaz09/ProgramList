using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Controls;

namespace DevX.PerformanceTest
{
    public class CustomColumnChooser : IColumnChooser, IColumnChooserFactory
    {
        readonly CustomColumnChooserControl columnChooserControl;
        public CustomColumnChooser(CustomColumnChooserControl columnChooserControl)
        {
            this.columnChooserControl = columnChooserControl;
        }
        #region IColumnChooser Members
        void IColumnChooser.Show() { }
        void IColumnChooser.Hide() { }
        void IColumnChooser.ApplyState(IColumnChooserState state) { }
        void IColumnChooser.SaveState(IColumnChooserState state) { }
        void IColumnChooser.Destroy() { }
        UIElement IColumnChooser.TopContainer { get { return columnChooserControl.ColunmChooserControl; } }
        #endregion

        #region IColumnChooserFactory Members
        IColumnChooser IColumnChooserFactory.Create(Control owner) { return this; }
        #endregion
    }
}
