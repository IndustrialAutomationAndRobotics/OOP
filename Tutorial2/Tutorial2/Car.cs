using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{
    class Car : Vehicle
    {
        private int seatNumber;

        public Car(string plateNumber, string chassisNumber, string color, int seatNumber) : base(plateNumber, chassisNumber, color)
        {
            this.seatNumber = seatNumber;
        }

        // Tutorial 2 Part B Question 2
        // Answer for e
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Seat Number : " + seatNumber);
        }
    }
}
