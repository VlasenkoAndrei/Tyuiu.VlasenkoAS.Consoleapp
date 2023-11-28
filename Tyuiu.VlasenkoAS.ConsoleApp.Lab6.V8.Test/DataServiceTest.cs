using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab6.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        int start = -5;
        int end = 5;

        DataService ds = new DataService();

        [TestMethod]
        public void ValidMassFunction()
        {
            double[] waitArray = new double[11] { -4.65, -12.32, -299.68, -0.39, -3.41, 0.00, -5.29, -6.74, -1.58, -12.99, -7.39 };

            double[] result = ds.GetMassFunction(start, end);
            Assert.AreEqual(waitArray, result);
        }
    }
}
