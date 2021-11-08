using System;

namespace PoissonDistribution
{
    class Program:Methods
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((lambK(a, b) * (1 / eLamb(a))) / Factorial(b));
            Console.ReadLine();
        }
        
    }
}
