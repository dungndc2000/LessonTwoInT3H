using System;
using System.Text;

namespace ChuviDientichHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Calculator Ca = new Calculator();
            Ca.Input();
            Ca.Display();
            Console.WriteLine("Chu vi hình tròn là :" + Ca.Chuvi());
            Console.WriteLine("Diên tích hình tròn là:" + Ca.Dientich());
        }
    }
}
