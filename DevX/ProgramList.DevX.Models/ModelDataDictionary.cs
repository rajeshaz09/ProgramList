using System;
using System.Collections.Generic;

namespace ProgramList.DevX.Models
{
	[Serializable]
	public class ModelDataDictionary : Dictionary<string, CellInfo>
	{
		public ModelDataDictionary(int capacity) : base(capacity) { }
	}
}
