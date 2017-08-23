using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    class CC
    {
        /*
         * Question 3
         * 
         * a) i) first constructor
         *    ii) third constructor
         *    iii) Fourth constructor
         */

        private int u;
        private double v;

        // Question 3 (b)
        public CC() // First constructor
        {
            u = 0;
            v = 0.0;
        }

        // Question 3 (c)
        public CC(int valU) // Second constructor
        {
            u = valU;
            v = 0.0; 
        }

        public CC(double valV) // Third constructor
        {
            u = 0;
            v = valV;
        }

        // Question 3 (d)
        public CC(int valU, double valV) // Fourth constructor
        {
            u = valU;
            v = valV;
        }
    }
}
