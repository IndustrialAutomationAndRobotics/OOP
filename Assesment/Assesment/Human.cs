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

    // This is the base class. Will be inherit by Student class.
    class Human
    {
        // Class instance variables
        private string name;
        private string gender;
        private string race;
        private int age;

        // Constructor with 4 parameters to instantiate all the variables
        public Human(string name, string gender, string race, int age) {

            this.name = name;
            this.gender = gender;
            this.race = race;
            this.age = age;
        }

        // Method to display all the variables
        // Since this method will be override by Student class.
        // We has to apply polymorphism by adding virtual keyword to this method's header
        public virtual void Display() {

            Console.WriteLine("Name : " + name); // display name
            Console.WriteLine("Gender : " + gender); // display gender
            Console.WriteLine("Race : " + race); // display race
            Console.WriteLine("Age : " + age); // display age
        }
    }
}
