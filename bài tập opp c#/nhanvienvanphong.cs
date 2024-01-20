using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_opp_c_
{
    internal class nhanvienvanphong:nhanvien
    {
        private double luongcoban;
        private int songaycong;
        private double hesoluong;
        private double phucapphucvu;
        
        public nhanvienvanphong(int maso, string hoten, string ngaysinh,double luongcoban, int songaycong, double hesoluong, double phucapphucvu):base(maso,hoten,ngaysinh)
        {
            this.luongcoban = luongcoban;
            this.songaycong = songaycong;
            this.hesoluong = hesoluong;
            this.phucapphucvu = phucapphucvu;
        }
        public nhanvienvanphong() : base()
        {
            luongcoban = 0;
            songaycong = 0;
            hesoluong = 0;
            phucapphucvu = 0;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap luong co ban ");
            luongcoban = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ngay cong ");
            songaycong = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap he so luong ");
            hesoluong = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap phu cap phc vu");
            phucapphucvu = double.Parse(Console.ReadLine());

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("luong co ban "+ luongcoban);
            Console.WriteLine("so ngay cong "+songaycong);
            Console.WriteLine("he so luong " + hesoluong);
            Console.WriteLine("phu cap phuc vu " + phucapphucvu);
        }
        public override void tinhluong()
        {
            double luongnhanvienvp = luongcoban * hesoluong * songaycong;
            Console.WriteLine(" luong nhan vien la :" + luongnhanvienvp);
        }
    }
}
