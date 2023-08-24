using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_PROJECTT.Week_1_Task
{
    public class Stack<T>
    {

        private readonly LinkedList<T> linkedLS;

        public Stack()
        {
            linkedLS = new LinkedList<T>();
            
        }

        public bool IsEmpty()
        {
            return linkedLS.Count == 0;
        }

        public void push(T item)
        {
            linkedLS.AddData(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default;


            }
            T item = linkedLS.tail.data;
            linkedLS.RemoveData(item);
            return item;


        }

        public T peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return default;
            }
            
            T item = linkedLS.tail.data;
            return item;
        }

        public int Size()
        {
            return linkedLS.Count;
        }

    }
}
