using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab7.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int[] mass = { -1, 2, -3, 4, 8 };

        DataService ds = new DataService();

        [TestMethod]
        public void CheckedNegative()
        {
            int result = ds.GetNegativeNumArray(mass);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckedPositive()
        {
            int result = ds.GetPositiveNumArray(mass);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckedEven()
        {
            int result = ds.GetEvenNumArray(mass);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckedNotEven()
        {
            int result = ds.GetNotEvenNumArray(mass);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CheckedNumArray()
        {
            int num = 0;
            int result = ds.GetNumArray(mass, num);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void CheckedMiddleNumArray()
        {
            int result = ds.GetMiddleNumArray(mass);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CheckedMinNum()
        {
            int result = ds.GetMinNumArray(mass);
            Assert.AreEqual(-3, result);
        }
    }
}
