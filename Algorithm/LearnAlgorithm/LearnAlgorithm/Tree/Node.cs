using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Tree
{
    public class Node<T>
    {
        private T _data;
        private Node<T> _parent;
        private Node<T> _lChild;
        private Node<T> _rChild;

        public Node(T data, Node<T> parent, Node<T> lChild, Node<T> rChild)
        {
            this._data = data;
            this._parent = parent;
            this._lChild = lChild;
            this._rChild = rChild;
        }

        public Node(Node<T> parent, Node<T> lChild, Node<T> rChild)
            : this(default(T), parent, lChild, rChild)
        { 
        }

        public Node(T data)
        {
            this._data = data;
        }

        public Node()
        { 
        }

        public T Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public Node<T> Parent
        {
            get { return this._parent; }
            set { this._parent = value; }
        }

        public Node<T> LChild
        {
            get { return this._lChild; }
            set { this._lChild = value; }
        }

        public Node<T> RChild
        {
            get { return this._rChild; }
            set { this._rChild = value; }
        }
    }
}
