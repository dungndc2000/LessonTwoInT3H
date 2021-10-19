using System;
using System.Collections;
using System.Collections.Generic;

namespace Coleection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Danhsach();
            
            
        }

        

        private static void Danhsach()
        {
        List<int> numbers = new List<int>();
            numbers.Add(1);
            Display(numbers);

            numbers.Add(2);
            Display(numbers);

            numbers.Insert(1, 3);
            Display(numbers);

            numbers.Sort((num1, num2) =>
            {
                return num1 > num2 ? -1 : (num1 < num2) ? 1 : 0;
            });
            Display(numbers);
        }
        

        private static void Display(List<int> numbers)
        {
            Console.WriteLine("Cac so trong llist la");
            foreach (int number in numbers)
            {
                Console.WriteLine(number + "  ");
            }
            Console.WriteLine("  ");

            Console.WriteLine();

            foreach (var item in numbers)
            {
                if (item == 2)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            Console.WriteLine("  ");

          
        }

    }

}
