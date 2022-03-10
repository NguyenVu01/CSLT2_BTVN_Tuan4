using System.Collections.Generic;
using System.Text;

public class PhanSo
{
    public int Tu, Mau;
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
    private int UCNN(int x, int y)
    {
        if (x == 0) return y;
        return UCNN(y % x, x);
    }
    public void RutGon()
    {
        int x = this.UCNN(Tu, Mau);
        this.Tu = this.Tu / x;
        this.Mau = this.Mau / x;
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Tao phan so voi constructor khong tham so
        PhanSo p0 = new PhanSo();
        p0.In();

        //Tao phan so voi constructor co 1 tham so
        PhanSo p1 = new PhanSo(5);
        p1.In();

        //Tao phan so voi constructor co 2 tham so nhap vao tu ban phim
        Console.WriteLine("nhap tu so: ");
        int ts = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap mau so: ");
        int ms = Convert.ToInt32(Console.ReadLine());
        PhanSo p2 = new PhanSo(ts, ms);
        p2.In();

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        //Phep cong 
        p0 = p1.Cong(p2);
        p0.RutGon();
        Console.WriteLine("Sau khi cong 2 phan so:");
        p0.In();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        //Phep tru 
        p0 = p2.Tru(p1);
        p0.RutGon();
        Console.WriteLine("Sau khi tru 2 phan so:");
        p0.In();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        //Phep nhan 
        p0 = p2.Nhan(p1);
        p0.RutGon();
        Console.WriteLine("Sau khi nhan 2 phan so:");
        p0.In();

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        //Phep chia
        Console.WriteLine("Sau khi chia 2 phan so:");
        p0 = p1.Chia(p2);
        p0.RutGon();
        p0.In();

        Console.ReadLine();
    }
}