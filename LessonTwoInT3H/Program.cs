using System;
using System.Text;

namespace LessonTwoInT3H
{
    class Program
    {
        static void Main(string[] args)
        {

            //MaxTwo();
            MaxThree();
        }

        #region MaxTwo
        private static void MaxTwo()
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            Console.WriteLine("Nhập a:");
            a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("Mời bạn nhập lại a:");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhập b:");
            b = int.Parse(Console.ReadLine());
            while (b < 0)
            {
                Console.WriteLine("Mời bạn nhập lại b:");
                b = int.Parse(Console.ReadLine());
            }
            if (a == b)
            {
                Console.WriteLine("Hai số này bằng nhau");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("Giá trị lớn nhất giữa 2 số là: {0}", a);
                }
                else
                {
                    Console.WriteLine("Giá trị lớn nhất giữa 2 số là: {0}", b);
                }

            }
        }
        #endregion

        #region MaxThree
        private static void MaxThree()
        {
            
            Console.OutputEncoding = Encoding.UTF8;
            int a, b, c ;
            Console.WriteLine("Nhập a:");
            a = int.Parse(Console.ReadLine());
            while (a < 0)
            {
                Console.WriteLine("Mời bạn nhập lại a:");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhập b:");
            b = int.Parse(Console.ReadLine());
            while (b < 0)
            {
                Console.WriteLine("Mời bạn nhập lại b:");
                b = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Nhập c:");
            c = int.Parse(Console.ReadLine());
            while (c < 0)
            {
                Console.WriteLine("Mời bạn nhập lại b:");
                c = int.Parse(Console.ReadLine());
            }
            if ((a > b) && (a >c))
            {
                Console.WriteLine("Giá trị lớn nhất là {0}",a);
            }
            else if ((b >a) && (b > c))
            {
                Console.WriteLine("Giá trị lớn nhất là {0}", b);
            }
            else if ((c > a) && (c > b))
            {
                Console.WriteLine("Giá trị lớn nhất là {0}", c);
            }

            
        }
        

        #endregion
    }
}
