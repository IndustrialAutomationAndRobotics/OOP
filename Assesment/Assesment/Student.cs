using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assesment
{
            /*
             *  LAB ASSESSMENT 1
             * 
             * Name : Mohamed Hazim Bin Mohamed Gharib
             * ID : 50212116040
             * Group : IART
             * 
             */

    // This is the derived class. This class inherits Human class.
    class Student : Human
    {
        // Class instance variable
        private string id;

        // Constructor with 5 parameters to instantiate all the variables
        // The first 4 parameters comes from the base class.
        public Student(string name, string gender, string race, int age, string id) : base(name, gender, race, age) {

            this.id = id;
        }


        // Method to display all the variables
        // This method override the display method in Human Class
        // We has to apply polymorphism by adding override keyword to this method's header
        public override void Display()
        {
            // Call the display method from the base class
            base.Display();
            Console.WriteLine("ID : " + id); // display id
        }
    }
}
