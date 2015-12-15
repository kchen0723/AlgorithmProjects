using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public class GraphAdjList<T> : IGraph<T>
    {
        private VexNode<T>[] _adjList;
        private int[] visited;

        public VexNode<T> this[int index]
        {
            get { return this._adjList[index]; }
            set { this._adjList[index] = value; }
        }

        public GraphAdjList(Node<T>[] nodes)
        {
            this._adjList = new VexNode<T>[nodes.Length];
            for (int i = 0; i < nodes.Length; i++)
            {
                this._adjList[i] = new VexNode<T>(nodes[i]);
            }

            visited = new int[_adjList.Length];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = 0;
            }
        }

        public void DFS()
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] == 0)
                {
                    DFSAL(i);
                }
            }
        }

        private void DFSAL(int i)
        {
            visited[i] = 1;
            AdjListNode<T> p = _adjList[i].FirstAdj;
            while (p != null)
            {
                if (visited[p.Adjvex] == 0)
                {
                    Console.WriteLine(_adjList[p.Adjvex].Data.Data.ToString());
                    DFSAL(p.Adjvex);
                }
                p = p.Next;
            }
        }

        public int GetNumberOfVertex()
        {
            return this._adjList.Length;
        }

        public bool IsNode(Node<T> node)
        {
            foreach (VexNode<T> item in _adjList)
            {
                if (node.Equals(item.Data))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetIndex(Node<T> node)
        {
            int i = -1;
            for (i = 0; i < this._adjList.Length; ++i)
            {
                if (this._adjList[i].Data.Equals(node))
                {
                    return i;
                }
            }
            return i;
        }

        public int GetNumberOfEdgee()
        {
            int i = 0;

            foreach (VexNode<T> node in _adjList)
            {
                AdjListNode<T> p = node.FirstAdj;
                while (p != null)
                {
                    i++;
                    p = p.Next;
                }
            }

            return i / 2;
        }

        public void SetEdge(Node<T> node1, Node<T> node2, int v)
        {
            if (!IsNode(node1) || !IsNode(node2) || IsThereEdge(node1, node2))
            {
                Console.WriteLine("Node is not belong to the graph");
                return;
            }

            if (v != 1)
            {
                Console.WriteLine("weight is not right");
                return;
            }

            AdjListNode<T> p = new AdjListNode<T>(GetIndex(node2));

            if (_adjList[GetIndex(node1)].FirstAdj == null)
            {
                _adjList[GetIndex(node1)].FirstAdj = p;
            }
            else
            {
                p.Next = _adjList[GetIndex(node1)].FirstAdj;
                _adjList[GetIndex(node1)].FirstAdj = p;
            }

            p = new AdjListNode<T>(GetIndex(node1));
            if (_adjList[GetIndex(node2)].FirstAdj == null)
            {
                _adjList[GetIndex(node2)].FirstAdj = p;
            }
            else
            {
                p.Next = _adjList[GetIndex(node2)].FirstAdj;
                _adjList[GetIndex(node2)].FirstAdj = p;
            }
        }

        public void DelEdge(Node<T> node1, Node<T> node2)
        {
            if (!IsNode(node1) || !IsNode(node2))
            {
                Console.WriteLine("node is not belong to the graph");
                return;
            }

            if (IsThereEdge(node1, node2))
            {
                AdjListNode<T> p = _adjList[GetIndex(node1)].FirstAdj;
                AdjListNode<T> pre = null;

                while (p != null)
                {
                    if (p.Adjvex == GetIndex(node2))
                    {
                        break;
                    }
                    pre = p;
                    p = p.Next;
                }
                if (pre != null)
                {
                    pre.Next = p.Next;
                }

                p = _adjList[GetIndex(node2)].FirstAdj;
                pre = null;

                while (p != null)
                {
                    if (p.Adjvex != GetIndex(node1))
                    {
                        break;
                    }
                    pre = p;
                    p = p.Next;
                }
                if (pre != null)
                {
                    pre.Next = p.Next;
                }
            }
        }

        public bool IsThereEdge(Node<T> node1, Node<T> node2)
        {
            if (!IsNode(node1) || !IsNode(node2))
            {
                Console.WriteLine("Node is not belong to the graph");
                return false;
            }

            AdjListNode<T> p = _adjList[GetIndex(node1)].FirstAdj;
            while (p != null)
            {
                if (p.Adjvex == GetIndex(node2))
                {
                    return true;
                }
                p = p.Next;
            }
            return false;
        }
    }
}
