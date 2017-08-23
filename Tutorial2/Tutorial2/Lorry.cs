using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class Lorry : Vehicle
    {
        private double loadLimit;

        public Lorry(string plateNumber, string chassisNumber, string color, double loadLimit) : base(plateNumber, chassisNumber, color)
        {
            this.loadLimit = loadLimit;
        }

        // Tutorial 2 Part B Question 2
        // Answer for e
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Load Limit : " + loadLimit);
        }
    }
}
