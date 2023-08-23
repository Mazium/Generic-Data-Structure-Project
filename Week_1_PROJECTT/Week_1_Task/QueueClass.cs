using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_PROJECTT.Week_1_Task
{
    public class QueueClass<T>
    {
        
        
            private readonly LinkedListClass<T> linkedLS;



            public QueueClass()
            {
                linkedLS = new LinkedListClass<T>();
            }
            public bool IsEmpty()
            {
                return linkedLS.Count == 0;
            }



            public void Enqueue(T item)
            {
                linkedLS.AddData(item);
            }



            public T Dequeue()
            {
                if (IsEmpty())
                    Console.WriteLine("Stack is empty");
                T item = linkedLS.head.data;
                linkedLS.RemoveData(item);
                return item;
            }





            public int Size()
            {
                return linkedLS.Count;
            }
        
    }
}   
