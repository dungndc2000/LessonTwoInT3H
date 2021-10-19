using System;

namespace OOPPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SoPhuc soThuc1 = new SoPhuc(10, 20);
            SoPhuc soThuc2 = new SoPhuc(30, 40);
            double t = 50;
            SoPhuc Ketqua;
            Ketqua = soThuc1.Cong(soThuc2);
            Console.WriteLine("TOng 2 so thuc");
            Ketqua.Display();

            Ketqua = soThuc1.Cong(t);
            Console.WriteLine("TOng 2 so thuc");
            Ketqua.Display();

            //Ketqua = SoPhuc.Cong(soThuc1, soThuc2);
        }
    }
}
