using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_partA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Part A
             */

            // Question 1
            Student s1 = new Student("Rahmat", "2320123202", "IART");
            Console.WriteLine("This is the information of 1st student");
            s1.Print();
            Student s2 = new Student("Ilham", "24102546032", "MECHA");

            Console.WriteLine("This is the information of 1st student");
            Console.WriteLine("Name : " + s1.getStudentName());
            Console.WriteLine("ID : " + s1.getStudentID());
            Console.WriteLine("Fac : " + s1.getStudentFac() + "\n");
  
            Console.WriteLine("This is the information of 2nd student");
            Console.WriteLine("Name : " + s2.getStudentName());
            Console.WriteLine("ID : " + s2.getStudentID());
            Console.WriteLine("Fac : " + s2.getStudentFac() + "\n");

            // Question 2
            s1.setStudentName("Ahmad");
            s1.setStudentID("34523123231");
            s1.setStudentFac("BAMT");
            
            Console.WriteLine("This is the updated information of 1st student");
            Console.WriteLine("Name : " + s1.getStudentName());
            Console.WriteLine("ID : " + s1.getStudentID());
            Console.WriteLine("Fac : " + s1.getStudentFac() + "\n");

            // Question 3
            
            Console.WriteLine("This is the information of 1st student");
            s1.Print();
            Console.WriteLine("This is the information of 2nd student");
            s2.Print();

            /*
             * Part B
             */ 

            // Question 2
            Lecturer lect1 = new Lecturer("Dr Mohd Hafiz Bin Abdullah", "522032");

            Console.WriteLine("This is the information of 1st lecturer");
            lect1.Print();
        }
    }
}
