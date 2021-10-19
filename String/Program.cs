using System;
using System.Linq;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string hoten = "";
            hoten = Console.ReadLine();

            //B1: Đưa về thường và xóa khoảng trắng 2 đầu chuỗi
            hoten = hoten.ToLower().Trim();

            //B2:Xóa khoảng trắng giữa 2 từ
            //B3 Viết xóa kí tự đầu
            string[] array = hoten.Split(' ').ToArray();
            hoten = "";
            foreach (var str in array)
            {
                if (string.IsNullOrEmpty(str))
                {
                    continue;
                }
                string str0 = str.Trim();
                if (str0.Length > 1)
                {
                    hoten += str0[0].ToString().ToUpper() + str0.Substring(1) + " ";
                }
                else
                {
                    hoten = str0;
                }
            }

            Console.WriteLine("Ho ten sau khi chuan hoa la:{0}",hoten);

        }
    }
}
