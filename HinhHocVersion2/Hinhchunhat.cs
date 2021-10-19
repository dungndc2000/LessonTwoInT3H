using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHocVersion2
{
    public class Hinhchunhat : Abs, IChuVi
    {
        public double _chieudai { get; set; }
        public double _chieurong { get; set; }
        public override double Dientich()
        {
            return _chieudai * _chieurong;
        }

        public override void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời bạn nhập chiều dài:");
            _chieudai = double.Parse(Console.ReadLine());
            while (_chieudai <= 0)
            {
                Console.Write("Nhập lại:");
                _chieudai = double.Parse(Console.ReadLine());
                Console.Write("Mời bạn nhập chiều rộng:");               
            }
            Console.Write("Mời bạn nhập chiều rộng:");
            _chieurong = double.Parse(Console.ReadLine());
            while (_chieurong <= 0)
            {
                Console.Write("Nhập lại:");
                _chieurong = double.Parse(Console.ReadLine());
            }

        }
        public double Tinhchuvi()
        {
            return (_chieurong + _chieudai) * 2;
        }


    }
}
