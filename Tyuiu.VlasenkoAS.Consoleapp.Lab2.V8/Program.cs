using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab2.V8.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Лабораторная работа #2 | Выполнил: Власенко А. С. | НТм-22-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Лабораторная работа #2                                                  *");
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

            double x = 5;
            double y = 15;

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            DataService ds = new DataService();

            double result1 = ds.SolveExpressV_8_1(x, y);
            double result2 = ds.SolveExpressV_8_2(x, y);

            result1 = Math.Round(result1, 14);
            result2 = Math.Round(result2, 15);

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
