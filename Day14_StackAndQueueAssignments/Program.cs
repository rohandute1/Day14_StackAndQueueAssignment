using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackAndQueueAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue assignments");

            Console.WriteLine("Choose any option from given below:-");
            Console.WriteLine(" 1.Create Stack\n");
            int option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case 1:
                    // Create a stack using a LinkedList
                    LinkedList<int> stack = new LinkedList<int>();

                    // Create an instance of the StackHelper class
                    StackClass stackClass = new StackClass();

                    // Push elements onto the stack
                    stackClass.Push(stack, 70);
                    stackClass.Push(stack, 30);
                    stackClass.Push(stack, 56);

                    // Print the stack
                    Console.WriteLine("Stack elements:");
                    stackClass.PrintStack(stack);
                    break;
            }
            Console.ReadLine();
        }
    }
}
