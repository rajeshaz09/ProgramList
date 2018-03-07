using System.Windows;
using System.Windows.Controls;

namespace DevExpressSoring
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            Column column = (Column)item;
            return (DataTemplate)((Control)container).FindResource(column.EditSettings + "ColumnTemplate");
        }
    }
}
