using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace quan_ly_sach
{
    internal class tapchi : tailieu
    {
        private int sotrang;
        private string ngayanhanh;
        private string nhaxuatban;
        private int soluong;
        public tapchi() : base()
        {
            sotrang = 0;
            ngayanhanh = "";
            nhaxuatban = "";
            soluong = 0;
        }
        public tapchi(int maso, string ten, int sotrang, string ngayanhanh, string nhaxuatban, int soluong, double giamua)
            : base(maso, ten, giamua)
        {
            this.sotrang = sotrang;
            this.ngayanhanh = ngayanhanh;
            this.nhaxuatban = nhaxuatban;
            this.soluong = soluong;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so trang sach giao khoa ");
            sotrang = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ngay an hanh:");
            ngayanhanh = Console.ReadLine();
            Console.WriteLine("nhap so luong :");
            soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nha xuat ban :");
            nhaxuatban = Console.ReadLine();
        }
        public override void inthongtin()
        {
            base.inthongtin();
            Console.WriteLine(" so trang " + sotrang);
            Console.WriteLine("nha an " + ngayanhanh);
            Console.WriteLine("nha xuat ban " + nhaxuatban);
            Console.WriteLine("nam xuat ban " + soluong);
        }
        public override double giathue(int songaythue)
        {
            return base.giathue(songaythue);
        }

    }
}

