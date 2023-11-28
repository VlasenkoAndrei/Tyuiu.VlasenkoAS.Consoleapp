using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab4.V8.Lib
{
    public class DataService
    {
        public bool GetPointShape(double x, double y)
        {
            if (Math.Pow(x, 2) <= y && y <= 4.0 && x > 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
