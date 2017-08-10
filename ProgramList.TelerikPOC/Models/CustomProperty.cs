namespace ProgramList.TelerikPOC.Models
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
