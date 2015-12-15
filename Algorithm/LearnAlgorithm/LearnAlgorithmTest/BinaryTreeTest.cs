using LearnAlgorithm.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for BinaryTreeTest and is intended
    ///to contain all BinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BinaryTreeTest
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
        ///A test for BinaryTree`1 Constructor
        ///</summary>
        public void BinaryTreeConstructorTestHelper<T>()
        {
            T data = default(T); // TODO: Initialize to an appropriate value
            BinaryTree<T> target = new BinaryTree<T>(data);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void BinaryTreeConstructorTest()
        {
            BinaryTreeConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for BinaryTree`1 Constructor
        ///</summary>
        public void BinaryTreeConstructorTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void BinaryTreeConstructorTest1()
        {
            BinaryTreeConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteL
        ///</summary>
        public void DeleteLTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> p = null; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.DeleteL(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DeleteLTest()
        {
            DeleteLTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteR
        ///</summary>
        public void DeleteRTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> p = null; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.DeleteR(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DeleteRTest()
        {
            DeleteRTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InOrder
        ///</summary>
        public void InOrderTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.InOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InOrderTest()
        {
            InOrderTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InsertL
        ///</summary>
        public void InsertLTestHelper<T>()
        {
            BinaryTree<int> target = new BinaryTree<int>();
            target.Head = new Node<int>(20);
            target.InsertL(30, target.Head);
        }

        [TestMethod()]
        public void InsertLTest()
        {
            InsertLTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InsertR
        ///</summary>
        public void InsertRTestHelper<T>()
        {
            BinaryTree<int> target = new BinaryTree<int>();
            target.Head = new Node<int>(20);
            target.InsertL(30, target.Head);
            target.InsertR(40, target.Head);
        }

        [TestMethod()]
        public void InsertRTest()
        {
            InsertRTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for LevelOrder
        ///</summary>
        public void LevelOrderTestHelper<T>()
        {
            BinaryTree<int> target = new BinaryTree<int>();
            target.Head = new Node<int>(20);
            Node<int> lchild = target.InsertL(30, target.Head);
            Node<int> rchild = target.InsertR(40, target.Head);
            target.InsertL(60, lchild);
            target.InsertR(70, lchild);
            target.InsertR(80, rchild);

            target.LevelOrder(target.Head);
        }

        [TestMethod()]
        public void LevelOrderTest()
        {
            LevelOrderTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for PostOrder
        ///</summary>
        public void PostOrderTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.PostOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void PostOrderTest()
        {
            PostOrderTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for PreOrder
        ///</summary>
        public void PreOrderTestHelper<T>()
        {
            BinaryTree<int> target = new BinaryTree<int>();
            target.Head = new Node<int>(20);
            Node<int> lchild = target.InsertL(30, target.Head);
            Node<int> rchild = target.InsertR(40, target.Head);
            target.InsertL(60, lchild);
            target.InsertR(70, lchild);
            target.InsertR(80, rchild);

            target.PreOrder(target.Head);
        }

        [TestMethod()]
        public void PreOrderTest()
        {
            PreOrderTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Root
        ///</summary>
        public void RootTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.Root();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void RootTest()
        {
            RootTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Head
        ///</summary>
        public void HeadTestHelper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            target.Head = expected;
            actual = target.Head;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void HeadTest()
        {
            HeadTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Root
        ///</summary>
        public void RootTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.Root();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void RootTest1()
        {
            RootTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for PreOrder
        ///</summary>
        public void PreOrderTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.PreOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void PreOrderTest1()
        {
            PreOrderTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for PostOrder
        ///</summary>
        public void PostOrderTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.PostOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void PostOrderTest1()
        {
            PostOrderTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for LevelOrder
        ///</summary>
        public void LevelOrderTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.LevelOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void LevelOrderTest1()
        {
            LevelOrderTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InOrder
        ///</summary>
        public void InOrderTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> root = null; // TODO: Initialize to an appropriate value
            target.InOrder(root);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InOrderTest1()
        {
            InOrderTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteR
        ///</summary>
        public void DeleteRTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> p = null; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.DeleteR(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DeleteRTest1()
        {
            DeleteRTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for DeleteL
        ///</summary>
        public void DeleteLTest1Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>(); // TODO: Initialize to an appropriate value
            Node<T> p = null; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.DeleteL(p);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void DeleteLTest1()
        {
            DeleteLTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for BinaryTree`1 Constructor
        ///</summary>
        public void BinaryTreeConstructorTest2Helper<T>()
        {
            BinaryTree<T> target = new BinaryTree<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void BinaryTreeConstructorTest2()
        {
            BinaryTreeConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for BinaryTree`1 Constructor
        ///</summary>
        public void BinaryTreeConstructorTest3Helper<T>()
        {
            T data = default(T); // TODO: Initialize to an appropriate value
            BinaryTree<T> target = new BinaryTree<T>(data);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void BinaryTreeConstructorTest3()
        {
            BinaryTreeConstructorTest3Helper<GenericParameterHelper>();
        }
    }
}
