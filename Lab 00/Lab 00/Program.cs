using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_00
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum, secondNum, result = 0;
            string opr, bol;
            Boolean con = false;

            Console.WriteLine("SIMPLE KALKULATOR");
            Console.WriteLine("===================================\n");

            do
            {
                Console.Write("Please enter first number : ");
                firstNum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter second number : ");
                secondNum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter operation (+, -, *, /) : ");
                opr = Console.ReadLine();

                if (opr == "+")
                {
                    result = firstNum + secondNum;
                    Console.WriteLine(firstNum + " + " + secondNum + " = " + result);
                }
                else if (opr == "-")
                {
                    result = firstNum - secondNum;
                    Console.WriteLine(firstNum + " - " + secondNum + " = " + result);
                }
                else if (opr == "*")
                {
                    result = firstNum * secondNum;
                    Console.WriteLine(firstNum + " x " + secondNum + " = " + result);
                }
                else if (opr == "/")
                {
                    result = firstNum / secondNum;
                    Console.WriteLine(firstNum + " / " + secondNum + " = " + result);
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

                Console.WriteLine("Please enter c to continue");
                bol = Console.ReadLine();
                if(bol == "c"){
                    con = true;
                }
                else{
                    con = false;
                }
            } while (con);

            Console.WriteLine(" Bye Bye \n");
            Console.WriteLine("Prepared By : Ba Ba Ya Ga\n");

            Console.Read();


        }

    }
}
