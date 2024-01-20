using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_opp_c_
{
    internal class nhanvien
    {
        protected int maso;
        protected string hoten;
        protected string ngaysinh;
        private double luong;
    
        
        public double Getluong()
        {
            return luong;
        }
        public string Getngaysinh()
        {
            return ngaysinh;
        }
        public nhanvien()
        {
            maso = 0;
            hoten = "";
            ngaysinh = "";
        }
        public nhanvien(int maso, string hoten, string ngaysinh)
        {
            this.maso = maso;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ma so :");
            maso = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ho ten :");
            hoten = Console.ReadLine();
            Console.WriteLine("nhap ngay sinh");
            ngaysinh = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("ma so :"+maso);
            Console.WriteLine("ho ten :"+hoten);
            Console.WriteLine("ngay sinh :"+ngaysinh);
        }
        public virtual void tinhluong()
        {
            luong = 0;
        }
        
    }
}
