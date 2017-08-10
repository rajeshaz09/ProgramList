using System;
using System.Collections.Generic;
using System.ComponentModel;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Models
{
    public class NormalModel : ListItemBase, INotifyPropertyChanged
    {
        public NormalModel(IList<GridViewBoundColumnBase> columns, int rowNumber) : base(columns, rowNumber)
        {
        }
        public string StringProperty
        {
            get
            {
                return GetValue<string>();
            }
            set
            {
                SetValue(value);
            }
        }

        public int IntProperty
        {
            get
            {
                return GetValue<int>();
            }
            set
            {
                SetValue(value);
            }
        }

        public bool BoolProperty
        {
            get
            {
                return GetValue<bool>();
            }
            set
            {
                SetValue(value);
            }
        }

        public bool IsEnabled_StringProperty
        {
            get
            {
                return GetIsEnabledInternal();
            }
            set
            {
                SetIsEnabledInternal(value);
            }
        }
        public bool IsEnabled_IntProperty
        {
            get
            {
                return GetIsEnabledInternal();
            }
            set
            {
                SetIsEnabledInternal(value);
            }
        }
        public bool IsEnabled_BoolProperty
        {
            get
            {
                return GetIsEnabledInternal();
            }
            set
            {
                SetIsEnabledInternal(value);
            }
        }
    }
}

