using System;
using System.Collections.Generic;

/*Xây dựng các phương thức trong lớp Mang1Chieu
 Hàm tạo Mang1Chieu (int n) để khởi tạo mảng gồm n phần tử
 Nhập mảng
 In mảng ra màn hình
 Sắp xếp mảng
public void sapxep(int thutu) //thutu = 0: tăng dần, thutu=1: giảm dần
 Tìm kiếm: public int timkiem(int m) //Trả về -1 nếu không thấy, trả về vị trí nếu
tìm thầy*/

namespace Mang1Chieu
{
    public class Mang
    {
        private int n; //So phan tu cua mang 1 chieu
        int[]? a; //Mang 1 chieu 

        public void NhapMang()
        {
            Console.WriteLine("Nhap so phan tu co trong mang:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n <= 0)
            {
                Console.WriteLine("Hay nhap lai so phan tu n >= 0:");
            }
            a = new int[n];
            Console.WriteLine("Bat dau nhap mang:");
            for(int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}:", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Mang vua nhap:");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Phan tu a[{0}]: {1}", i, a[i]);
            }
        }
        public void SapXep(int thutu)
        {
            if (thutu == 1)
            {
                Array.Sort(a);
            }
            else if(thutu == 0)
            {
                Array.Sort(a);
                Array.Reverse(a);
            }
            else Console.WriteLine("Ban nhap sai roi! Hay nhap 0 neu sap xep giam dan, nhap 1 neu sap xep tang dan!");
        }
        public int TimKiem(int x)
        {
            for(int i = 0; i < n; i++)
            {
                if(a[i] == x) return i;
            }
            return -1;
        }
    } 
    class Program 
    {
        static void Main(string[] args)
        {
            Mang a = new Mang();
            a.NhapMang();
            a.Xuat();
            a.SapXep(0);
            a.Xuat();
            int X = a.TimKiem(10);
            if(X != -1) Console.WriteLine("Vi tri cua X la: {0}", X);
            else Console.WriteLine("Khong tim thay X!");
            Console.ReadKey();
        }
    }
}