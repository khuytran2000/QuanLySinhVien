using System;
using System.Collections.Generic;
using System.Text;

namespace Chuong3_part1_bai6
{
    class DanhSach
    {
        private int n;
        private SinhVien[] DS;

        public void nhap()
        {
            Console.WriteLine("Hay nhap so sinh vien trong danh sach:");
            
            n = Convert.ToInt32(Console.ReadLine());

            DS = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tin cho sinh vien thu "  + i);
                DS[i] = new SinhVien();
                DS[i].nhap();
            }
        }
        public void Xuat()

        {
            if (DS != null && n>0)
            {
                for(int i=0;i<n;i++)
                {
                    DS[i].xuat();
                }    
            }    
        }
        public void sapxep() //sap xep tang dan
        {
            for(int i=0;i<n;i++)
                for(int j=i+1;j<n;j++)
                {
                    if (string.Compare(DS[i].MaSV,DS[j].MaSV,true)>0)
                        {
                          SinhVien tg = new SinhVien();
                          tg = DS[i];
                          DS[i] = DS[j];
                          DS[j] = tg;
                        }
                }    
        }
        public void sosanh()
        {
            
            for (int i=0 ;i<n;i++)
            {
                if(DS[i].TinhDiemTB() > 8)
                {
                    DS[i].tinhtb();
                }    
            }    
        }
    }
}
