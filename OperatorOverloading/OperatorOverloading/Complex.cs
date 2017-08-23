using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class Complex
    {
        // This class demonstrates the use of arithmetic without operator overloading
        private int real;
        private int imaginary;

        public Complex() {

            real = 0;
            imaginary = 0;
        }

        public Complex(int r, int i) {

            real = r;
            imaginary = i;
        }

        public void Print() {

            Console.WriteLine("(" + real + " , " + imaginary + "i)");
        }

        public Complex Add(Complex c) {

            Complex result;
            int r, i;
            r = real + c.real;
            i = imaginary + c.imaginary;
            result = new Complex(r, i);
            return result;
        }

        public Complex Sub(Complex c) {

            Complex result;
            int r, i;
            r = real - c.real;
            i = imaginary - c.imaginary;
            result = new Complex(r, i);
            return result;
        }

        public Complex Multiply(Complex c) {

            Complex result;
            int r, i;
            r = real * c.real - imaginary * c.imaginary;
            i = real * c.imaginary + imaginary * c.real;
            result = new Complex(r, i);
            return result;
        }

        public bool isEqual(Complex c) {

            bool result;
            if (real == c.real && imaginary == c.imaginary)
                result = true;
            else
                result = false;
            return result;
        }

        public bool isNotEqual(Complex c) {

            bool result;
            if (real != c.real || imaginary != c.imaginary)
                result = true;
            else
                result = false;
            return result;
        }
    }
}
