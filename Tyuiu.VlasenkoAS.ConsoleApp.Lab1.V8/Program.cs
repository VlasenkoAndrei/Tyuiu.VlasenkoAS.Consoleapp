using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #1 | Выполнил: Власенко А. С. | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #1                                                  *");
            Console.WriteLine("* Расчёты арифметических и математических выражений в C#                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Власенко Андрей Сергеевич | НТм-22-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая выполняет расчёты          *");
            Console.WriteLine("* арифметических и математических выражений.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x = 10;
            double y = 5;
            double a = -10;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("a = " + a);

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_8_1(x, y, a);
            double result2 = ds.SolveExpressV_8_2(x, y, a);

            result1 = Math.Round(result1, 2);
            result2 = Math.Round(result2, 2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" 1-е выражение: " + result1);
            Console.WriteLine(" 2-е выражение: " + result2);
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
