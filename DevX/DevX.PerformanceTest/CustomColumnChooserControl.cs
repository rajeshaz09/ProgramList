using DevExpress.Xpf.Grid;
using System.Windows;
using System.Windows.Controls;

namespace DevX.PerformanceTest
{
    public class CustomColumnChooserControl : Control
    {
        public static readonly DependencyProperty ViewProperty = DependencyProperty.Register("View", typeof(GridViewBase), typeof(CustomColumnChooserControl), new UIPropertyMetadata(null));
        public CustomColumnChooserControl()
        {
            DefaultStyleKey = typeof(CustomColumnChooserControl);
        }
        public GridViewBase View
        {
            get { return (GridViewBase)GetValue(ViewProperty); }
            set { SetValue(ViewProperty, value); }
        }
        internal ColumnChooserControl ColunmChooserControl { get; private set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            ColunmChooserControl = (ColumnChooserControl)GetTemplateChild("PART_ColumnChooserControl");
        }
    }
}
