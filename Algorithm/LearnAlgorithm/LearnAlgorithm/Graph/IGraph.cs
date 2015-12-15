using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnAlgorithm.Graph
{
    public interface IGraph<T>
    {
        int GetNumberOfVertex();
        int GetNumberOfEdgee();
        void SetEdge(Node<T> node1, Node<T> node2, int v);
        void DelEdge(Node<T> node1, Node<T> node2);
        bool IsThereEdge(Node<T> node1, Node<T> node2);
    }
}
