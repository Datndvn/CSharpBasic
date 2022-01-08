using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace baitap2class
{
    class PhanSo
    {
        public int ts;
        public int ms;
        public void NhapPhanSo()
        {
            Console.Write("Tu = ");
            ts = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write("Mau = ");
                ms = Convert.ToInt32(Console.ReadLine());
            } while (ms == 0);
           
        }
        /// Phương thức hiển thị tử số nếu mẫu số = 1
        
        public void HienThi()
        {
            if (ms == 1)
                Console.Write(ts);
            else
                Console.Write(ts + "/" + ms);
        }
        /// Phương thức tìm UCLN của 1 phân số
        public int ucln(int a, int b)
        {
            while (a > 0 && b > 0)
            {
                if (a >= b)
                { a -= b; }
                else
                { b -= a; }
            }
            return a + b;
        }
        /// Phương thức ruts gon
        public void RutGon()
        {
            int c = ucln(Math.Abs(ts), Math.Abs(ms));
            while(c != 0) 
            {
                ts = ts / c;
                ms = ms / c;
            }

            
        }
        public static PhanSo Cong(PhanSo A, PhanSo B)
        {
            PhanSo C = new PhanSo();
            C.ms = A.ms * B.ms;
            C.ts = A.ts * B.ms + A.ms * B.ts;
            C.RutGon();
            return C;
        }
        
        /// Phương thức trừ 2 phân số
        
        public static PhanSo Tru(PhanSo A, PhanSo B)
        {
            PhanSo C = new PhanSo();
            C.ms = A.ms * B.ms;
            C.ts = A.ts * B.ms - A.ms * B.ts;
            C.RutGon();
            return C;
        }
        
        /// Phương thức nhân 2 phân số
        
        public static PhanSo Nhan(PhanSo A, PhanSo B)
        {
            PhanSo C = new PhanSo();
            C.ts = A.ts * B.ts;
            C.ms = A.ms * B.ms;
            C.RutGon();
            return C;
        }
        
        /// Phương thức chia 2 phân số
        
        public static PhanSo Chia(PhanSo A, PhanSo B)
        {
            PhanSo C = new PhanSo();
            C.ts = A.ts * B.ms;
            C.ms = A.ms * B.ts;
            C.RutGon();
            return C;
        }
    }
        
    class Program
    {
        static void Xuat(PhanSo ps)
        {
            Console.WriteLine("Tu so :  " + ps.ts);
            Console.WriteLine("Mau so : " + ps.ms);
            Console.WriteLine("UCLN : " + ps.ucln(ps.ts, ps.ms));
            Console.Write("Phan so "); ps.HienThi();
            ps.RutGon();
            Console.Write(" duoc rut gon thanh "); ps.HienThi();
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            PhanSo macdinh = new PhanSo();
            PhanSo ps1 = new PhanSo();
            PhanSo ps2 = new PhanSo();
            PhanSo ps3 = new PhanSo();

            //Thay đổi phân số 1 và phân số 2
            Console.WriteLine("Nhap phan so thu 1 ");
            ps1.NhapPhanSo();
            Console.WriteLine("Nhap phan so thu 2 ");
            ps2.NhapPhanSo();
            Console.Clear();

            //Xuất ra màn hình phân số mặc định, phân số 1 và 2
            Xuat(ps3);
            Xuat(ps1);
            Xuat(ps2);

            //Tính toán trên phân số 1 và phân số 2
            ps3 = PhanSo.Cong(ps1, ps2);
            ps1.HienThi(); Console.Write(" cong "); ps2.HienThi();
            Console.Write(" = "); ps3.HienThi();
            Console.WriteLine();
            ps3 = PhanSo.Tru(ps1, ps2);
            ps1.HienThi(); Console.Write(" tru "); ps2.HienThi();
            Console.Write(" = "); ps3.HienThi();
            Console.WriteLine();
            ps3 = PhanSo.Nhan(ps1, ps2);
            ps1.HienThi(); Console.Write(" nhan "); ps2.HienThi();
            Console.Write(" = "); ps3.HienThi();
            Console.WriteLine();
            ps3 = PhanSo.Chia(ps1, ps2);
            ps1.HienThi(); Console.Write(" chia "); ps2.HienThi();
            Console.Write(" = "); ps3.HienThi();
            Console.ReadLine();
        }
    }
}
