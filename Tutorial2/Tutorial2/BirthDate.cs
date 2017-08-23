using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class BirthDate
    {
        // The instance variable
        private int day;
        private int month;
        private int year;

        // The constructor
        public BirthDate(int d, int m, int y) {

            day = d;
            month = m;
            year = y;
        }

        // getter method. Use to get the date of birth
        public string getDate() {

            return day + "/" + month + "/" + year;
        }
    }
}
