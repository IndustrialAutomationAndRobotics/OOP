using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab01_partB
{
    

    class Student : Human
    {
        private string id;
        private string fac;

        public Student(string name, string ic, string gender, string id, string fac) : base (name, ic, gender) { 
        
            this.id = id;
            this.fac = fac;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Faculty: " + fac + "\n");
        }

        public string getID() {

            return id;
        }

        public string getFac() {

            return fac;
        }
    }
}
