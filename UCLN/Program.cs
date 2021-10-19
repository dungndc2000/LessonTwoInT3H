using System;

namespace UCLN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int UCLN = 1;
            int BCNN ;
            for (int i = a; i >= 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    UCLN = i;
                    break;
                }
            }
            BCNN = (a * b) / UCLN;
            Console.WriteLine(UCLN);
            Console.WriteLine(BCNN);
        }
    }
}
