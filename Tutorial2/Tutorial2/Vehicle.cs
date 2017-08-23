using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class Vehicle
    {

        /*
         * Question 2
         * 
         * a. class Car : Vehicle
         *    class Lorry : Vehicle
         * 
         * b. 5 members consist of 3 private instance variable, 1 constructor and 1 method.
         * c. 7 members consist of 1 private instance variable, 1 constructor and 5 members from base class.
         * d. 7 members consist of 1 private instance variable, 1 constructor and 5 members from base class.
         * e. Answer in derived classes : Car and Lorry
         * 
         */

        protected string plateNumber;
        protected string chassisNumber;
        protected string color;

        public Vehicle(string pN, string cN, string c)
        {
            plateNumber = pN;
            chassisNumber = cN;
            color = c;
        }

        public virtual void Print()
        {
            Console.WriteLine("Plate Number : " + plateNumber);
            Console.WriteLine("Chassis Number : " + chassisNumber);
            Console.WriteLine("Color : " + color);
        }
    }
}
