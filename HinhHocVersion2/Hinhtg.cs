using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHocVersion2
{
    public class Hinhtg : Abs,IChuVi
    {
        public double _canhtg1 { get; set; }
        public double _canhtg2 { get; set; }
        public double _canhtg3 { get; set; }

        public double Tinhchuvi()
        {
            return _canhtg1 + _canhtg2 + _canhtg3;
        }
        public override double Dientich()
        {
            double a = Tinhchuvi() / 2;
            return Math.Sqrt(a * (a - _canhtg1) * (a - _canhtg2) * (a - _canhtg3));
        }

        public override void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Mời bạn nhập cạnh đầu tiên của tam giác:");
            _canhtg1 = double.Parse(Console.ReadLine());
            while (_canhtg1 <= 0)
            {
                Console.Write("Nhập lại:");
                _canhtg1 = double.Parse(Console.ReadLine());
            }
            Console.Write("Mời bạn nhập cạnh thứ hai của tam giác:");
            _canhtg2 = double.Parse(Console.ReadLine());
            while (_canhtg2 <= 0)
            {
                Console.Write("Nhập lại:");
                _canhtg2 = double.Parse(Console.ReadLine());
            }
            Console.Write("Mời bạn nhập cạnh thứ ba của tam giác:");
            _canhtg3 = double.Parse(Console.ReadLine());
            while (_canhtg3 <= 0)
            {
                Console.Write("Nhập lại:");
                _canhtg3 = double.Parse(Console.ReadLine());
            }

        }
        
    }
}
