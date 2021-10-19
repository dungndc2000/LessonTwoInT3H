using System;

namespace OOPPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Point
            //Console.WriteLine("Hello World!");
            //Point P = new Point();
            //P.Input();
            //P.Display();
            //Console.WriteLine("Sau khi chuyen la:");
            //P.Trade();
            #endregion     //P.Move(10,5);

            //Cat C = new Cat();
            Console.WriteLine("So meo hien tai la:{0}",Cat.Count);
            Cat cat0 = new Cat(3000, 2000);
            cat0.ShowInfor();
            Cat cat1 = new Cat();
            cat1.ShowInfor();
            Console.WriteLine("Count Cat : {0}",Cat.Count);



        }
    }
}
