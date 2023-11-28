using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab4.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        double x = 2.0;
        double y = 4.0;
        bool wait = true;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidGetPoint()
        {
            bool result = ds.GetPointShape(x, y);
            Assert.AreEqual(wait, result);

        }
    }
}
