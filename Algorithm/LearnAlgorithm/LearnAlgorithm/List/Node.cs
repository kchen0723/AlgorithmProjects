using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.List
{
    public class Node<T>
    {
        private T _data = default(T);
        private Node<T> _next;

        public Node(T data, Node<T> next)
        {
            this._data = data;
            this._next = next;
        }

        public Node(Node<T> next)
            : this(default(T), next)
        { 
        }

        public Node(T data)
            : this(data, null)
        { 
        }

        public Node()
            : this(default(T), null)
        { 
        }

        public T Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public Node<T> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }
    }
}
