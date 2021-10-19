﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPPart1
{
    public class Cat
    {
        private double _weight;
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public static int Count = 0;

        public Cat()
        {
            _height = 300;
            _weight = 500;
            Count++;
        }

        public Cat(double weight,double height)
        {
            _height = height;
            _weight = weight;
            Count++;
        }

        public void ShowInfor()
        {
            Console.WriteLine("Height =  {0}",_height);
            Console.WriteLine("Weight =  {0}", _weight);
            Console.WriteLine("Count Cat =  {0}", Count);
        }
    }
}
