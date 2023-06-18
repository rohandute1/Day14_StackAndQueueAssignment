using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackAndQueueAssignments
{
    internal class StackClass
    {
        // Push method to add elements to the stack
        public void Push(LinkedList<int> stack, int data)
        {
            stack.AddFirst(data);
        }

        // Helper method to print the stack elements
        public void PrintStack(LinkedList<int> stack)
        {
            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
