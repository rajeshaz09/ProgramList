using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramList.Common.DynamicType
{
    public class CustomTypeProviderModel : CustomTypeProviderBaseModel<CustomTypeProviderModel>
    {
        private int _myInt;
        public int MyInt
        {
            get
            {
                return _myInt;
            }
            set
            {
                SetProperty(ref _myInt, value);
            }

        }
        public CustomTypeProviderModel(List<CustomTypeProviderPropertyInfo> properties) : base(properties)
        {

        }
    }
}
