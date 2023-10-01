using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab2.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        double x = 5;
        double y = 15;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidExpressionV_8_1()
        {
            double result = ds.SolveExpressV_8_1(x, y);

            result = Math.Round(result, 14);
            double wait = -2.79876227953831;

            Assert.AreEqual(result, wait);

        }

        [TestMethod]
        public void ValidExpressionV_582()
        {
            double result = ds.SolveExpressV_8_2(x, y);

            result = Math.Round(result, 15);
            double wait = 0.261990672747836;

            Assert.AreEqual(result, wait);

        }
    }
}
