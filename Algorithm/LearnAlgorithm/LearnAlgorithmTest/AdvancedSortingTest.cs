using LearnAlgorithm.Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for AdvancedSortingTest and is intended
    ///to contain all AdvancedSortingTest Unit Tests
    ///</summary>
    [TestClass()]
    public class AdvancedSortingTest
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
        ///A test for ShellSort
        ///</summary>
        [TestMethod()]
        public void ShellSortTest()
        {
            AdvancedSorting target = new AdvancedSorting();
            int[] input = RandomList.GetRandomIntArray(21);
            int[] actual;
            actual = target.ShellSort(input);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for RecQuickSort
        ///</summary>
        [TestMethod()]
        public void RecQuickSortTest()
        {
            AdvancedSorting target = new AdvancedSorting();
            int[] input = RandomList.GetRandomIntArray(10);
            target.RecQuickSort(input, 0, input.Length - 1);
            Assert.IsNotNull(input);
        }

        /// <summary>
        ///A test for QuickSort
        ///</summary>
        [TestMethod()]
        public void QuickSortTest()
        {
            AdvancedSorting target = new AdvancedSorting();
            List<int> list = RandomList.GetRandomIntList(7);
            int low = 0;
            int high = list.Count - 1;
            target.QuickSort(list, low, high);
            Assert.IsNotNull(list);
        }
    }
}
