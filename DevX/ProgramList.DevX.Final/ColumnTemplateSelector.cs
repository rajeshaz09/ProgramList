using ProgramList.DevX.Models;
using System.Windows;
using System.Windows.Controls;

namespace ProgramList.DevX.Final
{
    public class ColumnTemplateSelector : DataTemplateSelector
    {
        static DataTemplate comboDataTemplate;
        static DataTemplate twoStateDataTemplate;
        static DataTemplate threeStateDataTemplate;
        static DataTemplate defaultDataTemplate;
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (comboDataTemplate == null)
                comboDataTemplate = (DataTemplate)((Control)container).FindResource("ComboBoxColumnTemplate");
            if (twoStateDataTemplate == null)
                twoStateDataTemplate = (DataTemplate)((Control)container).FindResource("TwoStateCheckBoxColumnTemplate");
            if (threeStateDataTemplate == null)
                threeStateDataTemplate = (DataTemplate)((Control)container).FindResource("ThreeStateCheckBoxColumnTemplate");
            if (defaultDataTemplate == null)
                defaultDataTemplate = (DataTemplate)((Control)container).FindResource("DefaultColumnTemplate");

            var column = (DefaultColumnInfo)item;
            switch (column.EditSettings)
            {
                case EditorType.ComboBox:
                    return comboDataTemplate;
                case EditorType.Default:
                    return defaultDataTemplate;
                case EditorType.TwoStateCheckBox:
                    return twoStateDataTemplate;
                case EditorType.ThreeStateCheckBox:
                    return threeStateDataTemplate;
                default:
                    return defaultDataTemplate;
            }
        }
    }
}
