using System;
using System.Reflection;

namespace DynamicInputs {
    public interface IDynamicControl {
        void SetValueToProperty(PropertyInfo info, object obj);
    }
}
