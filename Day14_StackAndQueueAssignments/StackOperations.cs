using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackAndQueueAssignments
{
    internal class StackOperations
    {
        public static void Push(LinkedList<int> value, int data)
        {
            value.AddFirst(data);
        }

        public static int Pop(LinkedList<int> value)
        {
            if (value.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            int topElement = value.First.Value;
            value.RemoveFirst();
            return topElement;
        }

        public static int Peek(LinkedList<int> value)
        {
            if (value.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return value.First.Value;
        }
    }
}
