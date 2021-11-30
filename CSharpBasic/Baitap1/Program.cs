using System;

namespace Baitap1
{
    class Program
    {
        // cho người dùng nhập vào màn hình 1 số bất kỳ
        //kiểm tra số đó là số chăn hay số lẻ
        // tính tổng của dãy chẵn hoặc lẻ
        //từ đầu đến N
        static void Main(string[] args)
        {
            int num1, rem1, i, sum = 0;
            Console.WriteLine("Nhap so bat ki: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
            {
                Console.WriteLine("{0} la so chan.\n", num1);
                for (i = 1; i <= num1; i++)
                {
                    Console.Write("{0} ",2 * i) ;
                    sum += 2 * i;
                }
                Console.Write("\nTong day so chan  la : {1} \n", num1, sum);
            }

            else
            { Console.WriteLine("{0} la so le.\n", num1);
                for (i = 1; i <= num1; i++)
                {
                    Console.Write("{0} ", 2 * i - 1);
                    sum += 2 * i - 1;
                }
                Console.Write("\nTong day so le la: {1} \n", num1, sum);


            }

            Console.ReadKey();

        }
    }
}
