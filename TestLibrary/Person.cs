using System;
using DynamicInputs;

namespace TestLibrary 
{
    public class Person {
        [DynamicInput("First name")]
        public string FirstName { get; set; } = string.Empty;
        
        [DynamicInput("Middle name")]
        public string MiddleName { get; set; } = string.Empty;
        
        [DynamicInput("Last name")]
        public string LastName { get; set; } = string.Empty;

        [DynamicInput]
        public int Age { get; set; } = 0;
        
        [DynamicInput]
        public Gender Gender { get; set; } = Gender.Male;

        [DynamicInput("Is a CEO")]
        public bool IsCEO { get; set; } = true;

        public Person() { 
        }
    }

    public enum Gender { 
        Male,
        Female
    }
}
