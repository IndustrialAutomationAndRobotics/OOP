using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    class BB
    {
        /*
         * Question 2
         * 
         *  a) class BB have 5 members
         *  b) class BB have 2 private members
         *  c) class BB have 2 constructors
         */
         
             
        private int u;
        private double w;

        // Question 2 (d)
        public void func()
        {
            u = 10;
            w = 15.3;
        }

        // Question 2 (e)
        public void print()
        {
            Console.WriteLine("u = " + u + " \n"
                + "w = " + w + "\n");
        }

        // Question 2 (f)
        public BB()
        {
            u = 0;
            w = 0.0;
        }

        public BB(int valU, double valW)
        {
            u = valU;
            w = valW;
        }
    }
}
