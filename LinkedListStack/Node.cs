using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListStack
{
    class Node<T>
    {
        public T Value;
        public Node<T> Next;

        public Node(T value) { this.Value = value; }
        public Node(T value, Node<T> next) { this.Value = value; }
    }
}
