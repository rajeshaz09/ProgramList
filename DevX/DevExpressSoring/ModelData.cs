using System.Collections.Generic;

namespace DevExpressSoring
{
    public class ModelData : Dictionary<string, CellInfo>
    {
        public ModelData(int capacity) : base(capacity) { }
    }
}
