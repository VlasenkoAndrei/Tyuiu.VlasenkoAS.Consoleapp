using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V0.Lib
{
    public class DataService
    {
        public bool GetPointShape(int x, int y)
        {
            if (x >= -3 && x <= 3 && y >= -3 && y <= 3)
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
