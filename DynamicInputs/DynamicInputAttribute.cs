using System;

namespace DynamicInputs {
    public class DynamicInputAttribute : Attribute {
        public string Name { get; set; }

        public DynamicInputAttribute() {
        }
        public DynamicInputAttribute(string name) {
            Name = name;
        }
    }
}
