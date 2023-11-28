using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab6.V8.Lib
{
    public class DataService
    {
        public double[] GetMassFunction(int start, int end)
        {
            int length = end - start + 1;
            double[] valueArray = new double[length];
            double value;
            int counter = 0;

            for (int x = start; x <= end; x++) 
            {
                if (Math.Cos(x) - x / 3 != 0 || Math.Cos(x) - Math.Sin(x) != 0)
                {
                    value = x / (Math.Cos(x) - x / 3) + (Math.Sin(Math.Pow(x, 2)) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x)) * Math.Tan(x);
                    valueArray[counter] = Math.Round(value, 2);
                }

                counter++;
            }

            return valueArray;
        }
    }
}
