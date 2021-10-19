using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOOp
{
    public class Test
    {
        public int _TuSo { get; set; }
        public int _MauSo { get; set; }

        public Test(int TuSo,int MauSo)
        {
            _TuSo = TuSo;
            _MauSo = MauSo;
        }
        
        public static Test Input()
        {
            Console.InputEncoding = Encoding.UTF8;
           
                Console.WriteLine("Nhập tử số {:");
               int  tuso = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập mẫu số :");
               int  mauso = int.Parse(Console.ReadLine());               
           
            Test T = new Test(tuso, mauso);
            return T;
        }

        public void Display(Test T)
        {           
            Console.WriteLine("Phan so :   {0}/{1}",T._TuSo,T._MauSo);
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Test> TeT = new List<Test>();
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            //int tong = 0;
            for (int i = 0; i < n; i++)
            {
                Test TestOne = Input();
                TeT.Add(TestOne);
            }

            foreach (var item in TeT)
            {
                item.Display(item);
            }

        }
    }
}
