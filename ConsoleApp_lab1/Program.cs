using System;
namespace ConsoleApp_lab1
{
    public class Program
    {
        public static double Calculate1(double x, double y, double a)
        {
            return 12 * a + ((a / y) / ((3 * a + x * a) / x)) * ((3 * x + 2 * a + a) / (3 * a + 2 * x - y)) + 12 * x;
        }

        public static double Calculate2(double x, double y, double a)
        {
            return 10 * x - ((3 * x + 2 * a - a) / (3 * a + 2 * x + y)) + ((a * y * x / (3 * y)) / (3 * a / x)) - 2 * x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("значение a:");
            double a = Convert.ToDouble(Console.ReadLine());

            double z1 = Calculate1(x, y, a);
            double z2 = Calculate2(x, y, a);

            Console.WriteLine($"выражение 1: z = {z1}");
            Console.WriteLine($"выражение 2: z = {z2}");
        }
    }
}

