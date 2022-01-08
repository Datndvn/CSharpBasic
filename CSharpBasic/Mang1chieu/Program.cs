using System;

namespace Mang1chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year; // Biến chứa giá trị năm cần tính.
            // Mảng Can chứa các giá trị can tương ứng theo bảng can
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };

            // Mảng Chi chứa các giá trị chi tương ứng theo bảng chi
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };


            Console.Write(" Moi ban nhap mot nam bat ky: ");

            // Nhập năm dương lịch và ép kiểu về kiểu số nguyên
            Year = Int32.Parse(Console.ReadLine());


            /*
             * Vì kết quả phép chia lấy dư của Year%10 hoặc Year%12 sẽ cho ra số nguyên
             * Nên ta sẽ dùng nó làm chỉ số phần tử để tra cứu ra giá trị can chi tương ứng. Thay vì dùng cách cũ là switch case
             * Như vậy cách này vừa đơn giản vừa dễ hiểu, code rất ít sẽ với cách dùng switch case
             */

            Console.WriteLine("Nam {0} co nam am lich la: {1} {2}", Year, Can[Year % 10], Chi[Year % 12]); // Nối Can và Chi lại để được năm âm lịch

            Console.ReadLine();
        }
    }
}
