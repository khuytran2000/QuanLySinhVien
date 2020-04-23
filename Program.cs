using System;

namespace Chuong3_part1_bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SinhVien sv = new SinhVien();
            sv.nhap();
            sv.TinhDiemTB();
            sv.xuat();
            

            DanhSach k21httta = new DanhSach();

            k21httta.nhap();
            k21httta.Xuat();
            Console.WriteLine("Danh sach sinh vien da sap xep la: ");
            k21httta.sapxep();
            k21httta.Xuat();
            Console.WriteLine("Danh sach sinh vien co diem trung binh lon hon 8 la: ");
            k21httta.sosanh();

            Console.ReadLine();
        }
    }
}
