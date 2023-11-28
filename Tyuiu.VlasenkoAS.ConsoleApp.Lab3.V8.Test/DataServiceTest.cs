using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int x = 5;
        int y = 5;
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
