using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public class VexNode<T>
    {
        private Node<T> _data;
        private AdjListNode<T> _firstAdj;

        public Node<T> Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public AdjListNode<T> FirstAdj
        {
            get { return this._firstAdj; }
            set { this._firstAdj = value; }
        }

        public VexNode()
        { 
        }

        public VexNode(Node<T> node)
        {
            this._data = node;
        }

        public VexNode(Node<T> node, AdjListNode<T> firstNode)
        {
            this._data = node;
            this._firstAdj = firstNode;
        }
    }
}
