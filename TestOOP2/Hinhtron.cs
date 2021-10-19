using System;
using System.Collections.Generic;
using System.Text;

namespace TestOOP2
{
    public class Hinhtron : HinhHoc
    {
        public float _bankinh { get; set; }

        public Hinhtron(float bankinh)
        {
            _bankinh = bankinh;
        }

        public override float Chuvi()
        {
            return (_bankinh * 2 * (float)Math.PI);
        }
        public override float DienTich()
        {
            return (_bankinh * _bankinh * (float)Math.PI);
        }
    }
}
