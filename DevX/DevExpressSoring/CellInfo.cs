using System;

namespace DevExpressSoring
{
    public class CellInfo
    {
        public Object Data { get; set; }

        public override string ToString()
        {
            return Data?.ToString();
        }
    }
}
