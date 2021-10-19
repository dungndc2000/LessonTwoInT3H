using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP2
{
    public class HinhTg : HinhHoc
    {
        public float _canhtg1 { get; set; }
        public float _canhtg2 { get; set; }
        public float _canhtg3 { get; set; }

        public HinhTg(float canhtg1,float canhtg2,float canhtg3)
        {
            _canhtg1 = canhtg1;
            _canhtg2 = canhtg2;
            _canhtg3 = canhtg3;
        }

        public override float Chuvi()
        {
            return _canhtg1 + _canhtg2 + _canhtg3;
        }
        public override float DienTich()
        {
            float a = Chuvi() / 2;
            return (float)Math.Sqrt(a * (a - _canhtg1) * (a - _canhtg2) * (a - _canhtg3));
        }
    }
}
