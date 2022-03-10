using System;
using System.Collections.Generic;

namespace KhongGian2Chieu
{
    public class Diem
    {
        private double x;
        private double y;
        public Diem()
        {
            x = 0;
            y = 0;
        }
        public Diem(double a, double b)
        {
            x = a;
            y = b;
        }

        /* Xây dựng các phương thức
        Hàm tạo không tham số: khởi tạo điểm toạ độ(0,0)
        Hàm tạo 2 tham số x, y: khởi tạo điểm có toạ độ(x, y)
        Nhập toạ độ
        In toạ độ điểm ra màn hình
        Tính khoảng cách giữa 2 điểm*/

        public void Nhap()
        {
            Console.Write("Nhap hoanh do x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap tung do y:");
            y = Convert.ToDouble(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Diem vua nhap co toa do: ({0};{1})",x,y);
        }
        public double KhoangCach(Diem a)
        {
            double kc = Math.Sqrt(Math.Pow((x-a.x),2) + Math.Pow((y-a.y),2));
            return kc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Diem A = new Diem();
            A.Nhap();
            A.Xuat();
            Diem B = new Diem();
            B.Nhap();
            B.Xuat();
            double kc = A.KhoangCach(B);
            Console.WriteLine("Khoang cach giua 2 diem vua nhap la: {0}", kc);
            Console.ReadLine();
        }
    }
}
