using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V0.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int x = -3;
        int y = -3;
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
