using System;
using System.Collections.Generic;
using System.Text;

namespace OOPP2
{
    public abstract class TuyenSinh 
    {
        public string NumberStudent { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }

        public abstract void Input();
        public abstract void Display();
        public abstract void Find();
    }
}
