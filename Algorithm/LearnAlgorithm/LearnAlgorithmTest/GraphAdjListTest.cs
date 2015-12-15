using LearnAlgorithm.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for GraphAdjListTest and is intended
    ///to contain all GraphAdjListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GraphAdjListTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GraphAdjList`1 Constructor
        ///</summary>
        public void GraphAdjListConstructorTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void GraphAdjListConstructorTest()
        {
            GraphAdjListConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DelEdge
        ///</summary>
        public void DelEdgeTestHelper<T>()
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

            target.DelEdge(nodes[0], nodes[1]);
        }

        [TestMethod()]
        public void DelEdgeTest()
        {
            DelEdgeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetIndex
        ///</summary>
        public void GetIndexTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            Node<int> node = nodes[2];
            int expected = 2;
            int actual;
            actual = target.GetIndex(node);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetIndexTest()
        {
            GetIndexTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetNumberOfEdgee
        ///</summary>
        public void GetNumberOfEdgeeTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetNumberOfEdgee();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetNumberOfEdgeeTest()
        {
            GetNumberOfEdgeeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetNumberOfVertex
        ///</summary>
        public void GetNumberOfVertexTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            int actual;
            actual = target.GetNumberOfVertex();
            Assert.AreEqual(5, actual);
        }

        [TestMethod()]
        public void GetNumberOfVertexTest()
        {
            GetNumberOfVertexTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsNode
        ///</summary>
        public void IsNodeTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            Node<int> node = nodes[0];
            bool expected = true;
            bool actual;
            actual = target.IsNode(node);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsNodeTest()
        {
            IsNodeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsThereEdge
        ///</summary>
        public void IsThereEdgeTestHelper<T>()
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

            bool expected = true;
            bool actual;
            actual = target.IsThereEdge(nodes[0], nodes[1]);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsThereEdgeTest()
        {
            IsThereEdgeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SetEdge
        ///</summary>
        public void SetEdgeTestHelper<T>()
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
        }

        [TestMethod()]
        public void SetEdgeTest()
        {
            SetEdgeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<T>()
        {
            Node<int>[] nodes = new Node<int>[5];
            nodes[0] = new Node<int>(0);
            nodes[1] = new Node<int>(1);
            nodes[2] = new Node<int>(2);
            nodes[3] = new Node<int>(3);
            nodes[4] = new Node<int>(4);
            GraphAdjList<int> target = new GraphAdjList<int>(nodes);

            Assert.IsNotNull(target[0]);
        }

        [TestMethod()]
        public void ItemTest()
        {
            ItemTestHelper<GenericParameterHelper>();
        }
    }
}
