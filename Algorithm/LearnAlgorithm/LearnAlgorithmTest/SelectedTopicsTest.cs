using LearnAlgorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnAlgorithmTest
{
    
    
    /// <summary>
    ///This is a test class for SelectedTopicsTest and is intended
    ///to contain all SelectedTopicsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SelectedTopicsTest
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
        ///A test for GetLongestCommonSubString
        ///</summary>
        [TestMethod()]
        public void GetLongestCommonSubStringTest()
        {
            SelectedTopics target = new SelectedTopics(); // TODO: Initialize to an appropriate value
            string left = "GetLongestCommonSubStringTest";
            string right = "target";
            string expected = "get";
            string actual;
            actual = target.GetLongestCommonSubString(left, right, true);
            Assert.AreEqual(expected, actual);
        }
    }
}
