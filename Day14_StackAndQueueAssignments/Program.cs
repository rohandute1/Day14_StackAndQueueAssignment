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
            Console.WriteLine(" 1.Create Stack\n 2.Ability to peak and pop from the stack\n 3.Create Queue\n 4.Ability to dequeue");
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

                case 2:
                    LinkedList<int> value = new LinkedList<int>();

                    StackOperations.Push(value, 56);
                    StackOperations.Push(value, 30);
                    StackOperations.Push(value, 70);

                    while (value.Count > 0)
                    {
                        int topElement = StackOperations.Peek(value);
                        Console.WriteLine("Peeked element: " + topElement);

                        int poppedElement = StackOperations.Pop(value);
                        Console.WriteLine("Popped element: " + poppedElement);
                    }
                    break;

                case 3:
                    LinkedList<int> queue = new LinkedList<int>();
                    QueueClass queueClass = new QueueClass();

                    QueueClass.Enqueue(queue, 56);
                    QueueClass.Enqueue(queue, 30);
                    QueueClass.Enqueue(queue, 70);

                    Console.WriteLine("Queue elements:");
                    queueClass.PrintQueue(queue);
                    break;

                case 4:
                    LinkedList<int> x = new LinkedList<int>();
                    QueueOperation queueOperation = new QueueOperation();

                    QueueOperation.Enqueue(x, 56);
                    QueueOperation.Enqueue(x, 30);
                    QueueOperation.Enqueue(x, 70);

                    Console.WriteLine("Queue elements:");
                    QueueOperation.PrintQueue(x);

                    int dequeuedElement = QueueOperation.Dequeue(x);
                    Console.WriteLine("Dequeued element: " + dequeuedElement);

                    Console.WriteLine("Updated Queue elements:");
                    QueueOperation.PrintQueue(x);
                    break;
            
            }
            Console.ReadLine();
        }
    }
}
