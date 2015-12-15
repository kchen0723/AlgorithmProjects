using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public class Node<T>
    {
        private T _data;

        public Node(T data)
        {
            this._data = data;
        }

        public T Data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
