using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab3.V0.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab3.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введение значение переменной X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введение значение переменной Y");
            int y = Convert.ToInt32(Console.ReadLine());

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
