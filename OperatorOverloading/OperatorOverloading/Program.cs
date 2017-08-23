using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {

            // This part of the code do not use operator overloading
            Console.WriteLine("WITHOUT OPERATOR OVERLOADING");
            Console.WriteLine("----------------------------");

            Complex c1 = new Complex(1, 3);
            Complex c2 = new Complex(4, 2);

            // Arithmetic without operator overloading
            Complex c3 = c1.Add(c2);
            Complex c4 = c1.Sub(c2);
            Complex c5 = c1.Multiply(c2);
            c3.Print();
            c4.Print();
            c5.Print();

            if (c4.isNotEqual(c5))
                Console.WriteLine("Not Equal\n");
            else
                Console.WriteLine("Equal\n");

            // This part of the code use the operator overloading
            Console.WriteLine("USING OPERATOR OVERLOADING");
            Console.WriteLine("--------------------------");

            ComplexNumber cn1 = new ComplexNumber(1, 3);
            ComplexNumber cn2 = new ComplexNumber(4, 2);

            // Arithmetic with operator overloading
            ComplexNumber sum = cn1 + cn2;
            ComplexNumber sub = cn1 - cn2;
            ComplexNumber mul = cn1 * cn2;

            sum.Print();
            sub.Print();
            mul.Print();

            if (cn1 != cn2)
                Console.WriteLine("Not Equal\n");
            else
                Console.WriteLine("Equal\n");

        }
    }
}
