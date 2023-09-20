using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.Vlasenko.ConsoleApp.Lab0V0.Lib;


namespace Tyuiu.Vlasenko.ConsoleApp.Lab0V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int a = 15;
        int b = 5;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidCalc()
        {
            var resAdd = ds.Add(a, b);
            Assert.AreEqual(20, resAdd);
        }

        [TestMethod]
        public void ValidMinus()
        {
            var resMinus = ds.Minus(a, b);

            Assert.AreEqual(10, resMinus);
        }

        [TestMethod]
        public void ValidMultiply()
        {
            var resMultiply = ds.Multiply(a, b);

            Assert.AreEqual(75, resMultiply);
        }

        [TestMethod]
        public void ValidDivide()
        {
            var resDivide = ds.Divide(a, b);

            Assert.AreEqual(3, resDivide);
        }
    }
}
