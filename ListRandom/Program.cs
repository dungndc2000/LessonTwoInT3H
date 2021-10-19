using System;
using System.Collections.Generic;

namespace ListRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Input();
            
        }

        private static void Input()
        {
            List<int> Numbers = new List<int>();
            
            int n = int.Parse(Console.ReadLine());
            Console.Write("Cac so trong danh sach la:");
            for (int i = 0; i < n; i++)
            {
                Random IntRandom = new Random();
                Numbers.Add(IntRandom.Next(1, 1000));
            }
                Display(Numbers);

            List<int> snt = new List<int>();
            foreach (var item in Numbers)
            {
                if (KTSNT(item))
                {
                    snt.Add(item);
                }
            }

            
        }

      
        private static bool KTSNT(int num)
        {
            if (num == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void Display(List<int> Songto)
        {
            Console.WriteLine("Cac so trong danh sach la:");
            foreach (var item in Songto)
            {
                Console.WriteLine(item + "  ");
            }
            Console.WriteLine("  ");
        }
    }
}
