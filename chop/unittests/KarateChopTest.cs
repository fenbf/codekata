using chop_c_sharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace learnUnitTests
{
    
    
    /// <summary>
    ///This is a test class for KarateChopTest and is intended
    ///to contain all KarateChopTest Unit Tests
    ///</summary>
    [TestClass()]
    public class KarateChopTest
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
        ///A test for chop
        ///</summary>
        [TestMethod()]
        public void chopTest()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(0, KarateChop.chop(0, values));
            Assert.AreEqual(1, KarateChop.chop(1, values));
            Assert.AreEqual(2, KarateChop.chop(2, values));
            Assert.AreEqual(3, KarateChop.chop(3, values));
            Assert.AreEqual(-1, KarateChop.chop(6, values));
            Assert.AreEqual(-1, KarateChop.chop(1, null));
            Assert.AreEqual(-1, KarateChop.chop(1, new int[]{}));
        }

        /// <summary>
        ///A test for chop2, same as for chop
        ///</summary>
        [TestMethod()]
        public void chop2Test()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(0, KarateChop.chop2(0, values));
            Assert.AreEqual(1, KarateChop.chop2(1, values));
            Assert.AreEqual(2, KarateChop.chop2(2, values));
            Assert.AreEqual(3, KarateChop.chop2(3, values));
            Assert.AreEqual(-1, KarateChop.chop2(6, values));
            Assert.AreEqual(-1, KarateChop.chop2(1, null));
            Assert.AreEqual(-1, KarateChop.chop2(1, new int[] { }));
        }

        /// <summary>
        ///A test for chopSlice
        ///</summary>
        [TestMethod()]
        public void chopSliceTest()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(0, KarateChop.chopSlice(0, values));
            Assert.AreEqual(1, KarateChop.chopSlice(1, values));
            Assert.AreEqual(2, KarateChop.chopSlice(2, values));
            Assert.AreEqual(3, KarateChop.chopSlice(3, values));
            Assert.AreEqual(-1, KarateChop.chopSlice(6, values));
            Assert.AreEqual(-1, KarateChop.chopSlice(1, null));
            Assert.AreEqual(-1, KarateChop.chopSlice(1, new int[] { }));
        }

        /// <summary>
        ///A test for chopSlice2
        ///</summary>
        [TestMethod()]
        public void chopSlice2Test()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(0, KarateChop.chopSlice2(0, values));
            Assert.AreEqual(1, KarateChop.chopSlice2(1, values));
            Assert.AreEqual(2, KarateChop.chopSlice2(2, values));
            Assert.AreEqual(3, KarateChop.chopSlice2(3, values));
            Assert.AreEqual(-1, KarateChop.chopSlice2(6, values));
            Assert.AreEqual(-1, KarateChop.chopSlice2(1, null));
            Assert.AreEqual(-1, KarateChop.chopSlice2(1, new int[] { }));
        }

        /// <summary>
        ///A test for chopGeneric
        ///</summary>
        [TestMethod()]
        public void chopGenericTest()
        {
            int[] values = { 0, 1, 2, 3, 4, 5 };
            Assert.AreEqual(0, KarateChop.chopGeneric<int>(0, values));
            Assert.AreEqual(1, KarateChop.chopGeneric<int>(1, values));
            Assert.AreEqual(2, KarateChop.chopGeneric<int>(2, values));
            Assert.AreEqual(3, KarateChop.chopGeneric<int>(3, values));
            Assert.AreEqual(-1, KarateChop.chopGeneric<int>(6, values));
            Assert.AreEqual(-1, KarateChop.chopGeneric<int>(1, null));
            Assert.AreEqual(-1, KarateChop.chopGeneric<int>(1, new int[] { }));
        }
    }
}
