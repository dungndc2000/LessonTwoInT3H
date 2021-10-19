using System;
using System.Text;

namespace TestOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Hinhchunhat HCN = new Hinhchunhat(20, 10);
            HinhTg HTG = new HinhTg(20, 15,22);
            Hinhtron HT = new Hinhtron(30);
            Hinhvuong HV = new Hinhvuong(5);

            Console.WriteLine("Chu vi hình chữ nhật là: {0}",HCN.Chuvi());
            Console.WriteLine("Diện tích hình chữ nhật là: {0}", HCN.DienTich());
            Console.WriteLine("==========================");

            Console.WriteLine("Chu vi hình tam giác là: {0}", HTG.Chuvi());
            Console.WriteLine("Diện tích hình tam giác là: {0}", HTG.DienTich());
            Console.WriteLine("==========================");

            Console.WriteLine("Chu vi hình tròn là: {0}", HT.Chuvi());
            Console.WriteLine("Diện tích hình tròn là: {0}", HT.DienTich());
            Console.WriteLine("==========================");

            Console.WriteLine("Chu vi hình vuông là: {0}", HV.Chuvi());
            Console.WriteLine("Diện tích hình vuông là: {0}", HV.DienTich());
            Console.WriteLine("==========================");
        }
    }
}
