using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DynamicInputs {
    public class DynamicForm {
        public static T Serialize<T>() where T : new() {
            return Serialize(new T());
        }
        public static T Serialize<T>(T obj) where T : new() {
            List<Entry> entries = Entry.GetEntriesFromGenerics(obj);

            Form form = CreateForm(entries);
            form.ShowDialog();

            return obj;
        }

        private static Form CreateForm(List<Entry> entries) {
            return new DynamicInputForm(entries);
        }
    }

    public class Entry {
        public object Object { get; set; }
        public PropertyInfo Property { get; set; }
        public Control Control { get; set; }
        public DynamicInputAttribute Attribute { get; set; }

        public Entry(PropertyInfo property, object obj, Control control, DynamicInputAttribute attribute) {
            Object = obj;
            Property = property;
            Control = control;
            Attribute = attribute;
        }

        public string GetName() {
            if (!string.IsNullOrEmpty(Attribute.Name)) return Attribute.Name;
            return Property.Name;
        }
        public void UpdateValue() {
            if (!(Control is IDynamicControl)) return;

            (Control as IDynamicControl).SetValueToProperty(Property, Object);
        }

        public static List<Entry> GetEntriesFromGenerics<T>(T obj) {
            List<Entry> entries = new List<Entry>();

            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (var property in properties) {

                DynamicInputAttribute attribute;
                if(!property.IsDynamicInput(out attribute)) continue;

                Control control = property.GetControl(obj);
                if (control == null) continue;

                entries.Add(new Entry(property, obj, control, attribute));
            }

            return entries;
        }
    }
}
