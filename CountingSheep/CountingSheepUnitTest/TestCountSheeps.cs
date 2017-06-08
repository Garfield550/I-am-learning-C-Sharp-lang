using CountingSheep;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CountingSheepUnitTest
{
    [TestClass()]
    public class TestCountSheeps
    {
        [TestMethod()]
        public void CountTest()
        {
            var sheeps = new bool[] { true, false, true };
            Assert.AreEqual(2, CountSheeps.Count(sheeps));

            sheeps = new bool[] { true, false, true, true, false, true, true, false, true };
            Assert.AreEqual(6, CountSheeps.Count(sheeps));

            sheeps = new bool[] { true, true, true, true, true, true, true, true, true };
            Assert.AreEqual(9, CountSheeps.Count(sheeps));

            sheeps = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };
            Assert.AreEqual(0, CountSheeps.Count(sheeps));
        }
    }
}
