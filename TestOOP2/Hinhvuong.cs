using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP2
{
    public class Hinhvuong : HinhHoc
    {
        public float _canh { get; set; }

        public Hinhvuong(float canh)
        {
            _canh = canh;
        }
        
        public override float Chuvi()
        {
            return _canh * 4;
        }
        public override float DienTich()
        {
            return _canh * _canh;
        }
    }
}
