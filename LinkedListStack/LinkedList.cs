using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStack
{
    class LinkedList<T>
    {
        public Node<T> Head;
        public Node<T> Tail;
        public Node<T> Storage;

        public int Count { get; private set; }


        public void AddFirst(T Value)
        {
            if (Head == null)
            {
                Node<T> node = new Node<T>(Value);
                Head = node;
                Tail = Head;


            }
            else
            { 
              
                Node<T> nodeToInsert = new Node<T>(Value);
                nodeToInsert.Next = Head;
                Head = nodeToInsert;
              
                Count++;
            }
        }


        public bool RemoveFirst()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Storage = Head;
                Head = Head.Next;
                Count--;
                
                return true;

            }
        }
        /*
        public void AddLast(T Value)
        {
            if (Head == null)
            {
                Node<T> node = new Node<T>(Value);
                Head = node;
                Tail = Head;
                Count++;
            }
            else
            {
                Node<T> otherNode = new Node<T>(Value);
                Tail.Next = otherNode;
                Tail = Tail.Next;
                Count++;
            }
        }
        
        public bool RemoveLast()
        {
            if (Head == null)
            {
                return false;
            }
            else
            {
                Node<T> current = Head;

                for (int i = 0; i < Count; current = current.Next, i++)
                {
                    if (current.Next.Equals(Tail))
                    {
                        current.Next = null;
                        Count--;
                        Tail = current;
                        return true;
                    }
                }

                return false;
            }
        }
        */
    }
}
