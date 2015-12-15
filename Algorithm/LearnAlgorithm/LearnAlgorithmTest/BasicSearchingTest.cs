using LearnAlgorithm.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LearnAlgorithm.Sorting;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for BasicSearchingTest and is intended
    ///to contain all BasicSearchingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BasicSearchingTest
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
        ///A test for BinarySearch
        ///</summary>
        [TestMethod()]
        public void BinarySearchTest()
        {
            BasicSearching target = new BasicSearching();
            int item = 8;
            int[] target1 = RandomList.GetSortedRandomIntArray(20);
            int actual;
            actual = target.BinarySearch(item, target1);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for ResursiveBinarySearch
        ///</summary>
        [TestMethod()]
        public void ResursiveBinarySearchTest()
        {
            BasicSearching target = new BasicSearching();
            int item = 0;
            int[] target1 = RandomList.GetSortedRandomIntArray(20);
            int actual;
            actual = target.ResursiveBinarySearch(item, target1, 0, target1.Length - 1);
            Assert.IsNotNull(actual);
        }
    }
}
