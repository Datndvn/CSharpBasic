using System;

namespace Kieu_du_lieu_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                byte BienByte = 3;
                short BienShort = 9;
                int BienInt = 10;
                long BienLong = 0;

                BienLong = BienByte; 
                Console.WriteLine(" BienLong = " + BienLong);
                BienLong = BienInt;
                Console.WriteLine(" BienLong = {0}", BienLong);
                BienShort = BienByte;
                Console.WriteLine(" BienShort = " + BienShort);
                BienInt = BienShort;
                Console.WriteLine(" BienInt = " + BienInt);
                Console.ReadKey();
            }

        }
    }
}
