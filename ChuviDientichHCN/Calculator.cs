using System;
using System.Collections.Generic;
using System.Text;

namespace ChuviDientichHCN
{
    class Calculator
    {
        public double _bankinh { get; set; }
        


        public void Input()
        {
            Console.InputEncoding = Encoding.UTF8;
        TIEPTUC:
            try { 
                            
                Console.WriteLine("Nhập bán kính:");
                _bankinh = double.Parse(Console.ReadLine());           
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
            Console.WriteLine("Bán kính là: {0}",_bankinh);
            
        }

        public double Chuvi()
        {
            return _bankinh * 2 * Math.PI;
        } 

        public double Dientich()
        {
            return _bankinh * _bankinh * Math.PI;
        }

       
    }
}
