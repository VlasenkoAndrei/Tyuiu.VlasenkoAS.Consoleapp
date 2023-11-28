using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab5.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int n = 3;
        double wait = 2.531;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidGetSum()
        {
            double result = ds.GetSum(n);
            Assert.AreEqual(wait, result);

        }
    }
}
