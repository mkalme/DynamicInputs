using System;
using System.Windows.Forms;
using DynamicInputs;
using TestLibrary;

namespace Test_UI {
    class Program {
        static void Main(string[] args) {
            Application.EnableVisualStyles();

            Person person = DynamicForm.Serialize<Person>();

            Console.ReadLine();
        }
    }
}
