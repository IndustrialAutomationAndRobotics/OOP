using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    class AA
    {

        /*
         * Question 1
         */

        private int a;
        private int b;

        public AA()
        {
            a = 0;
            b = 0;
        }
        
        /*
        The syntax error comes from these three methods

        public int AA(int a, int b)
        {
            this.a = a;
            b = this.b;
        }

        public print()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " b);
        }

        public int sum()
        {
            int result;
            result = a + b;
        }

        */
        
        public AA(int a, int b) // constructor do not have return type
        {
            this.a = a;
            b = this.b;
        }

        public void print() // must have void if the method do not have return type
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b); // must have + operator to add the variable
        }

        public int sum()
        {
            int result;
            result = a + b;
            return result; // this method has return type
        }
    }
}
