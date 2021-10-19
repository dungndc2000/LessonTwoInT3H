using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            while (n <=0 )
            {
                Console.WriteLine("Nhap lai");
                n = int.Parse(Console.ReadLine());
            }

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]= " ,i);
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n-1; i >= 0 ; i--)
            {
                Console.Write(array[i]);
                if (i > 0)
                {
                    Console.Write(",");
                }
            }
        }
    }
}
