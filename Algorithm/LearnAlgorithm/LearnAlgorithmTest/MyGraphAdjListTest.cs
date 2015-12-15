using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnAlgorithm.Graph;

namespace LearnAlgorithmTest
{
    [TestClass]
    public class MyGraphAdjListTest
    {
        [TestMethod]
        public void TestDFS()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            target.SetEdge(nodes[0], nodes[1], 1);
            target.SetEdge(nodes[0], nodes[2], 1);
            target.SetEdge(nodes[1], nodes[3], 1);
            target.SetEdge(nodes[1], nodes[4], 1);
            target.SetEdge(nodes[2], nodes[3], 1);
            target.SetEdge(nodes[3], nodes[4], 1);

            target.DFS();
        }
    }
}
