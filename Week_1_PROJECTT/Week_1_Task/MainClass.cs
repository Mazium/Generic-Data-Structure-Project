using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_PROJECTT.Week_1_Task
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("LINKED LIST");
            Console.ResetColor();
            Console.WriteLine();



            LinkedListClass<int> linkedLS = new LinkedListClass<int>();
            linkedLS.AddData(14);
            linkedLS.AddData(23);
            linkedLS.AddData(53);
            linkedLS.AddData(17);
            linkedLS.AddData(80);




            Console.WriteLine(" List size: " + linkedLS.AddData(67));
            Console.WriteLine(" List size: " + linkedLS.AddData(21));
            Console.WriteLine();
           // Console.WriteLine(" Removed: " + linkedLS.RemoveData(2));
          //  Console.WriteLine(" Removed: " + linkedLS.RemoveData(59));
            Console.WriteLine();
            Console.WriteLine(" Check: " + linkedLS.Contains(5));
            Console.WriteLine(" Check: " + linkedLS.Contains(10));
            Console.WriteLine();
            Console.WriteLine(" Index: " + linkedLS.CheckIndex(200));
            Console.WriteLine(" Index: " + linkedLS.CheckIndex(25));





            Console.WriteLine();
            Console.WriteLine("STACK CLASS");
            Console.ResetColor();
            Console.WriteLine();



            StackClass<int> myStack = new StackClass <int>();



            Console.WriteLine(" Stack is empty " + myStack.IsEmpty());
            myStack.push(30);
            myStack.push(20);
            myStack.push(51);
            myStack.push(13);
            myStack.push(8);




            Console.WriteLine();
            Console.WriteLine(" Stack is empty " + myStack.IsEmpty());
            Console.WriteLine();
            Console.WriteLine(" Stack size " + myStack.Size());
            Console.WriteLine();
            Console.WriteLine(" Return last item added to stack which is " + myStack.peek());
            Console.WriteLine();
            Console.WriteLine(" Remove last item added to stack which is " + myStack.Pop());
            Console.WriteLine();
            Console.WriteLine(" Return last item added to stack which is " + myStack.peek());



            Console.WriteLine();
            Console.WriteLine("QUEUE CLASS");
            Console.ResetColor();
            Console.WriteLine();



            QueueClass<int> myQueue = new QueueClass<int>();



            Console.WriteLine(" Queue is empty " + myQueue.IsEmpty());
            myQueue.Enqueue(90);
            myQueue.Enqueue(22);
            myQueue.Enqueue(51);
            myQueue.Enqueue(131);
            myQueue.Enqueue(8);



            Console.WriteLine();
            Console.WriteLine(" Queue is empty " + myQueue.IsEmpty());
            Console.WriteLine();
            Console.WriteLine(" Queue size " + myQueue.Size());
            Console.WriteLine();
            Console.WriteLine(" Remove last item added to Queue which is " + myQueue.Dequeue());
            Console.WriteLine();
            Console.WriteLine(" Queue size " + myQueue.Size());



        }
    }
    }

