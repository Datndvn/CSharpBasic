using System;

namespace Lamlaibaitap
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string strn;
            
            Console.WriteLine("Nhap so nguyen bat ki: ");
            strn = Console.ReadLine();

            if (int.TryParse(strn, out n) == false)
            {
                Console.WriteLine("Nhap khong phai so nguyen moi nhap lai: ");
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("La so chan");
                }
                else
                {
                    Console.WriteLine("La so le");
                }


                int sum = 0;
                Console.Write($"Cac so le tu 1 den {n} la :");
                for (int i = 1; i <= n; i += 2)
                {
                    Console.Write(i + " ");
                    sum += i;
                }

                Console.Write($"\nTong cac so le tu 1 den {n} la : {sum}");
            }
            Console.ReadKey();
        }
    }
}
