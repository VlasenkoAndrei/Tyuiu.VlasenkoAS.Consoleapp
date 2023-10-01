
namespace Tyuiu.VlasenkoAS.ConsoleApp.Lab1.V8.Lib
{
    public class DataService
    {
        public double SolveExpressV_8_1(double x, double y, double a)
        {
            double result = 5 * y + (4 + 2 * a) / (x - 7 * y) + ((a + 1) / (y - 3)) / ((3 * a) / x);
            return result;
        }

        public double SolveExpressV_8_2(double x, double y, double a)
        {
            double result = (2 * a) / y + 4 * x + (2 - 3 * a) / (x - 7 * y) + ((a - 3) / (x + 3)) / ((3 * a) / (x - 1));
            return result;
        }

    }
}
