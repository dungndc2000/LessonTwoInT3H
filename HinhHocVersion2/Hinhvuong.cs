using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHocVersion2
{
    public class Hinhvuong : Abs, IChuVi
    {
        public double _canh { get; set; }
        public override double Dientich()
        {
            return _canh * _canh;
        }

        public override void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời bạn nhập cạnh hình vuông:");
            _canh = double.Parse(Console.ReadLine());
            while (_canh <= 0)
            {
                Console.WriteLine("Nhập lại:");
                _canh = double.Parse(Console.ReadLine());
            }
        }

        public double Tinhchuvi()
        {
            return _canh * 4;
        }
    }
}
