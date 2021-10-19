using System;
using System.Collections.Generic;
using System.Text;

namespace HinhHocVersion2
{
    public class Hinhtron : Abs, IChuVi
    {
        public double _bankinh { get; set; }

        public override double Dientich()
        {
            return (_bankinh * _bankinh * Math.PI);
        }

        public override void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập bán kính hình tròn:");
            _bankinh = double.Parse(Console.ReadLine());
            while (_bankinh <= 0)
            {
                Console.WriteLine("Nhập lại:");
                _bankinh = double.Parse(Console.ReadLine());
            }
        }

        public double Tinhchuvi()
        {
            return (_bankinh * 2 * Math.PI);
        }

      
    }
}
