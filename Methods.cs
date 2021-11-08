namespace PoissonDistribution
{
    public class Methods
    {
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