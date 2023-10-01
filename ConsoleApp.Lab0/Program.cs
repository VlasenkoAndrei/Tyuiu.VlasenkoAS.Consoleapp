using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab0.V0.Lib;

namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab0
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Введение значение переменной К");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введение значение переменной W");
            int w = Convert.ToInt32(Console.ReadLine());
            
            DataService solve = new DataService();

            var resultAdd = solve.Add(k, w);
            var resultMinus = solve.Minus(k, w);
            var resultMultiply = solve.Multiply(k, w);
            var resultDivide = solve.Divide(k, w);

            Console.WriteLine("Сумма K + W = " + resultAdd);
            Console.WriteLine("Разница K - W = " + resultMinus);
            Console.WriteLine("Произведение K * W = " + resultMultiply);
            Console.WriteLine("Деление K / W = " + resultDivide);

            Console.ReadKey();
        }
    }
}