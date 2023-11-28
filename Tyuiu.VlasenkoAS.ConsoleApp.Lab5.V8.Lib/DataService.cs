using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab5.V8.Lib
{
    public class DataService
    {
        public double GetSum(int n)
        {
            double result = 0;

            for (int x = 1; x <= n; x++)
            {
                result += (Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / Math.Pow(3, x);
            }

            return Math.Round(result, 3);
        }
    }
}
