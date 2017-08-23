using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab01_partB
{
    // Implementation of composition
    class Project
    {
        // Rather than standard variable we always use, we use object from other class as variable(Composition)
        // Object from Lecturer class
        private Lecturer Supervisor;

        // Object from Student class
        private Student StudentOne;
        private Student StudentTwo;

        // Constructor with one argument
        public Project(Lecturer Supervisor) {

            this.Supervisor = Supervisor;
        }

        // Constructor with two argument
        public Project(Lecturer Supervisor, Student StudentOne) {

            this.Supervisor = Supervisor;
            this.StudentOne = StudentOne;
        }

        // Constructor with three argument
        public Project(Lecturer Supervisor, Student StudentOne, Student StudentTwo) {

            this.Supervisor = Supervisor;
            this.StudentOne = StudentOne;
            this.StudentTwo = StudentTwo;
        }

        // The method to print out respective variable
        // Use of get method is necessary here. To call the variable from respective objects(class instance).
        public void Print() {

            Console.WriteLine("The Supervisor");
            Console.WriteLine("Name : " + Supervisor.getName());
            Console.WriteLine("IC : " + Supervisor.getIC());
            Console.WriteLine("Gender : " + Supervisor.getGender());
            Console.WriteLine("ID : " + Supervisor.getID() + "\n");
            Console.WriteLine("The First Student");
            Console.WriteLine("Name : " + StudentOne.getName());
            Console.WriteLine("IC: " + StudentOne.getIC());
            Console.WriteLine("Gender : " + StudentOne.getGender());
            Console.WriteLine("ID: " + StudentOne.getID());
            Console.WriteLine("Faculty: " + StudentOne.getFac() + "\n");
            Console.WriteLine("The Second Student");
            Console.WriteLine("Name : " + StudentTwo.getName());
            Console.WriteLine("IC: " + StudentTwo.getIC());
            Console.WriteLine("Gender : " + StudentTwo.getGender());
            Console.WriteLine("ID: " + StudentTwo.getID());
            Console.WriteLine("Faculty: " + StudentTwo.getFac() + "\n");
        }
    }
}
