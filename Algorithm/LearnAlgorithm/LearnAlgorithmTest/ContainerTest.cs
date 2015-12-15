using LearnAlgorithm.Container;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for ContainerTest and is intended
    ///to contain all ContainerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ContainerTest
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
        ///A test for Container`1 Constructor
        ///</summary>
        public void ContainerConstructorTestHelper<T>()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Container<T> target = new Container<T>(size);
            Assert.IsNotNull(target);
        }

        [TestMethod()]
        public void ContainerConstructorTest()
        {
            ContainerConstructorTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        public void DeleteTestHelper<T>()
        {
            Container<int> target = new Container<int>();
            for (int i = 0; i < 10; i++)
            {
                target.Insert(i);
            }
            target.Delete(6);
            Assert.AreEqual(9, target.Count);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            DeleteTestHelper<int>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTestHelper<T>()
        {
            Container<int> target = new Container<int>();
            for (int i = 0; i < 10; i++)
            {
                target.Insert(i);
            }
            Assert.AreEqual(10, target.Count);
        }

        [TestMethod()]
        public void InsertTest()
        {
            InsertTestHelper<int>();
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        public void IsEmptyTestHelper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty;
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFull;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsFullTest()
        {
            IsFullTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTestHelper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountTest()
        {
            CountTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Container`1 Constructor
        ///</summary>
        public void ContainerConstructorTest1Helper<T>()
        {
            Container<T> target = new Container<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ContainerConstructorTest1()
        {
            ContainerConstructorTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsFull
        ///</summary>
        public void IsFullTest1Helper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsFull;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsFullTest1()
        {
            IsFullTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for IsEmpty
        ///</summary>
        public void IsEmptyTest1Helper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsEmpty;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void IsEmptyTest1()
        {
            IsEmptyTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Count
        ///</summary>
        public void CountTest1Helper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Count;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void CountTest1()
        {
            CountTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Insert
        ///</summary>
        public void InsertTest1Helper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            T item = default(T); // TODO: Initialize to an appropriate value
            target.Insert(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void InsertTest1()
        {
            InsertTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        public void DeleteTest1Helper<T>()
        {
            Container<T> target = new Container<T>(); // TODO: Initialize to an appropriate value
            T item = default(T); // TODO: Initialize to an appropriate value
            target.Delete(item);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void DeleteTest1()
        {
            DeleteTest1Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Container`1 Constructor
        ///</summary>
        public void ContainerConstructorTest2Helper<T>()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Container<T> target = new Container<T>(size);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ContainerConstructorTest2()
        {
            ContainerConstructorTest2Helper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for Container`1 Constructor
        ///</summary>
        public void ContainerConstructorTest3Helper<T>()
        {
            Container<T> target = new Container<T>();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        [TestMethod()]
        public void ContainerConstructorTest3()
        {
            ContainerConstructorTest3Helper<GenericParameterHelper>();
        }
    }
}
