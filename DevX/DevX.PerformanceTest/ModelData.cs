using System.Collections.Generic;
namespace DevX.PerformanceTest
{
    public class ModelData : Dictionary<string, CellInfo>
    {
        public ModelData(int capacity): base(capacity) { }
    }

}
