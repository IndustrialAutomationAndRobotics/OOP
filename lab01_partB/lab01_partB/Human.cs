using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab01_partB
{
    // The base class
    class Human
    {
        // The variables
        private string name;
        private string ic;
        private string gender;

        // default constructor
        public Human() {

            name = "";
            ic = "";
            gender = "";
        }

        // Constructor with three constructor
        public Human(string name, string ic, string gender) {

            this.name = name;
            this.ic = ic;
            this.gender = gender;
        }

        // Method to print out respective variable
        // virtual indicates this method will be override by derived class(polymorphism)
        public virtual void Print() {

            Console.WriteLine("Name : " + name);
            Console.WriteLine("IC : " + ic);
            Console.WriteLine("Gendar : " + gender);
            
        }

        // getter method
        public string getName() {
            return name;
        }

        public string getIC() {
            return ic;
        }

        public string getGender() {
            return gender;
        }
    }
}
