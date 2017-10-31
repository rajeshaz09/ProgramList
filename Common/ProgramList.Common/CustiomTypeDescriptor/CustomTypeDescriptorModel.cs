namespace ProgramList.Common.DynamicType
{
    public class CustomTypeDescriptorModel: CustomTypeDescriptorBaseModel
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

    }
}
