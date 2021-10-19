using System;
using System.Text;

namespace Songto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.UTF8;
            #region Songto
            //int n = int.Parse(Console.ReadLine());
            //int dem = 0;
            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        dem++;
            //    }
            //}
            //if (dem == 2)
            //{
            //    Console.WriteLine("Số này  là số nguyên tố");              
            //}
            //else if(dem != 2 )
            //{
            //    Console.WriteLine("Đây không là số nguyên tố");

            //}
            #endregion

            #region Sohoanhao
            //int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            //for (int i = 1; i < n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        tong += i;
            //    }
            //}
            //if (tong == n)
            //{
            //    Console.WriteLine("Đây là số hoàn hảo");
            //} else
            //{
            //    Console.WriteLine("Đây kp số hoàn hảo");
            //}


            #endregion

            #region  Sochinhphuong
            //int n = int.Parse(Console.ReadLine());
            //double a = Math.Sqrt(n);
            //if (a * a == n)
            //{
            //    Console.WriteLine("Đây là số chính phương");
            //}
            //else
            //{
            //    Console.WriteLine("Đây k là số chính phương");
            //}
            #endregion

            #region DayFibo
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", Fibo(i));
            }

            #endregion
        }
        private static int Fibo(int n)
        {
            int f0 = 0;
           int  f1 = 1;
           int  f2 = 1;
            if (n < 0)
            {
                return -1;
               
            }
            else if(n==0 || n == 1)
            {
                return n;
            } else
            {
                for (int i = 0; i < n; i++)
                {
                    f0 = f1;
                    f1 = f2;
                    f2 = f0 + f1;
                }
            }
            return f2;
        }
    }
}
