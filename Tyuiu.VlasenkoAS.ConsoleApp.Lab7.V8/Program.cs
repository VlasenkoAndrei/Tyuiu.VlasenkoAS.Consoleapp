using System;
using Tyuiu.VlasenkoAS.ConsoleApp.Lab7.V8.Lib;

namespace Tyuiu.VlasenkoAS.Consoleapp.Lab7.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt16(Console.ReadLine());
            int[] numsArray = new int[len];
            Random random = new Random();

            Console.WriteLine("Введите начало диапазона чисел в массиве: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона чисел в массиве: ");
            int end = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите число, наличие которого в массиве вы хотите проверить: ");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("****************************************");
            
            for (int i = 0; i < len; i++)
            {
                numsArray[i] = random.Next(start, end);
            }

            for (int i = 0; i < len; i++)
            {
                Console.Write(numsArray[i] + "\t");
            }

            Console.WriteLine("Количество отрицательных элементов: " + ds.GetNegativeNumArray(numsArray));
            Console.WriteLine("Количество положительных элементов: " + ds.GetPositiveNumArray(numsArray));
            Console.WriteLine("Количество четных элементов: " + ds.GetEvenNumArray(numsArray));
            Console.WriteLine("Количество нечетных элементов: " + ds.GetNotEvenNumArray(numsArray));
            Console.WriteLine("Число " + num + "находится в массиве: " + ds.GetNumArray(numsArray, num));
            Console.WriteLine("Среднее значение элементов массива равно: " + ds.GetMiddleNumArray(numsArray));
            Console.WriteLine("Минимальное значение элементов массива равно: " + ds.GetMinNumArray(numsArray));

            Console.ReadKey();
        }
    }
}
