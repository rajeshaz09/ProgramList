using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.TelerikPOC.Models
{
    public class ChartPoint : ModelBase
    {
        public const string ValueProperty = nameof(Value);
        public const string CategoryProperty = nameof(Category);
        public ChartPoint(double value, string category)
        {
            _value = value;
            _category = category;
        }

        private double _value;
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                SetProperty(ref _value, value);
            }
        }
        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                SetProperty(ref _category, value);
            }
        }
    }
}
