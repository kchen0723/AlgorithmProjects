using LearnAlgorithm.List;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for LinkListTest and is intended
    ///to contain all LinkListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LinkListTest
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
        ///A test for LinkList`1 Constructor
        ///</summary>
        public void LinkListConstructorTestHelper<T>()
        {
            LinkList<int> target = new LinkList<int>();
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void LinkListConstructorTest()
        {
            LinkListConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Append
        ///</summary>
        public void AppendTestHelper<T>()
        {
            LinkList<int> target = new LinkList<int>();
            target.Append(3);
            target.Append(7);
            target.Append(10);
            Assert.AreEqual(target.GetLength(), 3);
        }

        [TestMethod()]
        public void AppendTest()
        {
            AppendTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTestHelper<T>()
        {
            LinkList<int> target = new LinkList<int>();
            target.Append(3);
            target.Append(7);
            target.Append(10);

            target.Clear();
            Assert.AreEqual(target.GetLength(), 0);
        }

        [TestMethod()]
        public void ClearTest()
        {
            ClearTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        public void DeleteTestHelper<T>()
        {
            LinkList<int> target = new LinkList<int>();
            target.Append(3);
            target.Append(7);
            target.Append(10);

            target.Delete(2);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            DeleteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetINode
        ///</summary>
        public void GetINodeTestHelper<T>()
        {
            LinkList_Accessor<T> target = new LinkList_Accessor<T>(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            actual = target.GetINode(i);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("LearnAlgorithm.exe")]
        public void GetINodeTest()
        {
            //GetINodeTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetLength
        ///</summary>
        public void GetLengthTestHelper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetLengthTest()
        {
            GetLengthTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<T>()
        {
            LinkList<int> target = new LinkList<int>();
            target.Append(3);
            target.Append(7);
            target.Append(10);

            target.Insert(20, 1);
        }

        [TestMethod()]
        public void InsertTest()
        {
            InsertTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        public void IsEmptyTestHelper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            //IsEmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Locate
        ///</summary>
        public void LocateTestHelper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            T value = default(T); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Locate(value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void LocateTest()
        {
            //LocateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Head
        ///</summary>
        public void HeadTestHelper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
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
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            target[i] = expected;
            actual = target[i];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ItemTest()
        {
            //ItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Head
        ///</summary>
        public void HeadTest1Helper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            Node<T> expected = null; // TODO: Initialize to an appropriate value
            Node<T> actual;
            target.Head = expected;
            actual = target.Head;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void HeadTest1()
        {
            HeadTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetLength
        ///</summary>
        public void GetLengthTest1Helper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetLength();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetLengthTest1()
        {
            GetLengthTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        public void ClearTest1Helper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void ClearTest1()
        {
            ClearTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Append
        ///</summary>
        public void AppendTest1Helper<T>()
        {
            LinkList<T> target = new LinkList<T>(); // TODO: Initialize to an appropriate value
            T item = default(T); // TODO: Initialize to an appropriate value
            target.Append(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void AppendTest1()
        {
            AppendTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for LinkList`1 Constructor
        ///</summary>
        public void LinkListConstructorTest1Helper<T>()
        {
            LinkList<T> target = new LinkList<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void LinkListConstructorTest1()
        {
            LinkListConstructorTest1Helper<GenericParameterHelper>();
        }
    }
}
