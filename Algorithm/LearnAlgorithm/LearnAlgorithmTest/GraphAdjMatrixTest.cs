using LearnAlgorithm.Graph;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for GraphAdjMatrixTest and is intended
    ///to contain all GraphAdjMatrixTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GraphAdjMatrixTest
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
        ///A test for GraphAdjMatrix`1 Constructor
        ///</summary>
        public void GraphAdjMatrixConstructorTestHelper<T>()
        {
            int n = 5;
            GraphAdjMatrix<int> target = new GraphAdjMatrix<int>(n);
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void GraphAdjMatrixConstructorTest()
        {
            GraphAdjMatrixConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DelEdge
        ///</summary>
        public void DelEdgeTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            Node<T> node1 = null; // TODO: Initialize to an appropriate value
            Node<T> node2 = null; // TODO: Initialize to an appropriate value
            target.DelEdge(node1, node2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
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
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            Node<T> node = null; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetIndex(node);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetIndexTest()
        {
            GetIndexTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetMatrix
        ///</summary>
        public void GetMatrixTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int index1 = 0; // TODO: Initialize to an appropriate value
            int index2 = 0; // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetMatrix(index1, index2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetMatrixTest()
        {
            //GetMatrixTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetNode
        ///</summary>
        public void GetNodeTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int index = 0; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.GetNode(index);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetNodeTest()
        {
            //GetNodeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetNumberOfEdgee
        ///</summary>
        public void GetNumberOfEdgeeTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetNumberOfEdgee();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetNumberOfVertex();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            Node<T> node = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsNode(node);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            Node<T> node1 = null; // TODO: Initialize to an appropriate value
            Node<T> node2 = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsThereEdge(node1, node2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            int n = 5;
            GraphAdjMatrix<int> target = new GraphAdjMatrix<int>(n);
            Node<int> node0 = new Node<int>(0);
            target.SetNode(0, node0);

            Node<int> node1 = new Node<int>(1);
            target.SetNode(1, node1);

            Node<int> node2 = new Node<int>(2);
            target.SetNode(2, node2);

            Node<int> node3 = new Node<int>(3);
            target.SetNode(3, node3);

            Node<int> node4 = new Node<int>(4);
            target.SetNode(4, node4);

            target.SetEdge(node0, node1, 1);
            target.SetEdge(node0, node2, 1);
            target.SetEdge(node1, node3, 1);
            target.SetEdge(node1, node4, 1);
            target.SetEdge(node2, node3, 1);
            target.SetEdge(node3, node4, 1);

            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void SetEdgeTest()
        {
            SetEdgeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SetMatrix
        ///</summary>
        public void SetMatrixTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int index1 = 0; // TODO: Initialize to an appropriate value
            int index2 = 0; // TODO: Initialize to an appropriate value
            target.SetMatrix(index1, index2);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void SetMatrixTest()
        {
            //SetMatrixTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SetNode
        ///</summary>
        public void SetNodeTestHelper<T>()
        {
            int n = 5;
            GraphAdjMatrix<int> target = new GraphAdjMatrix<int>(5);
            for (int i = 0; i < n; i++)
            {
                Node<int> node = new Node<int>(i);
                target.SetNode(i, node);
            }

            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void SetNodeTest()
        {
            SetNodeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for NumEdges
        ///</summary>
        public void NumEdgesTestHelper<T>()
        {
            int n = 0; // TODO: Initialize to an appropriate value
            GraphAdjMatrix<T> target = new GraphAdjMatrix<T>(n); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumEdges = expected;
            actual = target.NumEdges;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NumEdgesTest()
        {
            NumEdgesTestHelper<GenericParameterHelper>();
        }
    }
}
