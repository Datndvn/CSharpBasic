using System;

namespace Ep_kieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            int Tong, Hieu, Tich;
            double Thuong;
            string strA, strB; 

            Console.WriteLine("         **************************************************");
            Console.WriteLine("         *                                         			       *");
            Console.WriteLine("         *   Chuong trinh tinh tong, hieu, tich, thuong  *");
            Console.WriteLine("         *                                            		       *");
            Console.WriteLine("         **************************************************");

            Console.Write("\n Moi ban nhap so A: ");
            strA = Console.ReadLine();
            Console.Write(" Moi ban nhap so B: ");
            strB = Console.ReadLine();

            A = int.Parse(strA);
            B = int.Parse(strB);

            Tong = A + B;
            Hieu = A - B;
            Tich = A * B;
            Thuong = (double)A / B;

            Console.WriteLine(" Tong = " + Tong);
            Console.WriteLine(" Hieu = " + Hieu);
            Console.WriteLine(" Tich = " + Tich);
            Console.WriteLine(" Thuong = " + Thuong);

        }
    }
}
