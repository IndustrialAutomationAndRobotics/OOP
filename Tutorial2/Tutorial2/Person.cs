using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class Person
    {
        // the instance variable
        private string name;
        private string ic;
        // takes the object of other class as variable(Composition)
        private BirthDate birthday;

        // the constructor
        public Person(string n, string ic, BirthDate bd) {

            this.name = n;
            this.ic = ic;
            this.birthday = bd;
        }


        // Method use to print out variable
        public void Print() {

            // Directly call the instance variable to display it
            Console.WriteLine("Name : " + name);
            Console.WriteLine("IC : " + ic);
            // Since this part use object, need to use the getter method from that class to get the date(Composition)
            Console.WriteLine("bd : " + birthday.getDate());
        }
    }
}
