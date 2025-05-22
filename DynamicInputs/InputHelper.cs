using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DynamicInputs {
    public static class InputHelper {
        public static Control GetControl(this PropertyInfo property, object obj) {
            Type type = property.PropertyType;

            if (type == typeof(string)) {
                return InputTextBox.FromProperty(property, obj);
            } else if (type == typeof(int)) {
                return InputNumericUpDown.FromProperty(property, obj);
            } else if (type == typeof(bool)) {
                return InputCheckBox.FromProperty(property, obj);
            }else if(type.IsEnum){
                return InputComboBox.FromProperty(property, obj);
            }

            return null;
        }
        public static bool IsDynamicInput(this PropertyInfo property, out DynamicInputAttribute attribute) {
            IEnumerable<Attribute> attributes = property.GetCustomAttributes();

            attribute = null;
            if (attributes.Count() < 1) return false;

            Attribute att = attributes.First();
            if (att.GetType() != typeof(DynamicInputAttribute)) return false;

            attribute = (DynamicInputAttribute)att;
            return true;
        }
    }
}
