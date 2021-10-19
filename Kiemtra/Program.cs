using System;
using System.Text;

namespace Kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.InputEncoding = Encoding.UTF8;
            Kiemtra KT = new Kiemtra();
            KT.Input();
            KT.Display();
            KT.KiemTra();
            Console.WriteLine("Diện tích tam giác là:" + KT.Dientich());
        }
    }
}
