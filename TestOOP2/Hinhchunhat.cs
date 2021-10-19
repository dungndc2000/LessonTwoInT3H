using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP2
{
    public class Hinhchunhat : HinhHoc
    {
        public float _chieudai { get; set; }
        public float _chieurong { get; set; }

        public Hinhchunhat(float chieudai, float chieurong)
        {
            _chieudai = chieudai;
            _chieurong = chieurong;
        }

        public override float Chuvi()
        {
            return (_chieudai + _chieurong) * 2 ;
        }
        public override float DienTich()
        {
            return _chieudai * _chieurong;
        }
    }
}
