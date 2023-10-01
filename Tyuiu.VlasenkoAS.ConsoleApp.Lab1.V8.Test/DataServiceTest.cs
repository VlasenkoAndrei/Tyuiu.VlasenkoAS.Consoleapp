using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        double x = 10;
        double y = 5;
        double a = -10;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidExpressionV_8_1()
        {
            double result = ds.SolveExpressV_8_1(x, y, a);

            result = Math.Round(result, 2);
            double wait = 27.14;

            Assert.AreEqual(result, wait);

        }

        [TestMethod]
        public void ValidExpressionV_582()
        {
            double result = ds.SolveExpressV_8_2(x, y, a);

            result = Math.Round(result, 2);
            double wait = 35.02;

            Assert.AreEqual(result, wait);

        }
    }
}
