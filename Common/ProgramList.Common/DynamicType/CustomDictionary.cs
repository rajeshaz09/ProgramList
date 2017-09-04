using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.DynamicType
{
    public class CustomDictionary<T> : Dictionary<string, T>
    {
        CustomDictionary(int capacity) : base(capacity)
        {
        }
    }
}
