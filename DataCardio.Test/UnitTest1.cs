using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod] //1
        [DataRow("w", "non puoi inserire delle lettere", null)]
        [DataRow("10", "189", "147")]
        [DataRow("0", "attenzione non puoi inserire un eta uguale a 0 o inferiore", null)]
        public void TestMethod1(string eta, string max, string min)
        {
            string min2 = "";
            string max2 = CardioanalisiLibrary.DataCardio.frequenzaMax_min(eta, ref min2);

            if (max2 == "non puoi inserire delle lettere")
            {
                Assert.AreEqual(max, max2);
            }
            else if (max2 == "attenzione non puoi inserire un eta uguale a 0 o inferiore")
            {
                Assert.AreEqual(max, max2);
            }
            else
            {
                Assert.AreEqual(min, min2);
                Assert.AreEqual(max, max2);
            }

        }
    }
}
