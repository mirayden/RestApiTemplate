using System;
using System.Diagnostics;
using System.Reflection;

namespace Domain
{
    public class Media
    {
        private bool _finalized = false;

        public void Write<T>(string name, T value)
        {
            if (_finalized)
            {
                throw new InvalidOperationException("Cannot write, the object is already finalized.");
            }

            PropertyInfo propertyInfo = this.GetType().GetProperty(name);
            propertyInfo.SetValue(this, Convert.ChangeType(value, propertyInfo.PropertyType), null);

        }

        public virtual void Finalize()
        {
            _finalized = true;
        }   
    }
}