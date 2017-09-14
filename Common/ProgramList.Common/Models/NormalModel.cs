using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Jeeves.CustomModels
{
    public class MyType : ListItemBase, INotifyPropertyChanged
    {
        public string StringProperty
        {
            get
            {
                return base.GetValue<string>("StringProperty");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty");
            }
        }

        public string Foreground_StringProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty");
            }
        }

        public string Background_StringProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty");
            }
        }

        public bool IsEnabled_StringProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty");
            }
        }

        public bool IsReadOnly_StringProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty");
            }
        }

        public bool IsInEditMode_StringProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty");
            }
        }

        public bool IsCurrent_StringProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty");
            }
        }

        public int IntProperty
        {
            get
            {
                return base.GetValue<int>("IntProperty");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty");
            }
        }

        public string Foreground_IntProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty");
            }
        }

        public string Background_IntProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty");
            }
        }

        public bool IsEnabled_IntProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty");
            }
        }

        public bool IsReadOnly_IntProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty");
            }
        }

        public bool IsInEditMode_IntProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty");
            }
        }

        public bool IsCurrent_IntProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty");
            }
        }

        public bool BoolProperty
        {
            get
            {
                return base.GetValue<bool>("BoolProperty");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty");
            }
        }

        public string Foreground_BoolProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty");
            }
        }

        public string Background_BoolProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty");
            }
        }

        public bool IsEnabled_BoolProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty");
            }
        }

        public bool IsReadOnly_BoolProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty");
            }
        }

        public bool IsInEditMode_BoolProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty");
            }
        }

        public bool IsCurrent_BoolProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty");
            }
        }

        public string DropDown
        {
            get
            {
                return base.GetValue<string>("DropDown");
            }
            set
            {
                base.SetValue<string>(value, "DropDown");
            }
        }

        public string Foreground_DropDown
        {
            get
            {
                return base.GetForegroundInternal("Foreground_DropDown");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_DropDown");
            }
        }

        public string Background_DropDown
        {
            get
            {
                return base.GetBackgroundInternal("Background_DropDown");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_DropDown");
            }
        }

        public bool IsEnabled_DropDown
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_DropDown");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_DropDown");
            }
        }

        public bool IsReadOnly_DropDown
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_DropDown");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_DropDown");
            }
        }

        public bool IsInEditMode_DropDown
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_DropDown");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_DropDown");
            }
        }

        public bool IsCurrent_DropDown
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_DropDown");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_DropDown");
            }
        }

        public string Button1
        {
            get
            {
                return base.GetValue<string>("Button1");
            }
            set
            {
                base.SetValue<string>(value, "Button1");
            }
        }

        public string Foreground_Button1
        {
            get
            {
                return base.GetForegroundInternal("Foreground_Button1");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_Button1");
            }
        }

        public string Background_Button1
        {
            get
            {
                return base.GetBackgroundInternal("Background_Button1");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_Button1");
            }
        }

        public bool IsEnabled_Button1
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_Button1");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_Button1");
            }
        }

        public bool IsReadOnly_Button1
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_Button1");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_Button1");
            }
        }

        public bool IsInEditMode_Button1
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_Button1");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_Button1");
            }
        }

        public bool IsCurrent_Button1
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_Button1");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_Button1");
            }
        }

        public string Button2
        {
            get
            {
                return base.GetValue<string>("Button2");
            }
            set
            {
                base.SetValue<string>(value, "Button2");
            }
        }

        public string Foreground_Button2
        {
            get
            {
                return base.GetForegroundInternal("Foreground_Button2");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_Button2");
            }
        }

        public string Background_Button2
        {
            get
            {
                return base.GetBackgroundInternal("Background_Button2");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_Button2");
            }
        }

        public bool IsEnabled_Button2
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_Button2");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_Button2");
            }
        }

        public bool IsReadOnly_Button2
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_Button2");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_Button2");
            }
        }

        public bool IsInEditMode_Button2
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_Button2");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_Button2");
            }
        }

        public bool IsCurrent_Button2
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_Button2");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_Button2");
            }
        }

        public DateTime? DateTimeProperty
        {
            get
            {
                return base.GetValue<DateTime?>("DateTimeProperty");
            }
            set
            {
                base.SetValue<DateTime?>(value, "DateTimeProperty");
            }
        }

        public string Foreground_DateTimeProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_DateTimeProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_DateTimeProperty");
            }
        }

        public string Background_DateTimeProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_DateTimeProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_DateTimeProperty");
            }
        }

        public bool IsEnabled_DateTimeProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_DateTimeProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_DateTimeProperty");
            }
        }

        public bool IsReadOnly_DateTimeProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_DateTimeProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_DateTimeProperty");
            }
        }

        public bool IsInEditMode_DateTimeProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_DateTimeProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_DateTimeProperty");
            }
        }

        public bool IsCurrent_DateTimeProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_DateTimeProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_DateTimeProperty");
            }
        }

        public DateTime? DateProperty
        {
            get
            {
                return base.GetValue<DateTime?>("DateProperty");
            }
            set
            {
                base.SetValue<DateTime?>(value, "DateProperty");
            }
        }

        public string Foreground_DateProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_DateProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_DateProperty");
            }
        }

        public string Background_DateProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_DateProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_DateProperty");
            }
        }

        public bool IsEnabled_DateProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_DateProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_DateProperty");
            }
        }

        public bool IsReadOnly_DateProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_DateProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_DateProperty");
            }
        }

        public bool IsInEditMode_DateProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_DateProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_DateProperty");
            }
        }

        public bool IsCurrent_DateProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_DateProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_DateProperty");
            }
        }

        public DateTime? TimeProperty
        {
            get
            {
                return base.GetValue<DateTime?>("TimeProperty");
            }
            set
            {
                base.SetValue<DateTime?>(value, "TimeProperty");
            }
        }

        public string Foreground_TimeProperty
        {
            get
            {
                return base.GetForegroundInternal("Foreground_TimeProperty");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_TimeProperty");
            }
        }

        public string Background_TimeProperty
        {
            get
            {
                return base.GetBackgroundInternal("Background_TimeProperty");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_TimeProperty");
            }
        }

        public bool IsEnabled_TimeProperty
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_TimeProperty");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_TimeProperty");
            }
        }

        public bool IsReadOnly_TimeProperty
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_TimeProperty");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_TimeProperty");
            }
        }

        public bool IsInEditMode_TimeProperty
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_TimeProperty");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_TimeProperty");
            }
        }

        public bool IsCurrent_TimeProperty
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_TimeProperty");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_TimeProperty");
            }
        }

        public string StringProperty1
        {
            get
            {
                return base.GetValue<string>("StringProperty1");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty1");
            }
        }

        public string Foreground_StringProperty1
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty1");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty1");
            }
        }

        public string Background_StringProperty1
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty1");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty1");
            }
        }

        public bool IsEnabled_StringProperty1
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty1");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty1");
            }
        }

        public bool IsReadOnly_StringProperty1
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty1");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty1");
            }
        }

        public bool IsInEditMode_StringProperty1
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty1");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty1");
            }
        }

        public bool IsCurrent_StringProperty1
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty1");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty1");
            }
        }

        public int IntProperty1
        {
            get
            {
                return base.GetValue<int>("IntProperty1");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty1");
            }
        }

        public string Foreground_IntProperty1
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty1");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty1");
            }
        }

        public string Background_IntProperty1
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty1");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty1");
            }
        }

        public bool IsEnabled_IntProperty1
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty1");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty1");
            }
        }

        public bool IsReadOnly_IntProperty1
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty1");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty1");
            }
        }

        public bool IsInEditMode_IntProperty1
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty1");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty1");
            }
        }

        public bool IsCurrent_IntProperty1
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty1");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty1");
            }
        }

        public bool BoolProperty1
        {
            get
            {
                return base.GetValue<bool>("BoolProperty1");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty1");
            }
        }

        public string Foreground_BoolProperty1
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty1");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty1");
            }
        }

        public string Background_BoolProperty1
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty1");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty1");
            }
        }

        public bool IsEnabled_BoolProperty1
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty1");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty1");
            }
        }

        public bool IsReadOnly_BoolProperty1
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty1");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty1");
            }
        }

        public bool IsInEditMode_BoolProperty1
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty1");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty1");
            }
        }

        public bool IsCurrent_BoolProperty1
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty1");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty1");
            }
        }

        public string StringProperty2
        {
            get
            {
                return base.GetValue<string>("StringProperty2");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty2");
            }
        }

        public string Foreground_StringProperty2
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty2");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty2");
            }
        }

        public string Background_StringProperty2
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty2");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty2");
            }
        }

        public bool IsEnabled_StringProperty2
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty2");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty2");
            }
        }

        public bool IsReadOnly_StringProperty2
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty2");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty2");
            }
        }

        public bool IsInEditMode_StringProperty2
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty2");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty2");
            }
        }

        public bool IsCurrent_StringProperty2
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty2");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty2");
            }
        }

        public int IntProperty2
        {
            get
            {
                return base.GetValue<int>("IntProperty2");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty2");
            }
        }

        public string Foreground_IntProperty2
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty2");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty2");
            }
        }

        public string Background_IntProperty2
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty2");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty2");
            }
        }

        public bool IsEnabled_IntProperty2
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty2");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty2");
            }
        }

        public bool IsReadOnly_IntProperty2
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty2");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty2");
            }
        }

        public bool IsInEditMode_IntProperty2
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty2");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty2");
            }
        }

        public bool IsCurrent_IntProperty2
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty2");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty2");
            }
        }

        public bool BoolProperty2
        {
            get
            {
                return base.GetValue<bool>("BoolProperty2");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty2");
            }
        }

        public string Foreground_BoolProperty2
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty2");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty2");
            }
        }

        public string Background_BoolProperty2
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty2");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty2");
            }
        }

        public bool IsEnabled_BoolProperty2
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty2");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty2");
            }
        }

        public bool IsReadOnly_BoolProperty2
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty2");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty2");
            }
        }

        public bool IsInEditMode_BoolProperty2
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty2");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty2");
            }
        }

        public bool IsCurrent_BoolProperty2
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty2");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty2");
            }
        }

        public string StringProperty3
        {
            get
            {
                return base.GetValue<string>("StringProperty3");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty3");
            }
        }

        public string Foreground_StringProperty3
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty3");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty3");
            }
        }

        public string Background_StringProperty3
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty3");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty3");
            }
        }

        public bool IsEnabled_StringProperty3
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty3");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty3");
            }
        }

        public bool IsReadOnly_StringProperty3
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty3");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty3");
            }
        }

        public bool IsInEditMode_StringProperty3
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty3");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty3");
            }
        }

        public bool IsCurrent_StringProperty3
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty3");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty3");
            }
        }

        public int IntProperty3
        {
            get
            {
                return base.GetValue<int>("IntProperty3");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty3");
            }
        }

        public string Foreground_IntProperty3
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty3");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty3");
            }
        }

        public string Background_IntProperty3
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty3");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty3");
            }
        }

        public bool IsEnabled_IntProperty3
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty3");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty3");
            }
        }

        public bool IsReadOnly_IntProperty3
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty3");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty3");
            }
        }

        public bool IsInEditMode_IntProperty3
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty3");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty3");
            }
        }

        public bool IsCurrent_IntProperty3
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty3");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty3");
            }
        }

        public bool BoolProperty3
        {
            get
            {
                return base.GetValue<bool>("BoolProperty3");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty3");
            }
        }

        public string Foreground_BoolProperty3
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty3");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty3");
            }
        }

        public string Background_BoolProperty3
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty3");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty3");
            }
        }

        public bool IsEnabled_BoolProperty3
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty3");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty3");
            }
        }

        public bool IsReadOnly_BoolProperty3
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty3");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty3");
            }
        }

        public bool IsInEditMode_BoolProperty3
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty3");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty3");
            }
        }

        public bool IsCurrent_BoolProperty3
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty3");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty3");
            }
        }

        public string StringProperty4
        {
            get
            {
                return base.GetValue<string>("StringProperty4");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty4");
            }
        }

        public string Foreground_StringProperty4
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty4");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty4");
            }
        }

        public string Background_StringProperty4
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty4");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty4");
            }
        }

        public bool IsEnabled_StringProperty4
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty4");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty4");
            }
        }

        public bool IsReadOnly_StringProperty4
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty4");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty4");
            }
        }

        public bool IsInEditMode_StringProperty4
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty4");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty4");
            }
        }

        public bool IsCurrent_StringProperty4
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty4");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty4");
            }
        }

        public int IntProperty4
        {
            get
            {
                return base.GetValue<int>("IntProperty4");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty4");
            }
        }

        public string Foreground_IntProperty4
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty4");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty4");
            }
        }

        public string Background_IntProperty4
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty4");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty4");
            }
        }

        public bool IsEnabled_IntProperty4
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty4");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty4");
            }
        }

        public bool IsReadOnly_IntProperty4
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty4");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty4");
            }
        }

        public bool IsInEditMode_IntProperty4
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty4");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty4");
            }
        }

        public bool IsCurrent_IntProperty4
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty4");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty4");
            }
        }

        public bool BoolProperty4
        {
            get
            {
                return base.GetValue<bool>("BoolProperty4");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty4");
            }
        }

        public string Foreground_BoolProperty4
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty4");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty4");
            }
        }

        public string Background_BoolProperty4
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty4");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty4");
            }
        }

        public bool IsEnabled_BoolProperty4
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty4");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty4");
            }
        }

        public bool IsReadOnly_BoolProperty4
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty4");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty4");
            }
        }

        public bool IsInEditMode_BoolProperty4
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty4");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty4");
            }
        }

        public bool IsCurrent_BoolProperty4
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty4");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty4");
            }
        }

        public string StringProperty5
        {
            get
            {
                return base.GetValue<string>("StringProperty5");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty5");
            }
        }

        public string Foreground_StringProperty5
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty5");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty5");
            }
        }

        public string Background_StringProperty5
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty5");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty5");
            }
        }

        public bool IsEnabled_StringProperty5
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty5");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty5");
            }
        }

        public bool IsReadOnly_StringProperty5
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty5");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty5");
            }
        }

        public bool IsInEditMode_StringProperty5
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty5");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty5");
            }
        }

        public bool IsCurrent_StringProperty5
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty5");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty5");
            }
        }

        public int IntProperty5
        {
            get
            {
                return base.GetValue<int>("IntProperty5");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty5");
            }
        }

        public string Foreground_IntProperty5
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty5");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty5");
            }
        }

        public string Background_IntProperty5
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty5");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty5");
            }
        }

        public bool IsEnabled_IntProperty5
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty5");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty5");
            }
        }

        public bool IsReadOnly_IntProperty5
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty5");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty5");
            }
        }

        public bool IsInEditMode_IntProperty5
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty5");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty5");
            }
        }

        public bool IsCurrent_IntProperty5
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty5");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty5");
            }
        }

        public bool BoolProperty5
        {
            get
            {
                return base.GetValue<bool>("BoolProperty5");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty5");
            }
        }

        public string Foreground_BoolProperty5
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty5");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty5");
            }
        }

        public string Background_BoolProperty5
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty5");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty5");
            }
        }

        public bool IsEnabled_BoolProperty5
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty5");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty5");
            }
        }

        public bool IsReadOnly_BoolProperty5
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty5");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty5");
            }
        }

        public bool IsInEditMode_BoolProperty5
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty5");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty5");
            }
        }

        public bool IsCurrent_BoolProperty5
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty5");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty5");
            }
        }

        public string StringProperty6
        {
            get
            {
                return base.GetValue<string>("StringProperty6");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty6");
            }
        }

        public string Foreground_StringProperty6
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty6");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty6");
            }
        }

        public string Background_StringProperty6
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty6");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty6");
            }
        }

        public bool IsEnabled_StringProperty6
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty6");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty6");
            }
        }

        public bool IsReadOnly_StringProperty6
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty6");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty6");
            }
        }

        public bool IsInEditMode_StringProperty6
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty6");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty6");
            }
        }

        public bool IsCurrent_StringProperty6
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty6");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty6");
            }
        }

        public int IntProperty6
        {
            get
            {
                return base.GetValue<int>("IntProperty6");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty6");
            }
        }

        public string Foreground_IntProperty6
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty6");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty6");
            }
        }

        public string Background_IntProperty6
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty6");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty6");
            }
        }

        public bool IsEnabled_IntProperty6
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty6");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty6");
            }
        }

        public bool IsReadOnly_IntProperty6
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty6");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty6");
            }
        }

        public bool IsInEditMode_IntProperty6
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty6");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty6");
            }
        }

        public bool IsCurrent_IntProperty6
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty6");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty6");
            }
        }

        public bool BoolProperty6
        {
            get
            {
                return base.GetValue<bool>("BoolProperty6");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty6");
            }
        }

        public string Foreground_BoolProperty6
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty6");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty6");
            }
        }

        public string Background_BoolProperty6
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty6");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty6");
            }
        }

        public bool IsEnabled_BoolProperty6
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty6");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty6");
            }
        }

        public bool IsReadOnly_BoolProperty6
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty6");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty6");
            }
        }

        public bool IsInEditMode_BoolProperty6
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty6");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty6");
            }
        }

        public bool IsCurrent_BoolProperty6
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty6");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty6");
            }
        }

        public string StringProperty7
        {
            get
            {
                return base.GetValue<string>("StringProperty7");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty7");
            }
        }

        public string Foreground_StringProperty7
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty7");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty7");
            }
        }

        public string Background_StringProperty7
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty7");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty7");
            }
        }

        public bool IsEnabled_StringProperty7
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty7");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty7");
            }
        }

        public bool IsReadOnly_StringProperty7
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty7");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty7");
            }
        }

        public bool IsInEditMode_StringProperty7
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty7");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty7");
            }
        }

        public bool IsCurrent_StringProperty7
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty7");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty7");
            }
        }

        public int IntProperty7
        {
            get
            {
                return base.GetValue<int>("IntProperty7");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty7");
            }
        }

        public string Foreground_IntProperty7
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty7");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty7");
            }
        }

        public string Background_IntProperty7
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty7");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty7");
            }
        }

        public bool IsEnabled_IntProperty7
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty7");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty7");
            }
        }

        public bool IsReadOnly_IntProperty7
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty7");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty7");
            }
        }

        public bool IsInEditMode_IntProperty7
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty7");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty7");
            }
        }

        public bool IsCurrent_IntProperty7
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty7");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty7");
            }
        }

        public bool BoolProperty7
        {
            get
            {
                return base.GetValue<bool>("BoolProperty7");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty7");
            }
        }

        public string Foreground_BoolProperty7
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty7");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty7");
            }
        }

        public string Background_BoolProperty7
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty7");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty7");
            }
        }

        public bool IsEnabled_BoolProperty7
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty7");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty7");
            }
        }

        public bool IsReadOnly_BoolProperty7
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty7");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty7");
            }
        }

        public bool IsInEditMode_BoolProperty7
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty7");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty7");
            }
        }

        public bool IsCurrent_BoolProperty7
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty7");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty7");
            }
        }

        public string StringProperty8
        {
            get
            {
                return base.GetValue<string>("StringProperty8");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty8");
            }
        }

        public string Foreground_StringProperty8
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty8");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty8");
            }
        }

        public string Background_StringProperty8
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty8");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty8");
            }
        }

        public bool IsEnabled_StringProperty8
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty8");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty8");
            }
        }

        public bool IsReadOnly_StringProperty8
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty8");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty8");
            }
        }

        public bool IsInEditMode_StringProperty8
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty8");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty8");
            }
        }

        public bool IsCurrent_StringProperty8
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty8");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty8");
            }
        }

        public int IntProperty8
        {
            get
            {
                return base.GetValue<int>("IntProperty8");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty8");
            }
        }

        public string Foreground_IntProperty8
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty8");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty8");
            }
        }

        public string Background_IntProperty8
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty8");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty8");
            }
        }

        public bool IsEnabled_IntProperty8
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty8");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty8");
            }
        }

        public bool IsReadOnly_IntProperty8
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty8");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty8");
            }
        }

        public bool IsInEditMode_IntProperty8
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty8");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty8");
            }
        }

        public bool IsCurrent_IntProperty8
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty8");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty8");
            }
        }

        public bool BoolProperty8
        {
            get
            {
                return base.GetValue<bool>("BoolProperty8");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty8");
            }
        }

        public string Foreground_BoolProperty8
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty8");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty8");
            }
        }

        public string Background_BoolProperty8
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty8");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty8");
            }
        }

        public bool IsEnabled_BoolProperty8
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty8");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty8");
            }
        }

        public bool IsReadOnly_BoolProperty8
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty8");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty8");
            }
        }

        public bool IsInEditMode_BoolProperty8
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty8");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty8");
            }
        }

        public bool IsCurrent_BoolProperty8
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty8");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty8");
            }
        }

        public string StringProperty9
        {
            get
            {
                return base.GetValue<string>("StringProperty9");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty9");
            }
        }

        public string Foreground_StringProperty9
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty9");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty9");
            }
        }

        public string Background_StringProperty9
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty9");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty9");
            }
        }

        public bool IsEnabled_StringProperty9
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty9");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty9");
            }
        }

        public bool IsReadOnly_StringProperty9
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty9");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty9");
            }
        }

        public bool IsInEditMode_StringProperty9
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty9");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty9");
            }
        }

        public bool IsCurrent_StringProperty9
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty9");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty9");
            }
        }

        public int IntProperty9
        {
            get
            {
                return base.GetValue<int>("IntProperty9");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty9");
            }
        }

        public string Foreground_IntProperty9
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty9");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty9");
            }
        }

        public string Background_IntProperty9
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty9");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty9");
            }
        }

        public bool IsEnabled_IntProperty9
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty9");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty9");
            }
        }

        public bool IsReadOnly_IntProperty9
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty9");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty9");
            }
        }

        public bool IsInEditMode_IntProperty9
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty9");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty9");
            }
        }

        public bool IsCurrent_IntProperty9
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty9");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty9");
            }
        }

        public bool BoolProperty9
        {
            get
            {
                return base.GetValue<bool>("BoolProperty9");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty9");
            }
        }

        public string Foreground_BoolProperty9
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty9");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty9");
            }
        }

        public string Background_BoolProperty9
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty9");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty9");
            }
        }

        public bool IsEnabled_BoolProperty9
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty9");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty9");
            }
        }

        public bool IsReadOnly_BoolProperty9
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty9");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty9");
            }
        }

        public bool IsInEditMode_BoolProperty9
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty9");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty9");
            }
        }

        public bool IsCurrent_BoolProperty9
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty9");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty9");
            }
        }

        public string StringProperty10
        {
            get
            {
                return base.GetValue<string>("StringProperty10");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty10");
            }
        }

        public string Foreground_StringProperty10
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty10");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty10");
            }
        }

        public string Background_StringProperty10
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty10");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty10");
            }
        }

        public bool IsEnabled_StringProperty10
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty10");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty10");
            }
        }

        public bool IsReadOnly_StringProperty10
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty10");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty10");
            }
        }

        public bool IsInEditMode_StringProperty10
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty10");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty10");
            }
        }

        public bool IsCurrent_StringProperty10
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty10");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty10");
            }
        }

        public int IntProperty10
        {
            get
            {
                return base.GetValue<int>("IntProperty10");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty10");
            }
        }

        public string Foreground_IntProperty10
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty10");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty10");
            }
        }

        public string Background_IntProperty10
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty10");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty10");
            }
        }

        public bool IsEnabled_IntProperty10
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty10");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty10");
            }
        }

        public bool IsReadOnly_IntProperty10
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty10");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty10");
            }
        }

        public bool IsInEditMode_IntProperty10
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty10");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty10");
            }
        }

        public bool IsCurrent_IntProperty10
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty10");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty10");
            }
        }

        public bool BoolProperty10
        {
            get
            {
                return base.GetValue<bool>("BoolProperty10");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty10");
            }
        }

        public string Foreground_BoolProperty10
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty10");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty10");
            }
        }

        public string Background_BoolProperty10
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty10");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty10");
            }
        }

        public bool IsEnabled_BoolProperty10
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty10");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty10");
            }
        }

        public bool IsReadOnly_BoolProperty10
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty10");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty10");
            }
        }

        public bool IsInEditMode_BoolProperty10
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty10");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty10");
            }
        }

        public bool IsCurrent_BoolProperty10
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty10");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty10");
            }
        }

        public string StringProperty11
        {
            get
            {
                return base.GetValue<string>("StringProperty11");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty11");
            }
        }

        public string Foreground_StringProperty11
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty11");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty11");
            }
        }

        public string Background_StringProperty11
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty11");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty11");
            }
        }

        public bool IsEnabled_StringProperty11
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty11");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty11");
            }
        }

        public bool IsReadOnly_StringProperty11
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty11");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty11");
            }
        }

        public bool IsInEditMode_StringProperty11
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty11");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty11");
            }
        }

        public bool IsCurrent_StringProperty11
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty11");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty11");
            }
        }

        public int IntProperty11
        {
            get
            {
                return base.GetValue<int>("IntProperty11");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty11");
            }
        }

        public string Foreground_IntProperty11
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty11");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty11");
            }
        }

        public string Background_IntProperty11
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty11");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty11");
            }
        }

        public bool IsEnabled_IntProperty11
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty11");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty11");
            }
        }

        public bool IsReadOnly_IntProperty11
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty11");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty11");
            }
        }

        public bool IsInEditMode_IntProperty11
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty11");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty11");
            }
        }

        public bool IsCurrent_IntProperty11
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty11");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty11");
            }
        }

        public bool BoolProperty11
        {
            get
            {
                return base.GetValue<bool>("BoolProperty11");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty11");
            }
        }

        public string Foreground_BoolProperty11
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty11");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty11");
            }
        }

        public string Background_BoolProperty11
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty11");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty11");
            }
        }

        public bool IsEnabled_BoolProperty11
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty11");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty11");
            }
        }

        public bool IsReadOnly_BoolProperty11
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty11");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty11");
            }
        }

        public bool IsInEditMode_BoolProperty11
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty11");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty11");
            }
        }

        public bool IsCurrent_BoolProperty11
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty11");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty11");
            }
        }

        public string StringProperty12
        {
            get
            {
                return base.GetValue<string>("StringProperty12");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty12");
            }
        }

        public string Foreground_StringProperty12
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty12");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty12");
            }
        }

        public string Background_StringProperty12
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty12");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty12");
            }
        }

        public bool IsEnabled_StringProperty12
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty12");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty12");
            }
        }

        public bool IsReadOnly_StringProperty12
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty12");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty12");
            }
        }

        public bool IsInEditMode_StringProperty12
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty12");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty12");
            }
        }

        public bool IsCurrent_StringProperty12
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty12");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty12");
            }
        }

        public int IntProperty12
        {
            get
            {
                return base.GetValue<int>("IntProperty12");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty12");
            }
        }

        public string Foreground_IntProperty12
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty12");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty12");
            }
        }

        public string Background_IntProperty12
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty12");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty12");
            }
        }

        public bool IsEnabled_IntProperty12
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty12");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty12");
            }
        }

        public bool IsReadOnly_IntProperty12
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty12");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty12");
            }
        }

        public bool IsInEditMode_IntProperty12
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty12");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty12");
            }
        }

        public bool IsCurrent_IntProperty12
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty12");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty12");
            }
        }

        public bool BoolProperty12
        {
            get
            {
                return base.GetValue<bool>("BoolProperty12");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty12");
            }
        }

        public string Foreground_BoolProperty12
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty12");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty12");
            }
        }

        public string Background_BoolProperty12
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty12");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty12");
            }
        }

        public bool IsEnabled_BoolProperty12
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty12");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty12");
            }
        }

        public bool IsReadOnly_BoolProperty12
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty12");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty12");
            }
        }

        public bool IsInEditMode_BoolProperty12
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty12");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty12");
            }
        }

        public bool IsCurrent_BoolProperty12
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty12");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty12");
            }
        }

        public string StringProperty13
        {
            get
            {
                return base.GetValue<string>("StringProperty13");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty13");
            }
        }

        public string Foreground_StringProperty13
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty13");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty13");
            }
        }

        public string Background_StringProperty13
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty13");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty13");
            }
        }

        public bool IsEnabled_StringProperty13
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty13");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty13");
            }
        }

        public bool IsReadOnly_StringProperty13
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty13");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty13");
            }
        }

        public bool IsInEditMode_StringProperty13
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty13");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty13");
            }
        }

        public bool IsCurrent_StringProperty13
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty13");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty13");
            }
        }

        public int IntProperty13
        {
            get
            {
                return base.GetValue<int>("IntProperty13");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty13");
            }
        }

        public string Foreground_IntProperty13
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty13");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty13");
            }
        }

        public string Background_IntProperty13
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty13");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty13");
            }
        }

        public bool IsEnabled_IntProperty13
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty13");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty13");
            }
        }

        public bool IsReadOnly_IntProperty13
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty13");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty13");
            }
        }

        public bool IsInEditMode_IntProperty13
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty13");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty13");
            }
        }

        public bool IsCurrent_IntProperty13
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty13");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty13");
            }
        }

        public bool BoolProperty13
        {
            get
            {
                return base.GetValue<bool>("BoolProperty13");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty13");
            }
        }

        public string Foreground_BoolProperty13
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty13");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty13");
            }
        }

        public string Background_BoolProperty13
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty13");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty13");
            }
        }

        public bool IsEnabled_BoolProperty13
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty13");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty13");
            }
        }

        public bool IsReadOnly_BoolProperty13
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty13");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty13");
            }
        }

        public bool IsInEditMode_BoolProperty13
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty13");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty13");
            }
        }

        public bool IsCurrent_BoolProperty13
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty13");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty13");
            }
        }

        public string StringProperty14
        {
            get
            {
                return base.GetValue<string>("StringProperty14");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty14");
            }
        }

        public string Foreground_StringProperty14
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty14");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty14");
            }
        }

        public string Background_StringProperty14
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty14");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty14");
            }
        }

        public bool IsEnabled_StringProperty14
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty14");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty14");
            }
        }

        public bool IsReadOnly_StringProperty14
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty14");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty14");
            }
        }

        public bool IsInEditMode_StringProperty14
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty14");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty14");
            }
        }

        public bool IsCurrent_StringProperty14
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty14");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty14");
            }
        }

        public int IntProperty14
        {
            get
            {
                return base.GetValue<int>("IntProperty14");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty14");
            }
        }

        public string Foreground_IntProperty14
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty14");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty14");
            }
        }

        public string Background_IntProperty14
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty14");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty14");
            }
        }

        public bool IsEnabled_IntProperty14
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty14");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty14");
            }
        }

        public bool IsReadOnly_IntProperty14
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty14");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty14");
            }
        }

        public bool IsInEditMode_IntProperty14
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty14");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty14");
            }
        }

        public bool IsCurrent_IntProperty14
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty14");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty14");
            }
        }

        public bool BoolProperty14
        {
            get
            {
                return base.GetValue<bool>("BoolProperty14");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty14");
            }
        }

        public string Foreground_BoolProperty14
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty14");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty14");
            }
        }

        public string Background_BoolProperty14
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty14");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty14");
            }
        }

        public bool IsEnabled_BoolProperty14
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty14");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty14");
            }
        }

        public bool IsReadOnly_BoolProperty14
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty14");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty14");
            }
        }

        public bool IsInEditMode_BoolProperty14
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty14");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty14");
            }
        }

        public bool IsCurrent_BoolProperty14
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty14");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty14");
            }
        }

        public string StringProperty15
        {
            get
            {
                return base.GetValue<string>("StringProperty15");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty15");
            }
        }

        public string Foreground_StringProperty15
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty15");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty15");
            }
        }

        public string Background_StringProperty15
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty15");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty15");
            }
        }

        public bool IsEnabled_StringProperty15
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty15");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty15");
            }
        }

        public bool IsReadOnly_StringProperty15
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty15");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty15");
            }
        }

        public bool IsInEditMode_StringProperty15
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty15");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty15");
            }
        }

        public bool IsCurrent_StringProperty15
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty15");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty15");
            }
        }

        public int IntProperty15
        {
            get
            {
                return base.GetValue<int>("IntProperty15");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty15");
            }
        }

        public string Foreground_IntProperty15
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty15");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty15");
            }
        }

        public string Background_IntProperty15
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty15");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty15");
            }
        }

        public bool IsEnabled_IntProperty15
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty15");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty15");
            }
        }

        public bool IsReadOnly_IntProperty15
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty15");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty15");
            }
        }

        public bool IsInEditMode_IntProperty15
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty15");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty15");
            }
        }

        public bool IsCurrent_IntProperty15
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty15");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty15");
            }
        }

        public bool BoolProperty15
        {
            get
            {
                return base.GetValue<bool>("BoolProperty15");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty15");
            }
        }

        public string Foreground_BoolProperty15
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty15");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty15");
            }
        }

        public string Background_BoolProperty15
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty15");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty15");
            }
        }

        public bool IsEnabled_BoolProperty15
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty15");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty15");
            }
        }

        public bool IsReadOnly_BoolProperty15
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty15");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty15");
            }
        }

        public bool IsInEditMode_BoolProperty15
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty15");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty15");
            }
        }

        public bool IsCurrent_BoolProperty15
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty15");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty15");
            }
        }

        public string StringProperty16
        {
            get
            {
                return base.GetValue<string>("StringProperty16");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty16");
            }
        }

        public string Foreground_StringProperty16
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty16");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty16");
            }
        }

        public string Background_StringProperty16
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty16");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty16");
            }
        }

        public bool IsEnabled_StringProperty16
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty16");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty16");
            }
        }

        public bool IsReadOnly_StringProperty16
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty16");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty16");
            }
        }

        public bool IsInEditMode_StringProperty16
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty16");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty16");
            }
        }

        public bool IsCurrent_StringProperty16
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty16");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty16");
            }
        }

        public int IntProperty16
        {
            get
            {
                return base.GetValue<int>("IntProperty16");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty16");
            }
        }

        public string Foreground_IntProperty16
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty16");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty16");
            }
        }

        public string Background_IntProperty16
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty16");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty16");
            }
        }

        public bool IsEnabled_IntProperty16
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty16");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty16");
            }
        }

        public bool IsReadOnly_IntProperty16
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty16");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty16");
            }
        }

        public bool IsInEditMode_IntProperty16
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty16");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty16");
            }
        }

        public bool IsCurrent_IntProperty16
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty16");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty16");
            }
        }

        public bool BoolProperty16
        {
            get
            {
                return base.GetValue<bool>("BoolProperty16");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty16");
            }
        }

        public string Foreground_BoolProperty16
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty16");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty16");
            }
        }

        public string Background_BoolProperty16
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty16");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty16");
            }
        }

        public bool IsEnabled_BoolProperty16
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty16");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty16");
            }
        }

        public bool IsReadOnly_BoolProperty16
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty16");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty16");
            }
        }

        public bool IsInEditMode_BoolProperty16
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty16");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty16");
            }
        }

        public bool IsCurrent_BoolProperty16
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty16");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty16");
            }
        }

        public string StringProperty17
        {
            get
            {
                return base.GetValue<string>("StringProperty17");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty17");
            }
        }

        public string Foreground_StringProperty17
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty17");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty17");
            }
        }

        public string Background_StringProperty17
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty17");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty17");
            }
        }

        public bool IsEnabled_StringProperty17
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty17");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty17");
            }
        }

        public bool IsReadOnly_StringProperty17
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty17");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty17");
            }
        }

        public bool IsInEditMode_StringProperty17
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty17");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty17");
            }
        }

        public bool IsCurrent_StringProperty17
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty17");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty17");
            }
        }

        public int IntProperty17
        {
            get
            {
                return base.GetValue<int>("IntProperty17");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty17");
            }
        }

        public string Foreground_IntProperty17
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty17");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty17");
            }
        }

        public string Background_IntProperty17
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty17");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty17");
            }
        }

        public bool IsEnabled_IntProperty17
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty17");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty17");
            }
        }

        public bool IsReadOnly_IntProperty17
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty17");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty17");
            }
        }

        public bool IsInEditMode_IntProperty17
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty17");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty17");
            }
        }

        public bool IsCurrent_IntProperty17
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty17");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty17");
            }
        }

        public bool BoolProperty17
        {
            get
            {
                return base.GetValue<bool>("BoolProperty17");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty17");
            }
        }

        public string Foreground_BoolProperty17
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty17");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty17");
            }
        }

        public string Background_BoolProperty17
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty17");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty17");
            }
        }

        public bool IsEnabled_BoolProperty17
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty17");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty17");
            }
        }

        public bool IsReadOnly_BoolProperty17
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty17");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty17");
            }
        }

        public bool IsInEditMode_BoolProperty17
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty17");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty17");
            }
        }

        public bool IsCurrent_BoolProperty17
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty17");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty17");
            }
        }

        public string StringProperty18
        {
            get
            {
                return base.GetValue<string>("StringProperty18");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty18");
            }
        }

        public string Foreground_StringProperty18
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty18");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty18");
            }
        }

        public string Background_StringProperty18
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty18");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty18");
            }
        }

        public bool IsEnabled_StringProperty18
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty18");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty18");
            }
        }

        public bool IsReadOnly_StringProperty18
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty18");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty18");
            }
        }

        public bool IsInEditMode_StringProperty18
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty18");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty18");
            }
        }

        public bool IsCurrent_StringProperty18
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty18");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty18");
            }
        }

        public int IntProperty18
        {
            get
            {
                return base.GetValue<int>("IntProperty18");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty18");
            }
        }

        public string Foreground_IntProperty18
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty18");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty18");
            }
        }

        public string Background_IntProperty18
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty18");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty18");
            }
        }

        public bool IsEnabled_IntProperty18
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty18");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty18");
            }
        }

        public bool IsReadOnly_IntProperty18
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty18");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty18");
            }
        }

        public bool IsInEditMode_IntProperty18
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty18");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty18");
            }
        }

        public bool IsCurrent_IntProperty18
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty18");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty18");
            }
        }

        public bool BoolProperty18
        {
            get
            {
                return base.GetValue<bool>("BoolProperty18");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty18");
            }
        }

        public string Foreground_BoolProperty18
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty18");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty18");
            }
        }

        public string Background_BoolProperty18
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty18");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty18");
            }
        }

        public bool IsEnabled_BoolProperty18
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty18");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty18");
            }
        }

        public bool IsReadOnly_BoolProperty18
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty18");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty18");
            }
        }

        public bool IsInEditMode_BoolProperty18
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty18");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty18");
            }
        }

        public bool IsCurrent_BoolProperty18
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty18");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty18");
            }
        }

        public string StringProperty19
        {
            get
            {
                return base.GetValue<string>("StringProperty19");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty19");
            }
        }

        public string Foreground_StringProperty19
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty19");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty19");
            }
        }

        public string Background_StringProperty19
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty19");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty19");
            }
        }

        public bool IsEnabled_StringProperty19
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty19");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty19");
            }
        }

        public bool IsReadOnly_StringProperty19
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty19");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty19");
            }
        }

        public bool IsInEditMode_StringProperty19
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty19");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty19");
            }
        }

        public bool IsCurrent_StringProperty19
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty19");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty19");
            }
        }

        public int IntProperty19
        {
            get
            {
                return base.GetValue<int>("IntProperty19");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty19");
            }
        }

        public string Foreground_IntProperty19
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty19");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty19");
            }
        }

        public string Background_IntProperty19
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty19");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty19");
            }
        }

        public bool IsEnabled_IntProperty19
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty19");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty19");
            }
        }

        public bool IsReadOnly_IntProperty19
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty19");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty19");
            }
        }

        public bool IsInEditMode_IntProperty19
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty19");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty19");
            }
        }

        public bool IsCurrent_IntProperty19
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty19");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty19");
            }
        }

        public bool BoolProperty19
        {
            get
            {
                return base.GetValue<bool>("BoolProperty19");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty19");
            }
        }

        public string Foreground_BoolProperty19
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty19");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty19");
            }
        }

        public string Background_BoolProperty19
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty19");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty19");
            }
        }

        public bool IsEnabled_BoolProperty19
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty19");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty19");
            }
        }

        public bool IsReadOnly_BoolProperty19
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty19");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty19");
            }
        }

        public bool IsInEditMode_BoolProperty19
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty19");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty19");
            }
        }

        public bool IsCurrent_BoolProperty19
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty19");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty19");
            }
        }

        public string StringProperty20
        {
            get
            {
                return base.GetValue<string>("StringProperty20");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty20");
            }
        }

        public string Foreground_StringProperty20
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty20");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty20");
            }
        }

        public string Background_StringProperty20
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty20");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty20");
            }
        }

        public bool IsEnabled_StringProperty20
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty20");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty20");
            }
        }

        public bool IsReadOnly_StringProperty20
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty20");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty20");
            }
        }

        public bool IsInEditMode_StringProperty20
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty20");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty20");
            }
        }

        public bool IsCurrent_StringProperty20
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty20");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty20");
            }
        }

        public int IntProperty20
        {
            get
            {
                return base.GetValue<int>("IntProperty20");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty20");
            }
        }

        public string Foreground_IntProperty20
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty20");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty20");
            }
        }

        public string Background_IntProperty20
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty20");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty20");
            }
        }

        public bool IsEnabled_IntProperty20
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty20");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty20");
            }
        }

        public bool IsReadOnly_IntProperty20
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty20");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty20");
            }
        }

        public bool IsInEditMode_IntProperty20
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty20");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty20");
            }
        }

        public bool IsCurrent_IntProperty20
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty20");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty20");
            }
        }

        public bool BoolProperty20
        {
            get
            {
                return base.GetValue<bool>("BoolProperty20");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty20");
            }
        }

        public string Foreground_BoolProperty20
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty20");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty20");
            }
        }

        public string Background_BoolProperty20
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty20");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty20");
            }
        }

        public bool IsEnabled_BoolProperty20
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty20");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty20");
            }
        }

        public bool IsReadOnly_BoolProperty20
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty20");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty20");
            }
        }

        public bool IsInEditMode_BoolProperty20
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty20");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty20");
            }
        }

        public bool IsCurrent_BoolProperty20
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty20");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty20");
            }
        }

        public string StringProperty21
        {
            get
            {
                return base.GetValue<string>("StringProperty21");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty21");
            }
        }

        public string Foreground_StringProperty21
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty21");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty21");
            }
        }

        public string Background_StringProperty21
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty21");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty21");
            }
        }

        public bool IsEnabled_StringProperty21
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty21");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty21");
            }
        }

        public bool IsReadOnly_StringProperty21
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty21");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty21");
            }
        }

        public bool IsInEditMode_StringProperty21
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty21");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty21");
            }
        }

        public bool IsCurrent_StringProperty21
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty21");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty21");
            }
        }

        public int IntProperty21
        {
            get
            {
                return base.GetValue<int>("IntProperty21");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty21");
            }
        }

        public string Foreground_IntProperty21
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty21");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty21");
            }
        }

        public string Background_IntProperty21
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty21");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty21");
            }
        }

        public bool IsEnabled_IntProperty21
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty21");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty21");
            }
        }

        public bool IsReadOnly_IntProperty21
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty21");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty21");
            }
        }

        public bool IsInEditMode_IntProperty21
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty21");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty21");
            }
        }

        public bool IsCurrent_IntProperty21
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty21");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty21");
            }
        }

        public bool BoolProperty21
        {
            get
            {
                return base.GetValue<bool>("BoolProperty21");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty21");
            }
        }

        public string Foreground_BoolProperty21
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty21");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty21");
            }
        }

        public string Background_BoolProperty21
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty21");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty21");
            }
        }

        public bool IsEnabled_BoolProperty21
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty21");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty21");
            }
        }

        public bool IsReadOnly_BoolProperty21
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty21");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty21");
            }
        }

        public bool IsInEditMode_BoolProperty21
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty21");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty21");
            }
        }

        public bool IsCurrent_BoolProperty21
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty21");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty21");
            }
        }

        public string StringProperty22
        {
            get
            {
                return base.GetValue<string>("StringProperty22");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty22");
            }
        }

        public string Foreground_StringProperty22
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty22");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty22");
            }
        }

        public string Background_StringProperty22
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty22");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty22");
            }
        }

        public bool IsEnabled_StringProperty22
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty22");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty22");
            }
        }

        public bool IsReadOnly_StringProperty22
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty22");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty22");
            }
        }

        public bool IsInEditMode_StringProperty22
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty22");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty22");
            }
        }

        public bool IsCurrent_StringProperty22
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty22");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty22");
            }
        }

        public int IntProperty22
        {
            get
            {
                return base.GetValue<int>("IntProperty22");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty22");
            }
        }

        public string Foreground_IntProperty22
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty22");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty22");
            }
        }

        public string Background_IntProperty22
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty22");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty22");
            }
        }

        public bool IsEnabled_IntProperty22
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty22");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty22");
            }
        }

        public bool IsReadOnly_IntProperty22
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty22");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty22");
            }
        }

        public bool IsInEditMode_IntProperty22
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty22");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty22");
            }
        }

        public bool IsCurrent_IntProperty22
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty22");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty22");
            }
        }

        public bool BoolProperty22
        {
            get
            {
                return base.GetValue<bool>("BoolProperty22");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty22");
            }
        }

        public string Foreground_BoolProperty22
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty22");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty22");
            }
        }

        public string Background_BoolProperty22
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty22");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty22");
            }
        }

        public bool IsEnabled_BoolProperty22
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty22");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty22");
            }
        }

        public bool IsReadOnly_BoolProperty22
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty22");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty22");
            }
        }

        public bool IsInEditMode_BoolProperty22
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty22");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty22");
            }
        }

        public bool IsCurrent_BoolProperty22
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty22");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty22");
            }
        }

        public string StringProperty23
        {
            get
            {
                return base.GetValue<string>("StringProperty23");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty23");
            }
        }

        public string Foreground_StringProperty23
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty23");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty23");
            }
        }

        public string Background_StringProperty23
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty23");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty23");
            }
        }

        public bool IsEnabled_StringProperty23
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty23");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty23");
            }
        }

        public bool IsReadOnly_StringProperty23
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty23");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty23");
            }
        }

        public bool IsInEditMode_StringProperty23
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty23");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty23");
            }
        }

        public bool IsCurrent_StringProperty23
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty23");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty23");
            }
        }

        public int IntProperty23
        {
            get
            {
                return base.GetValue<int>("IntProperty23");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty23");
            }
        }

        public string Foreground_IntProperty23
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty23");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty23");
            }
        }

        public string Background_IntProperty23
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty23");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty23");
            }
        }

        public bool IsEnabled_IntProperty23
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty23");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty23");
            }
        }

        public bool IsReadOnly_IntProperty23
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty23");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty23");
            }
        }

        public bool IsInEditMode_IntProperty23
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty23");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty23");
            }
        }

        public bool IsCurrent_IntProperty23
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty23");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty23");
            }
        }

        public bool BoolProperty23
        {
            get
            {
                return base.GetValue<bool>("BoolProperty23");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty23");
            }
        }

        public string Foreground_BoolProperty23
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty23");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty23");
            }
        }

        public string Background_BoolProperty23
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty23");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty23");
            }
        }

        public bool IsEnabled_BoolProperty23
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty23");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty23");
            }
        }

        public bool IsReadOnly_BoolProperty23
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty23");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty23");
            }
        }

        public bool IsInEditMode_BoolProperty23
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty23");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty23");
            }
        }

        public bool IsCurrent_BoolProperty23
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty23");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty23");
            }
        }

        public string StringProperty24
        {
            get
            {
                return base.GetValue<string>("StringProperty24");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty24");
            }
        }

        public string Foreground_StringProperty24
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty24");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty24");
            }
        }

        public string Background_StringProperty24
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty24");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty24");
            }
        }

        public bool IsEnabled_StringProperty24
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty24");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty24");
            }
        }

        public bool IsReadOnly_StringProperty24
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty24");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty24");
            }
        }

        public bool IsInEditMode_StringProperty24
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty24");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty24");
            }
        }

        public bool IsCurrent_StringProperty24
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty24");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty24");
            }
        }

        public int IntProperty24
        {
            get
            {
                return base.GetValue<int>("IntProperty24");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty24");
            }
        }

        public string Foreground_IntProperty24
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty24");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty24");
            }
        }

        public string Background_IntProperty24
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty24");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty24");
            }
        }

        public bool IsEnabled_IntProperty24
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty24");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty24");
            }
        }

        public bool IsReadOnly_IntProperty24
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty24");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty24");
            }
        }

        public bool IsInEditMode_IntProperty24
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty24");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty24");
            }
        }

        public bool IsCurrent_IntProperty24
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty24");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty24");
            }
        }

        public bool BoolProperty24
        {
            get
            {
                return base.GetValue<bool>("BoolProperty24");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty24");
            }
        }

        public string Foreground_BoolProperty24
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty24");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty24");
            }
        }

        public string Background_BoolProperty24
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty24");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty24");
            }
        }

        public bool IsEnabled_BoolProperty24
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty24");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty24");
            }
        }

        public bool IsReadOnly_BoolProperty24
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty24");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty24");
            }
        }

        public bool IsInEditMode_BoolProperty24
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty24");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty24");
            }
        }

        public bool IsCurrent_BoolProperty24
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty24");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty24");
            }
        }

        public string StringProperty25
        {
            get
            {
                return base.GetValue<string>("StringProperty25");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty25");
            }
        }

        public string Foreground_StringProperty25
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty25");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty25");
            }
        }

        public string Background_StringProperty25
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty25");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty25");
            }
        }

        public bool IsEnabled_StringProperty25
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty25");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty25");
            }
        }

        public bool IsReadOnly_StringProperty25
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty25");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty25");
            }
        }

        public bool IsInEditMode_StringProperty25
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty25");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty25");
            }
        }

        public bool IsCurrent_StringProperty25
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty25");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty25");
            }
        }

        public int IntProperty25
        {
            get
            {
                return base.GetValue<int>("IntProperty25");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty25");
            }
        }

        public string Foreground_IntProperty25
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty25");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty25");
            }
        }

        public string Background_IntProperty25
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty25");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty25");
            }
        }

        public bool IsEnabled_IntProperty25
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty25");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty25");
            }
        }

        public bool IsReadOnly_IntProperty25
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty25");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty25");
            }
        }

        public bool IsInEditMode_IntProperty25
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty25");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty25");
            }
        }

        public bool IsCurrent_IntProperty25
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty25");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty25");
            }
        }

        public bool BoolProperty25
        {
            get
            {
                return base.GetValue<bool>("BoolProperty25");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty25");
            }
        }

        public string Foreground_BoolProperty25
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty25");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty25");
            }
        }

        public string Background_BoolProperty25
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty25");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty25");
            }
        }

        public bool IsEnabled_BoolProperty25
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty25");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty25");
            }
        }

        public bool IsReadOnly_BoolProperty25
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty25");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty25");
            }
        }

        public bool IsInEditMode_BoolProperty25
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty25");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty25");
            }
        }

        public bool IsCurrent_BoolProperty25
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty25");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty25");
            }
        }

        public string StringProperty26
        {
            get
            {
                return base.GetValue<string>("StringProperty26");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty26");
            }
        }

        public string Foreground_StringProperty26
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty26");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty26");
            }
        }

        public string Background_StringProperty26
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty26");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty26");
            }
        }

        public bool IsEnabled_StringProperty26
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty26");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty26");
            }
        }

        public bool IsReadOnly_StringProperty26
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty26");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty26");
            }
        }

        public bool IsInEditMode_StringProperty26
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty26");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty26");
            }
        }

        public bool IsCurrent_StringProperty26
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty26");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty26");
            }
        }

        public int IntProperty26
        {
            get
            {
                return base.GetValue<int>("IntProperty26");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty26");
            }
        }

        public string Foreground_IntProperty26
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty26");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty26");
            }
        }

        public string Background_IntProperty26
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty26");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty26");
            }
        }

        public bool IsEnabled_IntProperty26
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty26");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty26");
            }
        }

        public bool IsReadOnly_IntProperty26
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty26");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty26");
            }
        }

        public bool IsInEditMode_IntProperty26
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty26");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty26");
            }
        }

        public bool IsCurrent_IntProperty26
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty26");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty26");
            }
        }

        public bool BoolProperty26
        {
            get
            {
                return base.GetValue<bool>("BoolProperty26");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty26");
            }
        }

        public string Foreground_BoolProperty26
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty26");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty26");
            }
        }

        public string Background_BoolProperty26
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty26");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty26");
            }
        }

        public bool IsEnabled_BoolProperty26
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty26");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty26");
            }
        }

        public bool IsReadOnly_BoolProperty26
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty26");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty26");
            }
        }

        public bool IsInEditMode_BoolProperty26
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty26");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty26");
            }
        }

        public bool IsCurrent_BoolProperty26
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty26");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty26");
            }
        }

        public string StringProperty27
        {
            get
            {
                return base.GetValue<string>("StringProperty27");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty27");
            }
        }

        public string Foreground_StringProperty27
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty27");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty27");
            }
        }

        public string Background_StringProperty27
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty27");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty27");
            }
        }

        public bool IsEnabled_StringProperty27
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty27");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty27");
            }
        }

        public bool IsReadOnly_StringProperty27
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty27");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty27");
            }
        }

        public bool IsInEditMode_StringProperty27
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty27");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty27");
            }
        }

        public bool IsCurrent_StringProperty27
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty27");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty27");
            }
        }

        public int IntProperty27
        {
            get
            {
                return base.GetValue<int>("IntProperty27");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty27");
            }
        }

        public string Foreground_IntProperty27
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty27");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty27");
            }
        }

        public string Background_IntProperty27
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty27");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty27");
            }
        }

        public bool IsEnabled_IntProperty27
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty27");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty27");
            }
        }

        public bool IsReadOnly_IntProperty27
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty27");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty27");
            }
        }

        public bool IsInEditMode_IntProperty27
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty27");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty27");
            }
        }

        public bool IsCurrent_IntProperty27
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty27");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty27");
            }
        }

        public bool BoolProperty27
        {
            get
            {
                return base.GetValue<bool>("BoolProperty27");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty27");
            }
        }

        public string Foreground_BoolProperty27
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty27");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty27");
            }
        }

        public string Background_BoolProperty27
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty27");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty27");
            }
        }

        public bool IsEnabled_BoolProperty27
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty27");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty27");
            }
        }

        public bool IsReadOnly_BoolProperty27
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty27");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty27");
            }
        }

        public bool IsInEditMode_BoolProperty27
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty27");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty27");
            }
        }

        public bool IsCurrent_BoolProperty27
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty27");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty27");
            }
        }

        public string StringProperty28
        {
            get
            {
                return base.GetValue<string>("StringProperty28");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty28");
            }
        }

        public string Foreground_StringProperty28
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty28");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty28");
            }
        }

        public string Background_StringProperty28
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty28");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty28");
            }
        }

        public bool IsEnabled_StringProperty28
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty28");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty28");
            }
        }

        public bool IsReadOnly_StringProperty28
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty28");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty28");
            }
        }

        public bool IsInEditMode_StringProperty28
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty28");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty28");
            }
        }

        public bool IsCurrent_StringProperty28
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty28");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty28");
            }
        }

        public int IntProperty28
        {
            get
            {
                return base.GetValue<int>("IntProperty28");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty28");
            }
        }

        public string Foreground_IntProperty28
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty28");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty28");
            }
        }

        public string Background_IntProperty28
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty28");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty28");
            }
        }

        public bool IsEnabled_IntProperty28
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty28");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty28");
            }
        }

        public bool IsReadOnly_IntProperty28
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty28");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty28");
            }
        }

        public bool IsInEditMode_IntProperty28
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty28");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty28");
            }
        }

        public bool IsCurrent_IntProperty28
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty28");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty28");
            }
        }

        public bool BoolProperty28
        {
            get
            {
                return base.GetValue<bool>("BoolProperty28");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty28");
            }
        }

        public string Foreground_BoolProperty28
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty28");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty28");
            }
        }

        public string Background_BoolProperty28
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty28");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty28");
            }
        }

        public bool IsEnabled_BoolProperty28
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty28");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty28");
            }
        }

        public bool IsReadOnly_BoolProperty28
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty28");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty28");
            }
        }

        public bool IsInEditMode_BoolProperty28
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty28");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty28");
            }
        }

        public bool IsCurrent_BoolProperty28
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty28");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty28");
            }
        }

        public string StringProperty29
        {
            get
            {
                return base.GetValue<string>("StringProperty29");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty29");
            }
        }

        public string Foreground_StringProperty29
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty29");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty29");
            }
        }

        public string Background_StringProperty29
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty29");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty29");
            }
        }

        public bool IsEnabled_StringProperty29
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty29");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty29");
            }
        }

        public bool IsReadOnly_StringProperty29
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty29");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty29");
            }
        }

        public bool IsInEditMode_StringProperty29
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty29");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty29");
            }
        }

        public bool IsCurrent_StringProperty29
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty29");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty29");
            }
        }

        public int IntProperty29
        {
            get
            {
                return base.GetValue<int>("IntProperty29");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty29");
            }
        }

        public string Foreground_IntProperty29
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty29");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty29");
            }
        }

        public string Background_IntProperty29
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty29");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty29");
            }
        }

        public bool IsEnabled_IntProperty29
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty29");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty29");
            }
        }

        public bool IsReadOnly_IntProperty29
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty29");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty29");
            }
        }

        public bool IsInEditMode_IntProperty29
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty29");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty29");
            }
        }

        public bool IsCurrent_IntProperty29
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty29");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty29");
            }
        }

        public bool BoolProperty29
        {
            get
            {
                return base.GetValue<bool>("BoolProperty29");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty29");
            }
        }

        public string Foreground_BoolProperty29
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty29");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty29");
            }
        }

        public string Background_BoolProperty29
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty29");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty29");
            }
        }

        public bool IsEnabled_BoolProperty29
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty29");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty29");
            }
        }

        public bool IsReadOnly_BoolProperty29
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty29");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty29");
            }
        }

        public bool IsInEditMode_BoolProperty29
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty29");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty29");
            }
        }

        public bool IsCurrent_BoolProperty29
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty29");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty29");
            }
        }

        public string StringProperty30
        {
            get
            {
                return base.GetValue<string>("StringProperty30");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty30");
            }
        }

        public string Foreground_StringProperty30
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty30");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty30");
            }
        }

        public string Background_StringProperty30
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty30");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty30");
            }
        }

        public bool IsEnabled_StringProperty30
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty30");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty30");
            }
        }

        public bool IsReadOnly_StringProperty30
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty30");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty30");
            }
        }

        public bool IsInEditMode_StringProperty30
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty30");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty30");
            }
        }

        public bool IsCurrent_StringProperty30
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty30");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty30");
            }
        }

        public int IntProperty30
        {
            get
            {
                return base.GetValue<int>("IntProperty30");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty30");
            }
        }

        public string Foreground_IntProperty30
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty30");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty30");
            }
        }

        public string Background_IntProperty30
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty30");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty30");
            }
        }

        public bool IsEnabled_IntProperty30
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty30");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty30");
            }
        }

        public bool IsReadOnly_IntProperty30
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty30");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty30");
            }
        }

        public bool IsInEditMode_IntProperty30
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty30");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty30");
            }
        }

        public bool IsCurrent_IntProperty30
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty30");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty30");
            }
        }

        public bool BoolProperty30
        {
            get
            {
                return base.GetValue<bool>("BoolProperty30");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty30");
            }
        }

        public string Foreground_BoolProperty30
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty30");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty30");
            }
        }

        public string Background_BoolProperty30
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty30");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty30");
            }
        }

        public bool IsEnabled_BoolProperty30
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty30");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty30");
            }
        }

        public bool IsReadOnly_BoolProperty30
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty30");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty30");
            }
        }

        public bool IsInEditMode_BoolProperty30
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty30");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty30");
            }
        }

        public bool IsCurrent_BoolProperty30
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty30");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty30");
            }
        }

        public string StringProperty31
        {
            get
            {
                return base.GetValue<string>("StringProperty31");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty31");
            }
        }

        public string Foreground_StringProperty31
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty31");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty31");
            }
        }

        public string Background_StringProperty31
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty31");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty31");
            }
        }

        public bool IsEnabled_StringProperty31
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty31");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty31");
            }
        }

        public bool IsReadOnly_StringProperty31
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty31");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty31");
            }
        }

        public bool IsInEditMode_StringProperty31
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty31");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty31");
            }
        }

        public bool IsCurrent_StringProperty31
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty31");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty31");
            }
        }

        public int IntProperty31
        {
            get
            {
                return base.GetValue<int>("IntProperty31");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty31");
            }
        }

        public string Foreground_IntProperty31
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty31");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty31");
            }
        }

        public string Background_IntProperty31
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty31");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty31");
            }
        }

        public bool IsEnabled_IntProperty31
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty31");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty31");
            }
        }

        public bool IsReadOnly_IntProperty31
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty31");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty31");
            }
        }

        public bool IsInEditMode_IntProperty31
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty31");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty31");
            }
        }

        public bool IsCurrent_IntProperty31
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty31");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty31");
            }
        }

        public bool BoolProperty31
        {
            get
            {
                return base.GetValue<bool>("BoolProperty31");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty31");
            }
        }

        public string Foreground_BoolProperty31
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty31");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty31");
            }
        }

        public string Background_BoolProperty31
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty31");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty31");
            }
        }

        public bool IsEnabled_BoolProperty31
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty31");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty31");
            }
        }

        public bool IsReadOnly_BoolProperty31
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty31");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty31");
            }
        }

        public bool IsInEditMode_BoolProperty31
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty31");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty31");
            }
        }

        public bool IsCurrent_BoolProperty31
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty31");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty31");
            }
        }

        public string StringProperty32
        {
            get
            {
                return base.GetValue<string>("StringProperty32");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty32");
            }
        }

        public string Foreground_StringProperty32
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty32");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty32");
            }
        }

        public string Background_StringProperty32
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty32");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty32");
            }
        }

        public bool IsEnabled_StringProperty32
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty32");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty32");
            }
        }

        public bool IsReadOnly_StringProperty32
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty32");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty32");
            }
        }

        public bool IsInEditMode_StringProperty32
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty32");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty32");
            }
        }

        public bool IsCurrent_StringProperty32
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty32");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty32");
            }
        }

        public int IntProperty32
        {
            get
            {
                return base.GetValue<int>("IntProperty32");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty32");
            }
        }

        public string Foreground_IntProperty32
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty32");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty32");
            }
        }

        public string Background_IntProperty32
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty32");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty32");
            }
        }

        public bool IsEnabled_IntProperty32
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty32");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty32");
            }
        }

        public bool IsReadOnly_IntProperty32
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty32");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty32");
            }
        }

        public bool IsInEditMode_IntProperty32
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty32");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty32");
            }
        }

        public bool IsCurrent_IntProperty32
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty32");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty32");
            }
        }

        public bool BoolProperty32
        {
            get
            {
                return base.GetValue<bool>("BoolProperty32");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty32");
            }
        }

        public string Foreground_BoolProperty32
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty32");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty32");
            }
        }

        public string Background_BoolProperty32
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty32");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty32");
            }
        }

        public bool IsEnabled_BoolProperty32
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty32");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty32");
            }
        }

        public bool IsReadOnly_BoolProperty32
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty32");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty32");
            }
        }

        public bool IsInEditMode_BoolProperty32
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty32");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty32");
            }
        }

        public bool IsCurrent_BoolProperty32
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty32");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty32");
            }
        }

        public string StringProperty33
        {
            get
            {
                return base.GetValue<string>("StringProperty33");
            }
            set
            {
                base.SetValue<string>(value, "StringProperty33");
            }
        }

        public string Foreground_StringProperty33
        {
            get
            {
                return base.GetForegroundInternal("Foreground_StringProperty33");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_StringProperty33");
            }
        }

        public string Background_StringProperty33
        {
            get
            {
                return base.GetBackgroundInternal("Background_StringProperty33");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_StringProperty33");
            }
        }

        public bool IsEnabled_StringProperty33
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_StringProperty33");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_StringProperty33");
            }
        }

        public bool IsReadOnly_StringProperty33
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_StringProperty33");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_StringProperty33");
            }
        }

        public bool IsInEditMode_StringProperty33
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_StringProperty33");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_StringProperty33");
            }
        }

        public bool IsCurrent_StringProperty33
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_StringProperty33");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_StringProperty33");
            }
        }

        public int IntProperty33
        {
            get
            {
                return base.GetValue<int>("IntProperty33");
            }
            set
            {
                base.SetValue<int>(value, "IntProperty33");
            }
        }

        public string Foreground_IntProperty33
        {
            get
            {
                return base.GetForegroundInternal("Foreground_IntProperty33");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_IntProperty33");
            }
        }

        public string Background_IntProperty33
        {
            get
            {
                return base.GetBackgroundInternal("Background_IntProperty33");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_IntProperty33");
            }
        }

        public bool IsEnabled_IntProperty33
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_IntProperty33");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_IntProperty33");
            }
        }

        public bool IsReadOnly_IntProperty33
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_IntProperty33");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_IntProperty33");
            }
        }

        public bool IsInEditMode_IntProperty33
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_IntProperty33");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_IntProperty33");
            }
        }

        public bool IsCurrent_IntProperty33
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_IntProperty33");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_IntProperty33");
            }
        }

        public bool BoolProperty33
        {
            get
            {
                return base.GetValue<bool>("BoolProperty33");
            }
            set
            {
                base.SetValue<bool>(value, "BoolProperty33");
            }
        }

        public string Foreground_BoolProperty33
        {
            get
            {
                return base.GetForegroundInternal("Foreground_BoolProperty33");
            }
            set
            {
                base.SetForegroundInternal(value, "Foreground_BoolProperty33");
            }
        }

        public string Background_BoolProperty33
        {
            get
            {
                return base.GetBackgroundInternal("Background_BoolProperty33");
            }
            set
            {
                base.SetBackgroundInternal(value, "Background_BoolProperty33");
            }
        }

        public bool IsEnabled_BoolProperty33
        {
            get
            {
                return base.GetIsEnabledInternal("IsEnabled_BoolProperty33");
            }
            set
            {
                base.SetIsEnabledInternal(value, "IsEnabled_BoolProperty33");
            }
        }

        public bool IsReadOnly_BoolProperty33
        {
            get
            {
                return base.GetIsReadOnlyInternal("IsReadOnly_BoolProperty33");
            }
            set
            {
                base.SetIsReadOnlyInternal(value, "IsReadOnly_BoolProperty33");
            }
        }

        public bool IsInEditMode_BoolProperty33
        {
            get
            {
                return base.GetIsInEditModeInternal("IsInEditMode_BoolProperty33");
            }
            set
            {
                base.SetIsInEditModeInternal(value, "IsInEditMode_BoolProperty33");
            }
        }

        public bool IsCurrent_BoolProperty33
        {
            get
            {
                return base.GetIsCurrentInternal("IsCurrent_BoolProperty33");
            }
            set
            {
                base.SetIsCurrentInternal(value, "IsCurrent_BoolProperty33");
            }
        }

        public MyType(IList<IColumnInfo> columns, int rowNumber) : base(columns, rowNumber)
        {
        }
    }
}
