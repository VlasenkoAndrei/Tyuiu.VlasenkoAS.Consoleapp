using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab5.V8.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введение значение переменной N");
            int n = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();

            double result = ds.GetSum(n);

            Console.WriteLine("Конечная сумма равна " + result);

            Console.ReadKey();
        }
    }
}
