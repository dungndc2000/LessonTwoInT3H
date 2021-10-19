using System;

namespace Arrray5
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
            int max = 0;
            int min = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Gia tri lon nhat trong mang la:{0}",max);
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    Console.WriteLine("Vi tri so max la : {0}",i);
                }
            }

            

        }
    }
}
