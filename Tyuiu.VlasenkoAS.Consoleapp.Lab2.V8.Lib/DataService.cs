using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab2.V8.Lib
{
    public class DataService
    {
        public double SolveExpressV_8_1(double x, double y)
        {
            double result = x * Math.Log(x) + y / (Math.Cos(x) - x / 3);
            return result;
        }

        public double SolveExpressV_8_2(double x, double y)
        {
            double result = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - 2 * x / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))));
            return result;
        }

    }
}
