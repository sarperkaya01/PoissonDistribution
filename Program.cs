using System;

namespace PoissonDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((lambK(a, b) * (1 / eLamb(a))) / Factorial(b));
            Console.ReadLine();
        }
        public static double eLamb(double a)
        {
            double e = 2.718281;
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return e * eLamb(a - 1);
            }
        }
        public static double Factorial(double num)
        {

            if (num == 1)
            {
                return 1;
            }

            else
            {
                return num * Factorial(num - 1);
            }
        }
        public static double lambK(double a, double b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * lambK(a, b - 1);
            }
        }
    }
}
