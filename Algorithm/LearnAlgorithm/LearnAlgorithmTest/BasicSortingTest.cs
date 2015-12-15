using LearnAlgorithm.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for BasicSortingTest and is intended
    ///to contain all BasicSortingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BasicSortingTest
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
        ///A test for BubbleSort
        ///</summary>
        [TestMethod()]
        public void BubbleSortTest()
        {
            BasicSorting target = new BasicSorting();
            int[] input = RandomList.GetRandomIntArray(10);
            int[] actual;
            actual = target.BubbleSort(input);
            Assert.AreEqual(actual.Length, 10);
        }

        /// <summary>
        ///A test for SelectionSort
        ///</summary>
        [TestMethod()]
        public void SelectionSortTest()
        {
            BasicSorting target = new BasicSorting();
            int[] input = RandomList.GetRandomIntArray(10);
            int[] actual;
            actual = target.SelectionSort(input);
            Assert.AreEqual(actual.Length, 10);
        }

        /// <summary>
        ///A test for InsertionSort
        ///</summary>
        [TestMethod()]
        public void InsertionSortTest()
        {
            BasicSorting target = new BasicSorting();
            int[] input = RandomList.GetRandomIntArray(10);
            int[] actual;
            actual = target.InsertionSort(input);
            Assert.AreEqual(actual.Length, 10);
        }
    }
}
