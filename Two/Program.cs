using System;
using System.Collections.Generic;
using System.Text;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UocN
            Console.OutputEncoding = Encoding.UTF8;
            int dem = 0;
            Console.WriteLine("Nhập n:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0 || n >999)
            {
                Console.WriteLine("Mời nhập lại n:");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("{0} có số ước là: {1}",n,dem);
            #endregion
            //int n = int.Parse(Console.ReadLine());
            //while (n <= 0 )
            //{
            //    Console.WriteLine("Mời bạn nhập lại:");
            //    n = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j >= 0; j--)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine("");
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write("*");

            //    }
            //    Console.WriteLine("");
            //}
        }
    }
}
