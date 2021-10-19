using System;

namespace N_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int tich = 1;
            Console.Write("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Nhap lai n");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                tich *= i;
            }
            Console.WriteLine("{0} giai thua co gtri la: {1}",n,tich);
        }
    }
}
