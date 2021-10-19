using System;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int dem = 0;
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

            Console.Write("So nguyen to trong mang la:");
            for (int i = 0; i < n; i++)
            {             
                    int Uoc = 0;
                    for (int j = 2; j < array[i]; j++)
                    {
                        if (array[i] % j == 0)
                        {
                            Uoc++;
                        }
                    }
                    if (Uoc == 0)
                    {
                        dem++;
                        Console.Write(array[i]+ "   ");
                    }                 
            }
            Console.WriteLine("");
            Console.WriteLine("Soluong so ng to la:{0}",dem);
           





        }
    }
}
