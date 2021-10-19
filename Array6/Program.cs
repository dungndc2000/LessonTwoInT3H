using System;

namespace Array6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Nhap lai");
                n = int.Parse(Console.ReadLine());
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Gia tri nho nhat trong mang la:{0}", min);
            for (int i = 0; i < n; i++)
            {
                if (array[i] == min)
                {
                    Console.WriteLine("Vi tri so min la : {0}", i);
                }
            }
        }
    }
}
