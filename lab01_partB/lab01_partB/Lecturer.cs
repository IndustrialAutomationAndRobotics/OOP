using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab01_partB
{
    // The derived class (Inherits Human Class)
    class Lecturer : Human
    {
        // the variable
        private string id;

        // Constructor with 4 argument. 3 of them from the base class
        public Lecturer(string name, string ic, string gender, string id) : base (name, ic, gender) {

            this.id = id;
        }

        // This method override the Print method from base class (Polymorphism)
        public override void Print()
        {
            base.Print(); // The print method from base class
            Console.WriteLine("ID: " + id + "\n");
        }

        // getter method
        public string getID() {

            return id;
        }
    }
}
