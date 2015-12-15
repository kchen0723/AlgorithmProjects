using LearnAlgorithm.Searching;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for FindingLongestSubStringTest and is intended
    ///to contain all FindingLongestSubStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FindingLongestSubStringTest
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
        ///A test for LCSubstring
        ///</summary>
        [TestMethod()]
        public void LCSubstringTest()
        {
            string word1 = "maven";
            string word2 = "havoc";
            char[] warr1 = new char[word1.Length];
            char[] warr2 = new char[word2.Length];
            int[,] arr = new int[word1.Length, word2.Length];
            FindingLongestSubString.LCSubstring(word1, word2, warr1, warr2, arr);
            Console.WriteLine();
            FindingLongestSubString.DispArray(arr);
            string substr = FindingLongestSubString.ShowString(arr, warr1);
            Console.WriteLine(substr);
            Assert.IsNotNull(substr);
        }
    }
}
