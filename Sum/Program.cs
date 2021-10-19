using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tong = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    tong = (i + n) * (1 - ((j + i) * (1 / j)));
                }
            }
            Console.WriteLine(tong);
        }
    }
}
