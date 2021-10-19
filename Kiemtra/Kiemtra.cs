using System;
using System.Collections.Generic;
using System.Text;

namespace Kiemtra
{
    class Kiemtra
    {
        public double _CanhOne { get; set; }
        public double _CanhTwo { get; set; }
        public double _CanhThree { get; set; }

        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
        TIEPTUC:
            try
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.WriteLine("Nhập cạnh 1:");
                _CanhOne = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập cạnh 2:");
                _CanhTwo = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập cạnh 3:");
                _CanhThree = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Tào lao nhập lai");
                goto TIEPTUC;
            }
        }

        public void Display()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Cạnh 1 là: {0}", _CanhOne);
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Cạnh 2 là: {0}", _CanhTwo);
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Cạnh 3 là: {0}", _CanhThree);

        }

        public void KiemTra()
        {
            Console.InputEncoding = Encoding.UTF8;
            if ((_CanhOne + _CanhTwo > _CanhThree) || (_CanhOne + _CanhTwo > _CanhThree) || (_CanhOne + _CanhTwo > _CanhThree))
            {
                Console.WriteLine("Đây là 1 tam giác");
            }
            else
            {
                Console.WriteLine("Đây không phải 1 tam giác");
            }
        }

        public double Dientich()
        {
            double a = (_CanhOne + _CanhTwo + _CanhThree) / 2;
            return Math.Sqrt( a * (a - _CanhOne) * (a - _CanhTwo) * (a - _CanhThree)   );
        }
    }
}
