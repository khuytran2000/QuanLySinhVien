using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part1_bai6
{
    class SinhVien
    {
        public string MaSV;
        public string HoTen;
        public int NamSinh;
        public double DiemLT;
        public double DiemCSDL;
        public double DiemTB;

       

        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLT = DiemCSDL = DiemTB = 0;
        }
        public SinhVien(string HoTen, int NamSinh, string MaSV, double DiemLT, double DiemCSDL)
        {

            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.MaSV = MaSV;
            this.DiemLT = DiemLT;
            this.DiemCSDL = DiemCSDL;
        }
        public double TinhDiemTB()
        {
            DiemTB = (0.5 * (DiemLT + DiemCSDL));
            return DiemTB;
        }
        public void tinhtb()
        {
            if (DiemTB > 8)
            {
                Console.WriteLine(" thong tin sinh vien: \n maSV: {0} \t ho ten: {1} \t nam sinh: {2} "
                         + "\t điem LT: {3} \t diem CSDL {4}", MaSV, HoTen, NamSinh, DiemLT, DiemCSDL, TinhDiemTB());
            }
        }
       public void nhap()
        {
            Console.WriteLine("Hay nhap ma sinh vien:");
            MaSV = Console.ReadLine();
            Console.WriteLine("Hay nhap ho ten sinh vien:");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap nam sinh sinh vien:");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap diem lap trinh cua sinh vien:");
            DiemLT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hay nhap diem co so du lieu cua sinh vien:");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());
        }
       
        public void xuat()
        {
            Console.WriteLine("Thong tin sinh vien: \n Ma sinh vien: {0}, \n Tên: {1}, \n Nam sinh: {2}," +
                " \n Diem lap trinh: {3}, \n Diem CSDL: {4}, \n Diem trung binh: {5}",
                                    MaSV, HoTen, NamSinh, DiemLT, DiemCSDL, DiemTB);
        }
       

       
    }
}
