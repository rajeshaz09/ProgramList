using ProgramList.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Jeeves.CustomModels
{
    public class MyType : ListItemBase, INotifyPropertyChanged
    {
        private string _StringProperty;

        private int _IntProperty;

        private bool _BoolProperty;

        private int _DropDown;

        private string _Button1;

        private string _Button2;

        private string _DateTimeProperty;

        private string _DateProperty;

        private string _TimeProperty;

        private string _StringProperty1;

        private int _IntProperty1;

        private bool _BoolProperty1;

        private string _StringProperty2;

        private int _IntProperty2;

        private bool _BoolProperty2;

        private string _StringProperty3;

        private int _IntProperty3;

        private bool _BoolProperty3;

        private string _StringProperty4;

        private int _IntProperty4;

        private bool _BoolProperty4;

        private string _StringProperty5;

        private int _IntProperty5;

        private bool _BoolProperty5;

        private string _StringProperty6;

        private int _IntProperty6;

        private bool _BoolProperty6;

        private string _StringProperty7;

        private int _IntProperty7;

        private bool _BoolProperty7;

        private string _StringProperty8;

        private int _IntProperty8;

        private bool _BoolProperty8;

        private string _StringProperty9;

        private int _IntProperty9;

        private bool _BoolProperty9;

        private string _StringProperty10;

        private int _IntProperty10;

        private bool _BoolProperty10;

        private string _StringProperty11;

        private int _IntProperty11;

        private bool _BoolProperty11;

        private string _StringProperty12;

        private int _IntProperty12;

        private bool _BoolProperty12;

        private string _StringProperty13;

        private int _IntProperty13;

        private bool _BoolProperty13;

        private string _StringProperty14;

        private int _IntProperty14;

        private bool _BoolProperty14;

        private string _StringProperty15;

        private int _IntProperty15;

        private bool _BoolProperty15;

        private string _StringProperty16;

        private int _IntProperty16;

        private bool _BoolProperty16;

        private string _StringProperty17;

        private int _IntProperty17;

        private bool _BoolProperty17;

        private string _StringProperty18;

        private int _IntProperty18;

        private bool _BoolProperty18;

        private string _StringProperty19;

        private int _IntProperty19;

        private bool _BoolProperty19;

        private string _StringProperty20;

        private int _IntProperty20;

        private bool _BoolProperty20;

        private string _StringProperty21;

        private int _IntProperty21;

        private bool _BoolProperty21;

        private string _StringProperty22;

        private int _IntProperty22;

        private bool _BoolProperty22;

        private string _StringProperty23;

        private int _IntProperty23;

        private bool _BoolProperty23;

        private string _StringProperty24;

        private int _IntProperty24;

        private bool _BoolProperty24;

        private string _StringProperty25;

        private int _IntProperty25;

        private bool _BoolProperty25;

        private string _StringProperty26;

        private int _IntProperty26;

        private bool _BoolProperty26;

        private string _StringProperty27;

        private int _IntProperty27;

        private bool _BoolProperty27;

        private string _StringProperty28;

        private int _IntProperty28;

        private bool _BoolProperty28;

        private string _StringProperty29;

        private int _IntProperty29;

        private bool _BoolProperty29;

        private string _StringProperty30;

        private int _IntProperty30;

        private bool _BoolProperty30;

        public string StringProperty
        {
            get
            {
                return this._StringProperty;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty, value, "StringProperty");
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
                return this._IntProperty;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty, value, "IntProperty");
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
                return this._BoolProperty;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty, value, "BoolProperty");
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

        public int DropDown
        {
            get
            {
                return this._DropDown;
            }
            set
            {
                base.SetProperty<int>(ref this._DropDown, value, "DropDown");
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
                return this._Button1;
            }
            set
            {
                base.SetProperty<string>(ref this._Button1, value, "Button1");
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
                return this._Button2;
            }
            set
            {
                base.SetProperty<string>(ref this._Button2, value, "Button2");
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

        public string DateTimeProperty
        {
            get
            {
                return this._DateTimeProperty;
            }
            set
            {
                base.SetProperty<string>(ref this._DateTimeProperty, value, "DateTimeProperty");
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

        public string DateProperty
        {
            get
            {
                return this._DateProperty;
            }
            set
            {
                base.SetProperty<string>(ref this._DateProperty, value, "DateProperty");
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

        public string TimeProperty
        {
            get
            {
                return this._TimeProperty;
            }
            set
            {
                base.SetProperty<string>(ref this._TimeProperty, value, "TimeProperty");
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
                return this._StringProperty1;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty1, value, "StringProperty1");
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
                return this._IntProperty1;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty1, value, "IntProperty1");
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
                return this._BoolProperty1;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty1, value, "BoolProperty1");
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
                return this._StringProperty2;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty2, value, "StringProperty2");
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
                return this._IntProperty2;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty2, value, "IntProperty2");
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
                return this._BoolProperty2;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty2, value, "BoolProperty2");
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
                return this._StringProperty3;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty3, value, "StringProperty3");
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
                return this._IntProperty3;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty3, value, "IntProperty3");
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
                return this._BoolProperty3;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty3, value, "BoolProperty3");
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
                return this._StringProperty4;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty4, value, "StringProperty4");
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
                return this._IntProperty4;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty4, value, "IntProperty4");
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
                return this._BoolProperty4;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty4, value, "BoolProperty4");
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
                return this._StringProperty5;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty5, value, "StringProperty5");
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
                return this._IntProperty5;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty5, value, "IntProperty5");
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
                return this._BoolProperty5;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty5, value, "BoolProperty5");
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
                return this._StringProperty6;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty6, value, "StringProperty6");
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
                return this._IntProperty6;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty6, value, "IntProperty6");
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
                return this._BoolProperty6;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty6, value, "BoolProperty6");
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
                return this._StringProperty7;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty7, value, "StringProperty7");
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
                return this._IntProperty7;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty7, value, "IntProperty7");
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
                return this._BoolProperty7;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty7, value, "BoolProperty7");
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
                return this._StringProperty8;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty8, value, "StringProperty8");
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
                return this._IntProperty8;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty8, value, "IntProperty8");
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
                return this._BoolProperty8;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty8, value, "BoolProperty8");
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
                return this._StringProperty9;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty9, value, "StringProperty9");
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
                return this._IntProperty9;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty9, value, "IntProperty9");
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
                return this._BoolProperty9;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty9, value, "BoolProperty9");
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
                return this._StringProperty10;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty10, value, "StringProperty10");
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
                return this._IntProperty10;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty10, value, "IntProperty10");
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
                return this._BoolProperty10;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty10, value, "BoolProperty10");
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
                return this._StringProperty11;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty11, value, "StringProperty11");
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
                return this._IntProperty11;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty11, value, "IntProperty11");
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
                return this._BoolProperty11;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty11, value, "BoolProperty11");
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
                return this._StringProperty12;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty12, value, "StringProperty12");
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
                return this._IntProperty12;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty12, value, "IntProperty12");
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
                return this._BoolProperty12;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty12, value, "BoolProperty12");
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
                return this._StringProperty13;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty13, value, "StringProperty13");
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
                return this._IntProperty13;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty13, value, "IntProperty13");
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
                return this._BoolProperty13;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty13, value, "BoolProperty13");
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
                return this._StringProperty14;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty14, value, "StringProperty14");
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
                return this._IntProperty14;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty14, value, "IntProperty14");
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
                return this._BoolProperty14;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty14, value, "BoolProperty14");
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
                return this._StringProperty15;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty15, value, "StringProperty15");
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
                return this._IntProperty15;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty15, value, "IntProperty15");
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
                return this._BoolProperty15;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty15, value, "BoolProperty15");
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
                return this._StringProperty16;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty16, value, "StringProperty16");
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
                return this._IntProperty16;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty16, value, "IntProperty16");
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
                return this._BoolProperty16;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty16, value, "BoolProperty16");
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
                return this._StringProperty17;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty17, value, "StringProperty17");
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
                return this._IntProperty17;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty17, value, "IntProperty17");
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
                return this._BoolProperty17;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty17, value, "BoolProperty17");
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
                return this._StringProperty18;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty18, value, "StringProperty18");
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
                return this._IntProperty18;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty18, value, "IntProperty18");
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
                return this._BoolProperty18;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty18, value, "BoolProperty18");
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
                return this._StringProperty19;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty19, value, "StringProperty19");
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
                return this._IntProperty19;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty19, value, "IntProperty19");
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
                return this._BoolProperty19;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty19, value, "BoolProperty19");
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
                return this._StringProperty20;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty20, value, "StringProperty20");
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
                return this._IntProperty20;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty20, value, "IntProperty20");
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
                return this._BoolProperty20;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty20, value, "BoolProperty20");
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
                return this._StringProperty21;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty21, value, "StringProperty21");
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
                return this._IntProperty21;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty21, value, "IntProperty21");
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
                return this._BoolProperty21;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty21, value, "BoolProperty21");
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
                return this._StringProperty22;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty22, value, "StringProperty22");
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
                return this._IntProperty22;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty22, value, "IntProperty22");
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
                return this._BoolProperty22;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty22, value, "BoolProperty22");
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
                return this._StringProperty23;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty23, value, "StringProperty23");
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
                return this._IntProperty23;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty23, value, "IntProperty23");
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
                return this._BoolProperty23;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty23, value, "BoolProperty23");
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
                return this._StringProperty24;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty24, value, "StringProperty24");
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
                return this._IntProperty24;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty24, value, "IntProperty24");
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
                return this._BoolProperty24;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty24, value, "BoolProperty24");
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
                return this._StringProperty25;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty25, value, "StringProperty25");
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
                return this._IntProperty25;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty25, value, "IntProperty25");
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
                return this._BoolProperty25;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty25, value, "BoolProperty25");
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
                return this._StringProperty26;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty26, value, "StringProperty26");
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
                return this._IntProperty26;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty26, value, "IntProperty26");
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
                return this._BoolProperty26;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty26, value, "BoolProperty26");
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
                return this._StringProperty27;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty27, value, "StringProperty27");
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
                return this._IntProperty27;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty27, value, "IntProperty27");
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
                return this._BoolProperty27;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty27, value, "BoolProperty27");
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
                return this._StringProperty28;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty28, value, "StringProperty28");
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
                return this._IntProperty28;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty28, value, "IntProperty28");
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
                return this._BoolProperty28;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty28, value, "BoolProperty28");
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
                return this._StringProperty29;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty29, value, "StringProperty29");
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
                return this._IntProperty29;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty29, value, "IntProperty29");
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
                return this._BoolProperty29;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty29, value, "BoolProperty29");
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
                return this._StringProperty30;
            }
            set
            {
                base.SetProperty<string>(ref this._StringProperty30, value, "StringProperty30");
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
                return this._IntProperty30;
            }
            set
            {
                base.SetProperty<int>(ref this._IntProperty30, value, "IntProperty30");
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
                return this._BoolProperty30;
            }
            set
            {
                base.SetProperty<bool>(ref this._BoolProperty30, value, "BoolProperty30");
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

        public MyType(IList<IColumnInfo> columns, int rowNumber) : base(columns, rowNumber)
        {
        }
    }
}
