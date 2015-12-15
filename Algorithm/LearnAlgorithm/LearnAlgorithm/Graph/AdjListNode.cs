using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public class AdjListNode<T>
    {
        private int _adjvex;
        private AdjListNode<T> _next;

        public int Adjvex
        {
            get { return this._adjvex; }
            set { this._adjvex = value; }
        }

        public AdjListNode<T> Next
        {
            get { return this._next; }
            set { this._next = value; }
        }

        public AdjListNode(int vex)
        {
            this._adjvex = vex;
        }
    }
}
