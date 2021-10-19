using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHocVersion2
{
    public class HinhLapPhuong : Abs, ITheTich
    {
        public double _canh { get; set; }
        public override double Dientich()
        {
            return _canh * _canh * 4;
        }
        public override void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời bạn nhập cạnh hình lập phương:");
            _canh = double.Parse(Console.ReadLine());
            while (_canh <= 0 )
            {
                Console.WriteLine("Nhập lại:");
                _canh = double.Parse(Console.ReadLine());
            }
        }

        public double TinhTheTich()
        {
            return _canh * _canh * _canh;
        }
    }
}
