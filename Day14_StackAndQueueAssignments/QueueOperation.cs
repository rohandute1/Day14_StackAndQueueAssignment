using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackAndQueueAssignments
{
    internal class QueueOperation
    {
        public static void Enqueue(LinkedList<int> x, int data)
        {
            x.AddLast(data);
        }

        public static int Dequeue(LinkedList<int> x)
        {
            if (x.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int frontElement = x.First.Value;
            x.RemoveFirst();
            return frontElement;
        }

        public static void PrintQueue(LinkedList<int> x)
        {
            foreach (int element in x)
            {
                Console.WriteLine(element);
            }
        }
    }
}
