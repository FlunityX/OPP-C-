using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace bài_tập_opp_c_
{
    internal class nhanvienbanhang:nhanvien
    {
        private double luongcoban;
        private int soluonghangban;
        private double dongiahangban;
        public nhanvienbanhang(int maso, string hoten, string ngaysinh,  double luongcoban, int soluonghangban, double dongiahangban) : base(maso, hoten, ngaysinh)
        {
            this.luongcoban = luongcoban;
            this.soluonghangban = soluonghangban;
            this.dongiahangban = dongiahangban;
        }
        public nhanvienbanhang() : base()
        {
            luongcoban = 0;
            soluonghangban = 0;
            dongiahangban = 0;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap luong co ban :");
            luongcoban = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong hang ban :");
            soluonghangban = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don gia hang ban ");
            dongiahangban = double.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("luong co ban "+luongcoban);
            Console.WriteLine("so luong don ban "+soluonghangban);
            Console.WriteLine("don gia hang ban " + dongiahangban);
        }
        public override void tinhluong()
        {
            double luongnvbanhang = luongcoban + (soluonghangban * dongiahangban) * (0.15);
            Console.WriteLine(" luong nv ban hang la : " + luongnvbanhang);
        }
    }
}
