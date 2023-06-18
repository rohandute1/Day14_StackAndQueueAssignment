using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_StackAndQueueAssignments
{
    internal class QueueClass
    {
        public static void Enqueue(LinkedList<int> queue, int data)
        {
            queue.AddLast(data);
        }

        public void PrintQueue(LinkedList<int> queue)
        {
            foreach (int element in queue)
            {
                Console.WriteLine(element);
            }
        }
    }
}
