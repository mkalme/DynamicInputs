using System;
using System.Windows.Forms;
using System.Reflection;

namespace DynamicInputs {
    public class InputNumericUpDown : NumericUpDown, IDynamicControl {
        public InputNumericUpDown() {
            Width = 100;
        }

        public static InputNumericUpDown FromProperty(PropertyInfo info, object obj) {
            InputNumericUpDown numbericUpDown = new InputNumericUpDown();

            numbericUpDown.Value = (int)info.GetValue(obj);

            return numbericUpDown;
        }
        public void SetValueToProperty(PropertyInfo info, object obj) {
            info.SetValue(obj, (int)Value);
        }
    }
}
