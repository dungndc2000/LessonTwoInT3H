using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPart2
{
    public class SoPhuc
    {
        private double _thuc;
        private double _ao;
        
        public double Thuc
        {
            get{ return _thuc; }
            set{ _thuc = value; }
        }
        public double Ao
        {
            get { return _ao; }
            set { _ao = value; }
        }

        public SoPhuc()
        {
            _thuc = 0;
            _ao = 0;
        }

        public SoPhuc(int thuc,int ao)
        {
            _thuc = thuc;
            _ao = ao;
        }

        
        public  SoPhuc Cong(SoPhuc soPhuc)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = _thuc ;
            rSoPhuc.Ao = _ao;

            return rSoPhuc;
        }

        public  SoPhuc Cong(SoPhuc soPhuc1, double t)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = _thuc + t;
            rSoPhuc.Ao = _ao;

            return rSoPhuc;
        }
        public SoPhuc Cong(double t)
        {
            SoPhuc rSoPhuc = new SoPhuc();

            rSoPhuc.Thuc = _thuc + t;
            rSoPhuc.Ao = _ao;

            return rSoPhuc;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1}",_thuc,_ao);
        }
    }
}
