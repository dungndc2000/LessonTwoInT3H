using System;

namespace taolao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine()); tong += array[i];

            }
            Console.WriteLine(tong);
        }
    }
}
