using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.OutputEncoding = Encoding.UTF8;
            List<TuyenSinh> ts = new List<TuyenSinh>();
            Continue:
            Console.WriteLine("Thêm mới sinh viên");
            Continue1:
            Console.WriteLine("1.Khối A");
            Console.WriteLine("2.Khối B");
            Console.WriteLine("3.Khối C");
            Console.WriteLine("4.Thoát");
            Console.WriteLine("5.Hiển thị thông tin");
            Console.WriteLine("6.Tìm SBD");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    #region  Khoia
                    SinhVienKhoiA KhoiA = new SinhVienKhoiA();
                    KhoiA.Input();
                    KhoiA.InputNumber();
                    ts.Add(KhoiA);
                    Console.WriteLine("Mời chọn chức năng:");
                    Console.WriteLine("1.Hiển thị thông tin");
                    Console.WriteLine("2.Tìm kiếm theo sbd");
                    Console.WriteLine("3.Thêm sinh viên tiếp theo");
                    Console.WriteLine("4..Thoát");
                    
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            //KhoiA.Display();
                            foreach (var item in ts)
                            {
                                item.Display();
                            }
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int b = int.Parse(Console.ReadLine());
                            if (b == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 2:
                            KhoiA.Find();
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int c = int.Parse(Console.ReadLine());
                            if (c == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 3:
                            goto Continue1;
                            
                        default:
                            break;
                    }
                    break;
                #endregion
                case 2:
                    #region Khoib
                    SinhVienKhoiB KhoiB = new SinhVienKhoiB();
                    KhoiB.Input();
                    KhoiB.InputNumber();
                    ts.Add(KhoiB);
                    Console.WriteLine("Mời chọn chức năng:");
                    Console.WriteLine("1.Hiển thị thông tin");
                    Console.WriteLine("2.Tìm kiếm theo sbd");
                    Console.WriteLine("3.Thêm mới sinh viên");
                    Console.WriteLine("4..Thoát");
                     a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            //KhoiB.Display();
                            foreach (var item in ts)
                            {
                                item.Display();
                            }
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int b = int.Parse(Console.ReadLine());
                            if (b == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 2:
                            KhoiB.Find();
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int c = int.Parse(Console.ReadLine());
                            if (c == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 3:
                            goto Continue1;

                        default:
                            break;
                    }
                    break;
                #endregion
                case 3:
                    #region Khoic
                    SinhVienKhoiC KhoiC = new SinhVienKhoiC();
                    KhoiC.Input();
                    KhoiC.InputNumber();
                    ts.Add(KhoiC);
                    Console.WriteLine("Mời chọn chức năng:");
                    Console.WriteLine("1.Hiển thị thông tin");
                    Console.WriteLine("2.Tìm kiếm theo sbd");
                    Console.WriteLine("3.Thêm mới sinh viên");
                    Console.WriteLine("4..Thoát");
                    a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                            //KhoiC.Display();
                            foreach (var item in ts)
                            {
                                item.Display();
                            }
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int b = int.Parse(Console.ReadLine());
                            if (b == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 2:
                            KhoiC.Find();
                            Console.WriteLine("Bạn có muốn tiếp tục?");
                            Console.WriteLine("1.Yes");
                            Console.WriteLine("2.No");
                            int c = int.Parse(Console.ReadLine());
                            if (c == 1)
                            {
                                goto Continue;
                            }
                            else Console.WriteLine("Out");
                            break;
                        case 3:
                            goto Continue1;

                        default:
                            break;
                    }
                    break;
                #endregion
                case 5:
                    foreach (var item in ts)
                    {
                        item.Display();
                    }
                    goto Continue;
                    break;
                case 6:
                    foreach (var item in ts)
                    {
                        item.Find();
                    }
                    goto Continue;
                    break;
            }
        }
    }
}
