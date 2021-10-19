using System;
using System.Collections.Generic;
using System.Text;

namespace OOPP2
{
    public class SinhVienKhoiB :  TuyenSinh,IKhoi
    {
        public double toan { get; set; }
        public double hoa { get; set; }
        public double sinh { get; set; }
        public string SoBaoDanh { get; set; }
        public override void Display()
        {
            Console.WriteLine("Thi sinh khoi B!");
            Console.WriteLine("So bao danh la:{0}", NumberStudent);
            Console.WriteLine("Ten sinh vien la:{0}", Name);
            Console.WriteLine("Dia chi la: {0}", Address);
            Console.WriteLine("Muc uu tien la:{0}", Level);
            Console.WriteLine("Diem toan la:{0}", toan);
            Console.WriteLine("Diem ly la:{0}", hoa);
            Console.WriteLine("Diem hoa la:{0}", sinh);
            Console.WriteLine("Thi sinh thuoc khoi B♥");
        }

        public override void Find()
        {
            Console.WriteLine("Moi nhap sbd muon tim:");
            SoBaoDanh = Console.ReadLine();
            if (SoBaoDanh == NumberStudent)
            {
                Display();
            }
            else
            {
                Console.WriteLine("Khong co thi sinh nao!");
            }
        }

        public override void Input()
        {
            Console.WriteLine("Nhap so bao danh:");
            NumberStudent = Console.ReadLine();
            Console.WriteLine("Nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:");
            Address = Console.ReadLine();
            Console.WriteLine("Nhap muc uu tien:");
            Level = int.Parse(Console.ReadLine());
        }

        public void InputNumber()
        {
            Console.WriteLine("Nhap diem toan:");
            toan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem Hoa:");
            hoa = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem sinh:");
            sinh = double.Parse(Console.ReadLine());
        }
    }
}
