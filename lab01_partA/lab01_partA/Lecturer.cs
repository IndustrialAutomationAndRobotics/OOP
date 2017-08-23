using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_partA
{
    class Lecturer
    {
        /*
         * Part B
         */
          
        private string lecturerName;
        private string lecturerID;

        public Lecturer(string lecturerName, string lecturerID)
        {
            this.lecturerName = lecturerName;
            this.lecturerID = lecturerID;
        }

        public void Print()
        {
            Console.WriteLine("Name : " + lecturerName + "\n"
                + "ID : " + lecturerID + "\n");
        }
    }
}
