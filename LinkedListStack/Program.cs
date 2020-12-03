using System;

namespace LinkedListStack
{


    public class Stack<T>
    {
        public int Count { get; private set; }
        private LinkedList<T> data = new LinkedList<T>();

        public Stack()
        {

        }

        public void Push(T value)
        {
            data.AddFirst(value);
        }
        public T Pop()
        {
            data.RemoveFirst();
            return data.Storage.Value;
        }
        public T Peek()
        {
            return data.Storage.Value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var stack = new Stack<char>();


            //foreach (var letter in "karan")
            //{
            //    stack.Push(letter);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(stack.Pop());
            //}

            Stack<int> list = new Stack<int>();
            list.Push(1);
            list.Push(2);
            list.Push(3);
            list.Push(4);
            list.Push(5);
            Console.WriteLine(list.Pop());
            Console.WriteLine(list.Pop());
            Console.WriteLine(list.Peek());
            ;




        }
    }
}
