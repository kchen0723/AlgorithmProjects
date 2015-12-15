using LearnAlgorithm.List;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for SequenceListTest and is intended
    ///to contain all SequenceListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SequenceListTest
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
        ///A test for SequenceList`1 Constructor
        ///</summary>
        public void SequenceListConstructorTestHelper<T>()
        {
            SequenceList<T> target = new SequenceList<T>();
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void SequenceListConstructorTest()
        {
            SequenceListConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SequenceList`1 Constructor
        ///</summary>
        public void SequenceListConstructorTest1Helper<T>()
        {
            int size = 50; // TODO: Initialize to an appropriate value
            SequenceList<T> target = new SequenceList<T>(size);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SequenceListConstructorTest1()
        {
            SequenceListConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Append
        ///</summary>
        public void AppendTestHelper<T>()
        {
            SequenceList<int> target = new SequenceList<int>(); // TODO: Initialize to an appropriate value
            int item = 300; // TODO: Initialize to an appropriate value
            target.Append(item);
            Assert.AreEqual(300, target[0]);
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
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.AreEqual(true, target.IsEmpty());
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
            SequenceList<int> target = new SequenceList<int>();
            for (int i = 0; i < 15; i++)
            {
                target.Append(i);
            }
            int actual = target.Delete(10);
            Assert.AreEqual(10, actual);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            DeleteTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetItem
        ///</summary>
        public void GetItemTestHelper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            T expected = default(T); // TODO: Initialize to an appropriate value
            T actual;
            actual = target[i];
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void GetItemTest()
        {
            GetItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetLength
        ///</summary>
        public void GetLengthTestHelper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
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
            SequenceList<int> target = new SequenceList<int>(); // TODO: Initialize to an appropriate value
            for (int i = 0; i < 20; i++)
            {
                target.Append(i);
            }
            target.Insert(87, 15);
            Assert.AreEqual(87, target[15]);
            Assert.AreEqual(21, target.GetLength());
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
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsEmptyTest()
        {
            IsEmptyTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsFull
        ///</summary>
        public void IsFullTestHelper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsFullTest()
        {
            IsFullTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Locate
        ///</summary>
        public void LocateTestHelper<T>()
        {
            SequenceList<int> target = new SequenceList<int>();
            for (int i = 0; i < 10; i++)
            {
                target.Append(i);
            }
            int expected = 5; 
            int actual;
            actual = target.Locate(5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void LocateTest()
        {
            LocateTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        public void ItemTestHelper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
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
            ItemTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsFull
        ///</summary>
        public void IsFullTest1Helper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFull();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsFullTest1()
        {
            IsFullTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTest1Helper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
            T item = default(T); // TODO: Initialize to an appropriate value
            int i = 0; // TODO: Initialize to an appropriate value
            target.Insert(item, i);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InsertTest1()
        {
            InsertTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetLength
        ///</summary>
        public void GetLengthTest1Helper<T>()
        {
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
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
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
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
            SequenceList<T> target = new SequenceList<T>(); // TODO: Initialize to an appropriate value
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
        ///A test for SequenceList`1 Constructor
        ///</summary>
        public void SequenceListConstructorTest2Helper<T>()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            SequenceList<T> target = new SequenceList<T>(size);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SequenceListConstructorTest2()
        {
            SequenceListConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SequenceList`1 Constructor
        ///</summary>
        public void SequenceListConstructorTest3Helper<T>()
        {
            SequenceList<T> target = new SequenceList<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void SequenceListConstructorTest3()
        {
            SequenceListConstructorTest3Helper<GenericParameterHelper>();
        }
    }
}
