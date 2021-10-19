using System;
using System.Text;

namespace HinhHocVersion2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chào mừng bạn đến với máy tính tào lao♥");

            Continue:
            Console.WriteLine("Nhập hình bạn muốn tính!");
            Console.WriteLine("1.Hình lập phương");
            Console.WriteLine("2.Hình chữ nhật");
            Console.WriteLine("3.Hình tam giác");
            Console.WriteLine("4.Hình tròn");
            Console.WriteLine("5.Hình vuông");
            Console.WriteLine("6.Thoát");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    HinhLapPhuong HLP = new HinhLapPhuong();
                    HLP.Input();
                    Console.WriteLine("Diện tích hình lập phương là:{0}",HLP.Dientich());
                    Console.WriteLine("Thể tích hình lập phương là:{0}",HLP.TinhTheTich());
                    break;

                case 2:
                    Hinhchunhat HCN = new Hinhchunhat();
                    HCN.Input();
                    Console.WriteLine("Chu vi hình chữ nhật là:{0}", HCN.Tinhchuvi());
                    Console.WriteLine("Diện tích hình chữ nhật là:{0}", HCN.Dientich());
                    break;

                case 3:
                    Hinhtg HTG = new Hinhtg();
                    HTG.Input();
                    Console.WriteLine("Chu vi hình tam giác là:{0}", HTG.Tinhchuvi());
                    Console.WriteLine("Diện tích hình tam giác là:{0}", HTG.Dientich());
                    break;

                case 4:
                    Hinhtron HT = new Hinhtron();
                    HT.Input();
                    Console.WriteLine("Chu vi hình tròn là:{0}", HT.Dientich());
                    Console.WriteLine("Diện tích hình tròn là:{0}", HT.Tinhchuvi());
                    break;

                case 5:
                    Hinhvuong HV = new Hinhvuong();
                    HV.Input();
                    Console.WriteLine("Chu vi hình vuông là:{0}", HV.Tinhchuvi());
                    Console.WriteLine("Diện tích hình vuông là:{0}", HV.Dientich());
                    break;

                default:
                    Console.WriteLine("Cám ơn bạn đã sử dụng sản phẩm này!");
                    break;
            }

            Console.WriteLine("Bạn có muốn tiếp tục:");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            int a = int.Parse(Console.ReadLine());
            if (a == 2 )
            {
                Console.WriteLine("Say bye!!!");                             
            }
            else if ( a == 1)
            {
                goto Continue;
            }
        }
    }
}
