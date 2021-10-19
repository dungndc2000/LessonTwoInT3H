using System;

namespace Aray4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Nhap lai");
                n = int.Parse(Console.ReadLine());
            }
            
            int[] array = new int[n];
            int[] array1 = new int[100];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            
            int max = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        array1[i]++;
                    }
                   
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] > max)
                {
                    max = array1[i];
                }
                
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] == max)
                {
                    Console.WriteLine("So xuat hien trong mang nhieu nhat la: {0}", array[i]);
                }
            }


        }
    }
}
