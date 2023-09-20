using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tyuiu.Vlasenko.ConsoleApp.Lab0V0.Lib
{
    public class DataService
    {
        public int Add(int x, int y)
        {
            return x + y; 
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y) 
        {
            return x / y;
        }
    }
}
