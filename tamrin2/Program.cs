using System;

namespace tamrin2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter x");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"adad bad az mohasebe = {mohasebe(x)}");

            static double mohasebe(int X)
            {
                int a = (int)(Math.Pow(X, 2) + (X * X) - 4);
                return a;
            }
            Console.ReadKey();

        }
    }
}
