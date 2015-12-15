using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LearnAlgorithm.List;

namespace LearnAlgorithmTest
{
    /// <summary>
    /// Summary description for MySequenceListTest
    /// </summary>
    [TestClass]
    public class MySequenceListTest
    {
        public MySequenceListTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        public void RevertListHelp(SequenceList<int> lists)
        {
            int temp = 0;
            int length = lists.GetLength();
            for (int i = 0; i <= length / 2; i++)
            {
                temp = lists[i];
                lists[i] = lists[length - 1 - i];
                lists[length - 1 - i] = temp;
            }
        }

        public SequenceList<int> MergeListHelp(SequenceList<int> La, SequenceList<int> Lb)
        {
            SequenceList<int> Lc = new SequenceList<int>(La.GetLength() + Lb.GetLength());
            int j = 0;
            int k = 0;

            while(j <= La.GetLength() - 1 && k <= Lb.GetLength() - 1)
            {
                if (La[j] <= Lb[k])
                {
                    Lc.Append(La[j]);
                    j++;
                }
                else
                {
                    Lc.Append(Lb[k]);
                    k++;
                }
            }

            while(j <= La.GetLength() -1)
            { 
                Lc.Append(La[j]);
                j++;
            }

            while(k <= Lb.GetLength() -1)
            {
                Lc.Append(Lb[k]);
                k++;
            }

            return Lc;
        }

        public SequenceList<int> DeduplicateListHelp(SequenceList<int> list)
        {
            SequenceList<int> result = new SequenceList<int>(list.GetLength() - 1);
            if (list.GetLength() >= 1)
            {
                int currentValue = list[0];
                result.Append(currentValue);
                for (int i = 1; i <= list.GetLength() - 1; i++)
                {
                    if (list[i] > currentValue)
                    {
                        currentValue = list[i];
                        result.Append(currentValue);
                    }
                }
            }
            return result;
        }

        [TestMethod()]
        public void RevertList()
        {
            SequenceList<int> target = new SequenceList<int>();
            target.Append(11);
            target.Append(23);
            target.Append(36);
            target.Append(45);
            target.Append(80);
            target.Append(60);
            target.Append(40);
            target.Append(6);

            this.RevertListHelp(target);
        }

        [TestMethod()]
        public void MergeList()
        {
            SequenceList<int> la = new SequenceList<int>();
            la.Append(11);
            la.Append(23);
            la.Append(36);
            la.Append(45);
            la.Append(80);
            la.Append(160);
            la.Append(240);
            la.Append(600);

            SequenceList<int> lb = new SequenceList<int>();
            lb.Append(1);
            lb.Append(2);
            lb.Append(6);
            lb.Append(15);
            lb.Append(500);
            lb.Append(700);

            SequenceList<int> lc = MergeListHelp(la, lb);
        }

        [TestMethod()]
        public void DeduplicateList()
        {
            SequenceList<int> la = new SequenceList<int>();
            la.Append(11);
            la.Append(23);
            la.Append(23);
            la.Append(45);
            la.Append(45);
            la.Append(160);
            la.Append(240);
            la.Append(240);

            SequenceList<int> lc = this.DeduplicateListHelp(la);
        }
    }
}
