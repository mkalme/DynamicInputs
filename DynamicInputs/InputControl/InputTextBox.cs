using System;
using System.Windows.Forms;
using System.Reflection;

namespace DynamicInputs {
    public class InputTextBox : TextBox, IDynamicControl {
        public InputTextBox() {
            Dock = DockStyle.Fill;
        }

        public static InputTextBox FromProperty(PropertyInfo info, object obj) {
            InputTextBox textBox = new InputTextBox();

            textBox.Text = (string)info.GetValue(obj);

            return textBox;
        }
        public void SetValueToProperty(PropertyInfo info, object obj) {
            info.SetValue(obj, Text);
        }
    }
}
