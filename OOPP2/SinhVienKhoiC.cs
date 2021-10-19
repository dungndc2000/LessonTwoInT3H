using System;
using System.Collections.Generic;
using System.Text;

namespace OOPP2
{
    
    public class SinhVienKhoiC : TuyenSinh, IKhoi
    {
        public double Van { get; set; }
        public double Su { get; set; }
        public double Dia { get; set; }
        public string SoBaoDanh { get; set; }
        public override void Display()
        {
            Console.WriteLine("Thi sinh khoi C!");
            Console.WriteLine("So bao danh la:{0}", NumberStudent);
            Console.WriteLine("Ten sinh vien la:{0}", Name);
            Console.WriteLine("Dia chi la: {0}", Address);
            Console.WriteLine("Muc uu tien la:{0}", Level);
            Console.WriteLine("Diem toan la:{0}", Van);
            Console.WriteLine("Diem ly la:{0}", Su);
            Console.WriteLine("Diem hoa la:{0}", Dia);
            Console.WriteLine("Thi sinh thuoc khoi C♥");
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
            Console.WriteLine("Nhap diem van:");
            Van = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem su:");
            Su = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem dia:");
            Dia = double.Parse(Console.ReadLine());
        }
    }
}
