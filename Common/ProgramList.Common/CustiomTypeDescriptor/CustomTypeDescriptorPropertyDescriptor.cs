using System;
using System.ComponentModel;

namespace ProgramList.POC.Models
{
    public class CustomPropertyDescriptor<T> : PropertyDescriptor
    {
        private Type propertyType;
        private Type componentType;
        T propertyValue;

        public CustomPropertyDescriptor(string propertyName, Type componentType)
            : base(propertyName, new Attribute[] { })
        {
            this.propertyType = typeof(T);
            this.componentType = componentType;
        }

        public override bool CanResetValue(object component) { return true; }
        public override Type ComponentType { get { return componentType; } }

        public override object GetValue(object component)
        {
            return propertyValue;
        }

        public override bool IsReadOnly { get { return false; } }
        public override Type PropertyType { get { return propertyType; } }
        public override void ResetValue(object component) { SetValue(component, default(T)); }
        public override void SetValue(object component, object value)
        {
            if (!value.GetType().IsAssignableFrom(propertyType))
            {
                throw new System.Exception("Invalid type to assign");
            }

            propertyValue = (T)value;
            OnValueChanged(component, new EventArgs());
        }

        public override bool ShouldSerializeValue(object component) { return true; }
    }
}
