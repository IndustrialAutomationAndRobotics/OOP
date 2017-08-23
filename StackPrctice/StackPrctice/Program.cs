using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StackPrctice
{
    class Program
    {
        static void Main(string[] args)
        {   //Question 1 Stack 
            Console.WriteLine("Stack");
            Console.WriteLine("=====================================================================\n");
            // a)Add value into stack
            Stack<int> myStack = new Stack<int>();

            myStack.Push(12);
            myStack.Push(32);
            myStack.Push(54);
            myStack.Push(100);
            myStack.Push(3);

            Console.WriteLine("Current Stack: ");
            foreach (int item in myStack)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            //b) Display top value in the stack

            Console.WriteLine("Top value in stack: {0}", myStack.Peek());

            //c) Remove 2 top values of stack

            Console.WriteLine("Removing top 2 value from current stack");
            Console.WriteLine("Remove value in stack: {0}, {1}", myStack.Pop(), myStack.Pop());
            //myStack.Pop();
            //myStack.Pop();

            
            Console.WriteLine("Current Stack: ");
            foreach (int item in myStack) {
                Console.Write(item + " ");
            }
            //d) Function to display all values of stack
            Console.WriteLine();

            //e) list all element from top to lowest(**check again.. tak tau betul ke tak)

            myStack.Push(100);
            myStack.Push(3);
            Console.WriteLine("Current Stack: ");
            foreach (int item in myStack)
            {
                Console.Write(item + " \n");
            }



            //Question 2 Queue
            Console.WriteLine("\n=================================================================\n");
            Console.WriteLine("Queue\n");
            
            //a) Add value to queue

            Queue<string> myQueue = new Queue<string>();

            myQueue.Enqueue("Paris");
            myQueue.Enqueue("Kuala Lumpur");
            myQueue.Enqueue("London");
            myQueue.Enqueue("Bangkok");

            Console.WriteLine("Current Queue: ");
            foreach (string item in myQueue) {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("\n");

            //b) Display front value of queue

            Console.WriteLine("Front value in Queue: {0}", myQueue.Peek());
            Console.WriteLine("\n");

            //c) Remove 2 front value of queue

            Console.WriteLine("Removing two front value of queue\n");
            string item2 = (string)myQueue.Dequeue();
            Console.WriteLine("The removed value: {0}", item2);
            item2 = (string)myQueue.Dequeue();
            Console.WriteLine("The removed value: {0}", item2);

            Console.WriteLine("Current Queue: ");
            foreach (string item in myQueue) {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("\n");
            


        }
    }
}
