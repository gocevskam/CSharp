using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestNumberInArray
{
    [TestClass]
    public class UnitTest1
    {
        static int minvalue = int.MinValue;
        static int maxvalue = int.MaxValue;

        [TestMethod]
        public void TestMethod1()
        {
            int[] elements = { minvalue, maxvalue, 7, 2, minvalue};

            NumberAppearsInArray.x = minvalue;
            NumberAppearsInArray.NumberApperasinArray(elements);
        }
        public void testMeth2()
        {
            Assert.AreEqual(8, NumberAppearsInArray.counter);
            NumberAppearsInArray.counter =0;

        }
    }
}
