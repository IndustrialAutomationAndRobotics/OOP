using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01_partA
{
    class Student
    {

        /*
         * Part A
         */
          
        private string studentName;
        private string studentID;
        private string studentFac;
        private static int num = 0;

        public Student(string studentName, string studentID, string studentFac)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.studentFac = studentFac;
            num++;
        }

        public string getStudentName()
        {
            return studentName;
        }

        public string getStudentID()
        {
            return studentID;
        }

        public string getStudentFac()
        {
            return studentFac;
        }

        public void setStudentName(string studentName)
        {
            this.studentName = studentName;
        }

        public void setStudentID(string studentID)
        {
            this.studentID = studentID;
        }

        public void setStudentFac(string studentFac)
        {
            this.studentFac = studentFac;
        }
        
        // Question 3
        public void Print()
        {
            Console.WriteLine("Bil : " + num + "\n" + "Name : " + studentName + "\n"
                + "ID : " + studentID + "\n"
                + "Fac : " + studentFac + "\n");
        }

    }
}
