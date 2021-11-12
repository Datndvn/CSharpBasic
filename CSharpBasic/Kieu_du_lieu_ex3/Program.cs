using System;

namespace Kieu_du_lieu_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
      
        }
    }

{
    int a;
    Console.WriteLine(" a = " + a); // Lỗi vì biến a không thể sử dụng khi chưa có giá trị.

    int b = 10.9; // Lỗi vì b là biến kiểu số nguyên nên không thể nhận giá trị ngoài số nguyên.

    byte c = 1093; // Lỗi vì c là biến kiểu byte mà kiểu byte có miền giá trị từ -128 đến 127 nên không thể nhận giá ngoài vùng này được.

    string d = 'K'; // Lỗi vì không thể gán giá trị ký tự vào biến kiểu chuỗi được mặc dù chuỗi có thể hiểu là tập hợp nhiều ký tự. Có thể sửa bẳng cặp dấu "" thay vì ''. 

    long e = null; // Lỗi vì không thể gán null cho biến kiểu long, int, byte, . . .
    long? f = null; // Cách khắc phục là thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?

    int g = 10;
    byte h = g; // Lỗi vì giá trị của biến có kiểu dữ liệu lớn hơn không thể gán cho biến có kiểu dữ liệu nhỏ hơn mặc dù trong trường hợp này ta thấy số 10 đều có thể gán cho 2 biến.

    string k = "Kteam";
    Console.WriteLine(" k = " + K); // Lỗi vì phía trên khai báo biến k còn khi sử dụng là biến K (C# có phân biệt chữ hoa, thường cần lưu ý để tránh gặp lỗi)

    Console.ReadKey();
}
