using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public class GraphAdjMatrix<T> : IGraph<T>
    {
        private Node<T>[] _nodes;
        private int _numEdges;
        private int[,] _matrix;

        public GraphAdjMatrix(int n)
        {
            this._nodes = new Node<T>[n];
            this._numEdges = 0;
            this._matrix = new int[n, n];
        }

        public Node<T> GetNode(int index)
        {
            return this._nodes[index];
        }

        public void SetNode(int index, Node<T> node)
        {
            this._nodes[index] = node;
        }

        public int NumEdges
        {
            get { return this._numEdges; }
            set { this._numEdges = value; }
        }

        public int GetMatrix(int index1, int index2)
        {
            return this._matrix[index1, index2];
        }

        public void SetMatrix(int index1, int index2)
        {
            this._matrix[index1, index2] = 1;
        }

        public int GetNumberOfVertex()
        {
            return this._nodes.Length;
        }

        public int GetNumberOfEdgee()
        {
            return this._numEdges;
        }

        public bool IsNode(Node<T> node)
        {
            foreach (Node<T> item in this._nodes)
            { 
                if(node.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public int GetIndex(Node<T> node)
        {
            int i = -1;
            for (i = 0; i < this._nodes.Length; i++)
            {
                if (this._nodes[i].Equals(node))
                {
                    return i;
                }
            }
            return i;
        }

        public void SetEdge(Node<T> node1, Node<T> node2, int v)
        {
            if (!IsNode(node1) || ! IsNode(node2))
            {
                Console.WriteLine("Node is not belong to the graph");
                return;
            }

            if (v != 1)
            {
                Console.WriteLine("weight is not right");
                return;
            }

            this._matrix[GetIndex(node1), GetIndex(node2)] = v;
            this._matrix[GetIndex(node2), GetIndex(node1)] = v;
            this._numEdges++;
        }

        public void DelEdge(Node<T> node1, Node<T> node2)
        {
            if (!IsNode(node1) || !IsNode(node2))
            {
                Console.WriteLine("Node is not belong to the graph");
                return;
            }

            if (this._matrix[GetIndex(node1), GetIndex(node2)] == 1)
            {
                this._matrix[GetIndex(node1), GetIndex(node2)] = 0;
                this._matrix[GetIndex(node2), GetIndex(node1)] = 0;
                this._numEdges--;
            }
        }

        public bool IsThereEdge(Node<T> node1, Node<T> node2)
        {
            if (!IsNode(node1) || !IsNode(node2))
            {
                Console.WriteLine("Node is not belong to the graph");
                return false;
            }

            if (this._matrix[GetIndex(node1), GetIndex(node2)] == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}