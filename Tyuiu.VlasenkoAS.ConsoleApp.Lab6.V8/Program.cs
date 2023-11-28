using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab6.V8.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int start = -5;
            int end = 5;

            int lenght = ds.GetMassFunction(start, end).Length;
            double[] valueArray = new double[lenght];
            valueArray = ds.GetMassFunction(start, end);
  
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Старт шага = " + start);
            Console.WriteLine("Конец шага = " + end);
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------------------+");

            foreach (double value in valueArray)
            {
                if (Math.Cos(start) - start / 3 != 0 || Math.Cos(start) - Math.Sin(start) != 0)
                { 
                    Console.WriteLine("|{0,5:d}     |   {1,5:f1}   |", start, value);
                }
                else
                {
                    Console.WriteLine("Деление на 0 невозможно!");
                }

                start++;
            }

            Console.WriteLine("+----------------------+");

            Console.ReadKey();
        }
    }
}
