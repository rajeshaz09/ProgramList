using ProgramList.Common.Models;
using System;
using Telerik.Windows.Controls;

namespace ProgramList.TelerikPOC.Columns
{
    public sealed class ImageColumnInfo: GridViewImageColumn, IColumnInfo
    {
        public ImageColumnInfo(string header, Type dataType, bool isVisible, bool isReadOnly, bool isEnabled, bool isSelected)
        {
            this.ApplyDefaultSettings(header, dataType, isVisible, isReadOnly, isEnabled, isSelected);
            //ImageStretch = System.Windows.Media.Stretch.None;
            ImageWidth = 50;
            ImageHeight = 50;
        }
    }
}
