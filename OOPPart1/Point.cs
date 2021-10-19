using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPart1
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Display()
        {
            Console.Write("Toa do:(");
            Console.Write("{0} {1}",x,y);
            Console.Write(")");
        }

        public void Trade()
        {
            //x = -x;
            //y = -y;
            Console.WriteLine("X = {0},Y= {1}",(-x),(-y));
        }

        public void Input()
        {
            Console.WriteLine("Nhap toa do:");
            Console.WriteLine("X = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Y = ");
            y = int.Parse(Console.ReadLine());
        }

        public void Move(int x0,int y0)
        {
            Console.WriteLine("Sau khi dich chuyen la: X = {0},Y = {1}", x += x0, y += y0);
            //x += x0;
            //y += y0;
            
        }
    }
}
