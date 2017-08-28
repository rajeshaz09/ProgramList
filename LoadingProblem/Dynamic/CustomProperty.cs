using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Dynamic
{
    public struct CustomProperty<T>
    {
        public T Value { get; set; }
        public CustomProperty(T value) : this()
        {
            Value = value;
        }

    }
}
