using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assesment
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            *  LAB ASSESSMENT 1
            * 
            * Name : Mohamed Hazim Bin Mohamed Gharib
            * ID : 50212116040
            * Group : IART
            * 
            * Purpose : To show the use of inheritance and polymorphism in Object
            *           Oriented Design.
             *          This program will has Human class as base class and Student
             *          class as derived class that will inherits the base class.
             *          Student class will override the Display method from
             *          the Human class.
             *          
             *          The information that will be use is :-
             *              1) Name of the student
             *              2) Gender of the student
             *              3) Race of the student
             *              4) Age of the student
             *              5) ID of the student
             *          
            */

            /* Create a student object
                * Variables to initiate:
                *      Inherits from human class
                *          - name(string)
                *          - gender(string)
                *          - race(string)
                *          - age(int)
                *      From student class
                *          - id(string)
            */
            Student s1 = new Student("Hazim", "Male", "Malay", 24, "50212116040");

            Console.WriteLine("Lab Assessment 1\n");

            // Call the display method of the object to display all the variables
            s1.Display();
        }
    }
}
