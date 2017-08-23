using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class ComplexNumber
    {
        // This class demonstrate the use of operator overloading

        // Declare private instance variable
        private int real;
        private int imaginary;

        // Default constructor that initialize the instance variable
        public ComplexNumber() {

            real = 0;
            imaginary = 0;
        }

        // Constructor with 2 argument
        public ComplexNumber(int r, int i) {

            real = r;
            imaginary = i;
        }

        // Print out method
        public void Print() {

            Console.WriteLine("(" + real + " , " + imaginary + "i)");
        }

        // These method below shows how to use operator overloading
        public static ComplexNumber operator +(ComplexNumber lhs, ComplexNumber rhs) {

            ComplexNumber c = new ComplexNumber();
            c.real = lhs.real + rhs.real;
            c.imaginary = lhs.imaginary + rhs.imaginary;
            return (c);
        }

        public static ComplexNumber operator -(ComplexNumber lhs, ComplexNumber rhs) {

            ComplexNumber c = new ComplexNumber();
            c.real = lhs.real - rhs.real;
            c.imaginary = lhs.imaginary - rhs.imaginary;
            return c;
        }

        public static ComplexNumber operator *(ComplexNumber lhs, ComplexNumber rhs) {

            ComplexNumber c = new ComplexNumber();
            c.real = lhs.real * rhs.real - lhs.imaginary * rhs.imaginary;
            c.imaginary = lhs.real * rhs.imaginary + lhs.imaginary * rhs.real;
            return c;
        }

        public static bool operator ==(ComplexNumber lhs, ComplexNumber rhs) {

            bool result;
            if (lhs.real == rhs.real && lhs.imaginary == rhs.imaginary)
                result = true;
            else
                result = false;
            return result;
        }

        public static bool operator !=(ComplexNumber lhs, ComplexNumber rhs) {

            bool result;
            if (lhs.real != rhs.real && lhs.imaginary != rhs.imaginary)
                result = true;
            else
                result = false;
            return result;
        }
      

    }
}
