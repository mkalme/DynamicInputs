using System;
using System.Reflection;
using System.Windows.Forms;

namespace DynamicInputs {
    public class InputComboBox : ComboBox, IDynamicControl {
        public InputComboBox() { 
        }

        public static InputComboBox FromProperty(PropertyInfo info, object obj) {
            InputComboBox comboBox = new InputComboBox();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var values = Enum.GetValues(info.GetValue(obj).GetType());
            foreach (var value in values) {
                comboBox.Items.Add(value);
            }

            comboBox.SelectedItem = info.GetValue(obj);

            return comboBox;
        }

        public void SetValueToProperty(PropertyInfo info, object obj) {
            info.SetValue(obj, SelectedItem);
        }
    }
}
