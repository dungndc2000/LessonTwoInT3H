using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Boolean flag;
            for (int i = 0; i < n; i++)
            {
                Console.Write("array[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            int tg;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                flag = true;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.Write(a[i]);
                    if (i < n - 1)
                    {
                        Console.Write("-");
                    }
                }
                
            }


        }
    }
}
