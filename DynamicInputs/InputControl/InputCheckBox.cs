using System;
using System.Reflection;
using System.Windows.Forms;

namespace DynamicInputs {
    public class InputCheckBox : CheckBox, IDynamicControl {
        public InputCheckBox() { 
        }

        public static InputCheckBox FromProperty(PropertyInfo info, object obj) {
            InputCheckBox checkBox = new InputCheckBox();

            checkBox.Checked = (bool)info.GetValue(obj);

            return checkBox;
        }
        public void SetValueToProperty(PropertyInfo info, object obj) {
            info.SetValue(obj, Checked);
        }
    }
}
