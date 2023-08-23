﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_PROJECTT.Week_1_Task
{
    public class LinkedListClass<T>
    {

      //  LinkedList<int> linkedLS = new LinkedList<int>();
        //Our storage
        public class Node
        {
            public T data;
            public Node nextNode;
            public Node(T passedData)
            {
                this.data = passedData;
            }
        }

        //Holding the data to be passed to the linkedlist
        public Node head = default;
        public Node tail = default;
        private int count;

        public int Count { get { return count; } }

        public int AddData(T className)
        {
            Node node = new Node(className);
            if(head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.nextNode = node;
                tail = node;
            }
            count++;
            return count;
            
        }

        public void RemoveData(T data)
        {

            if (head != null)
            {
                Node currentNode = head;
                Node previousNode = null;

                while (currentNode != null)
                {
                    if (currentNode.data.Equals(data))
                    {
                        if (previousNode == null)
                        {
                            //If the head to be removed is the head node
                            head = currentNode.nextNode;
                            if (head == null)
                            {
                                //If there's only one node in the list
                                tail = null;
                            }
                        }
                        else
                        {
                            //If the node to be removed is not the head node
                            previousNode.nextNode = currentNode.nextNode;
                            if (currentNode.nextNode == null)
                            {
                                //If the node to be removed is the tail node
                                tail = previousNode;
                            }
                        }
                        //If you want to remove all occurences of data, remove the return statement here.
                        return;
                    }
                    previousNode = currentNode;
                    currentNode = currentNode.nextNode;
                }
                //Data not found in the list
                Console.WriteLine("Data not found");

            }
            else
            {
                // No node available in the list
                Console.WriteLine("No nodes available");
            }
        }

        public Node Find(T data)
        {
             Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.data.Equals(data))
                {
                    return currentNode;
                }
                currentNode = currentNode.nextNode;
            }
            return null;
        }

        public bool Contains(T data)
        {
            return Find(data) != null; 
        }

        public int CheckIndex(T item)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if (current.data.Equals(item))
                    return index;

                current = current.nextNode;
                index++;
            }
            return -1;
        }

    }
}
