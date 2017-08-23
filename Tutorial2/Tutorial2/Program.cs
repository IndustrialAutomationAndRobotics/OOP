using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class Program
    {
        static void Main(string[] args)
        {

            BirthDate bd = new BirthDate(23, 5, 1993);
            Person manusia = new Person("Safwan", "9356262865", bd);

            manusia.Print();
        }
    }
}
