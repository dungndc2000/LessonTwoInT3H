using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Nhap lai");
                n = int.Parse(Console.ReadLine());
            }
            float tongchan = 0, tongle = 0;
            float[] array = new float[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}]= ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    tongchan += array[i];
                }
                if (array[i] % 2 == 1)
                {
                    tongle += array[i];
                }
            }
            Console.WriteLine("Tong chan la:" + tongchan);
            Console.WriteLine("Tong le la:" + tongle);
            Console.WriteLine("Hieu so chan & so le: {0}",tongchan - tongle);


        }
    }
}
