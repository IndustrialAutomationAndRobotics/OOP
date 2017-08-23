using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOD
{
    class Program
    {

        private static string[] operations = { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
            double result = 0;
            string end = "a";
            Boolean stop = false;

            Calculate Num1 = new Calculate();

            do
            {
                welcomeDisplay();
                Num1.setFirstNumber(SetNumber("Type your first number : "));
                Num1.setSecondNumber(SetNumber("Type your second number : "));

                string stringOperation = SetOperation("Enter the operation + (addition), - (subtraction), * (multiplication) or / (divide) : ");

                switch (stringOperation)
                {
                    case "+":
                        result = Num1.Add();
                        break;
                    case "-":
                        result = Num1.Sub();
                        break;
                    case "*":
                        result = Num1.Multiply();
                        break;
                    case "/":
                        result = Num1.Divide();
                        break;
                }

                Console.WriteLine("Result of {0} {1} {2} is {3}", Num1.getFirstNumber(), stringOperation, Num1.getSecondNumber(), result);
                
                Console.WriteLine("Press Enter to continue or type e to exit");
                end = Console.ReadLine();
                if(end == "e")
                {
                    stop = true;
                }

            } while (!stop);
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while(!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }

            return parse;
        }

        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }

        private static bool IsValidOperation(string input)
        {
            return operations.Contains(input);
        }

        private static void welcomeDisplay()
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("                         Simple Calculator                            ");
            Console.WriteLine("----------------------------------------------------------------------\n");

        }


    }
}
