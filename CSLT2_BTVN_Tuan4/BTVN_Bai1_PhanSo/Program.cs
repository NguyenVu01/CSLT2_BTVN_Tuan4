using System.Collections.Generic;
using System.Text;

public class PhanSo
{
    int Tu, Mau;
    //Nạp chồng các phương thức khởi tạo (constructor)
    public PhanSo()
    {
        Tu = 0;
        Mau = 1;
    }
    public PhanSo(int y)
    {
        Tu = 1;
        Mau = y;
    }
    public PhanSo(int x,int y)
    {
        Tu = x;
        Mau = y;
    }
    //Cac phuong thuc (Method)
    public void In()
    {
        Console.WriteLine("Phan so = {0}/{1}", Tu,Mau);
    }

    public PhanSo Cong(PhanSo PS1)
    {
        int TS = Tu * PS1.Mau + Mau *PS1.Tu;
        int MS = Mau * PS1.Mau;
        //Gọi phương thức tạo 2 tham số
        PhanSo KetQua = new PhanSo(TS, MS);
        return KetQua;
    }
    public PhanSo Tru(PhanSo PS1)
    {
        int TS = Tu * PS1.Mau - Mau * PS1.Tu;
        int MS = Mau * PS1.Mau;
        //Gọi phương thức tạo 2 tham số
        PhanSo KetQua = new PhanSo(TS, MS);
        return KetQua;
    }
    public PhanSo Nhan(PhanSo PS1)
    {
        int TS = Tu * PS1.Tu;
        int MS = Mau * PS1.Mau;
        //Gọi phương thức tạo 2 tham số
        PhanSo KetQua = new PhanSo(TS, MS);
        return KetQua;
    }
    public PhanSo Chia(PhanSo PS1)
    {
        int TS = Tu * PS1.Mau;
        int MS = Mau * PS1.Tu;
        //Gọi phương thức tạo 2 tham số
        PhanSo KetQua = new PhanSo(TS, MS);
        return KetQua;
    }
}
class Program
{
    static void Main(string[] args)
    {
        PhanSo p1 = new PhanSo();
        p1.In();
        PhanSo p2 = new PhanSo(5);
        p2.In();
        Console.WriteLine("nhap tu so: ");
        int ts = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap mau so: ");
        int ms = Convert.ToInt32(Console.ReadLine());
        PhanSo p3 = new PhanSo(ts, ms);
        p3.In();
        Console.WriteLine("Cong phan so:");
        PhanSo kq = new PhanSo(); 
        kq = p1.Tru(p2);
        Console.Write("kq cua p1 - p2 = ");
        kq.In();
        Console.ReadLine();
    }
}