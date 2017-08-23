using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOD
{
    class Calculate
    {
        private double firstNum;
        private double secondNum;

        public Calculate()
        {
            firstNum = 0;
            secondNum = 0;
        }

        public double getFirstNumber()
        {
            return firstNum;
        }

        public double getSecondNumber()
        {
            return secondNum;   
        }

        public void setFirstNumber(double firstNum)
        {
            this.firstNum = firstNum;
        }

        public void setSecondNumber(double secondNum)
        {
            this.secondNum = secondNum;
        }

        public double Add()
        {
            return firstNum + secondNum;
        }

        public double Sub()
        {
            return firstNum - secondNum;
        }

        public double Multiply()
        {
            return firstNum * secondNum;
        }

        public double Divide()
        {
            if(secondNum == 0)
            {
                return 0;
            }
            return firstNum / secondNum;
        }
    }
}
