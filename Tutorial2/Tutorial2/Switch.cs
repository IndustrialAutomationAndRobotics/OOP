using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial2
{

    /*
     * Question 1
     * 
     * a. Answer in switch.jpg
     * b. 7 member. consist of 3 private instance variable, 1 constructor, 2 method and 1 getter method
     * 
     */

    class Switch
    {
        private string id;
        private string label;
        private bool isPressed;

        public Switch(string id, string label, bool isPressed)
        {
            this.id = id;
            this.label = label;
            this.isPressed = isPressed;
        }

        // Answer for C.
        public void ChangeLabel(string newlbl)
        {
            label = newlbl;
        }

        public bool GetSwitchState()
        {
            return isPressed;
        }

        public void Press()
        {
            Console.WriteLine("New label: {0}", label);
        }
    }
}
