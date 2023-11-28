using System;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V8.Lib
{
    public class DataService
    {
        public bool GetPointShape(int x, int y)
        {
            if (
                (x >= 3 && x <= 5 && y >= 3 && y <= 7) ||
                (x >= 6 && x <= 8 && y >= 5 && y <= 8) ||
                (x >= 9 && x <= 12 && y >= 3 && y <= 8) ||
                (x == 2 && y >= 5 && y <= 6) ||
                (x == 13 && y >= 6 && y <= 8) ||
                (x >= 11 && x <= 12 && y >= 9 && y <= 11) ||
                (x >= 12 && x <= 13 && y == 12) ||
                (x == 6 && y >= 9 && y <= 12) ||
                (x == 5 && y >= 9 && y <= 10) ||
                (x >= 4 && x <= 5 && y == 12) ||
                (x >= 2 && x <= 3 && y == 13)
                )
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
