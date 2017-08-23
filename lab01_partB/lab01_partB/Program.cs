using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab01_partB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create 2 student object and 1 lecturer object
            Student s1 = new Student("Hazim", "930523015799", "Male", "50212116040", "IART");
            Student s2 = new Student("Safwan", "9303248103248", "Female", "50239421", "IART");
            Lecturer l1 = new Lecturer("Mahmud", "1234", "Female", "4567");


            // Use the 3 object created above to create 1 project object
            Project p1 = new Project(l1, s1, s2);

            // Print out the result
            p1.Print();
            
        }
    }
}
