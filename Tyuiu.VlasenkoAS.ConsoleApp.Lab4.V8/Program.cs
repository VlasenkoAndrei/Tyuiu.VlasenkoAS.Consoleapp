using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab4.V8.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab4.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введение значение переменной X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введение значение переменной Y");
            double y = Convert.ToDouble(Console.ReadLine());

            DataService ds = new DataService();

            bool result = ds.GetPointShape(x, y);

            if (result)
            {
                Console.WriteLine("Точка содержится в границах фигуры");
            }
            else
            {
                Console.WriteLine("Точка находится за границами фигуры");
            }

            Console.ReadKey();
        }
    }
}
