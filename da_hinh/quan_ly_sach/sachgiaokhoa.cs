using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace quan_ly_sach
{
    internal class sachgiaokhoa:tailieu
    {
        private int sotap;
        private string lop;
        private string nhaxuatban;
        private int namxuatban;
        public sachgiaokhoa() :base()
        {
            sotap = 0;
            lop = "";
            nhaxuatban = "";
            namxuatban = 0;
        }
        public sachgiaokhoa(int maso, string ten, int sotap, string lop, string nhaxuatban, int namxuatban, double giamua)
            : base(maso, ten, giamua)
        {
            this.sotap = sotap;
            this.lop = lop;
            this.nhaxuatban = nhaxuatban;
            this.namxuatban = namxuatban;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so tap sach giao khoa ");
            sotap = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten lop:");
            lop = Console.ReadLine();
            Console.WriteLine("nhap nam xuat ban:");
            namxuatban = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap nha xuat ban :");
            nhaxuatban = Console.ReadLine();
        }
        public override void inthongtin()
        {
            base.inthongtin();
            Console.WriteLine(" so tap " + sotap);
            Console.WriteLine("lop " + lop);
            Console.WriteLine("nha xuat ban " + nhaxuatban);
            Console.WriteLine("nam xuat ban " + namxuatban);
        }
        public override double giathue(int songaythue)
        {
            return base.giathue(songaythue);
        }

    }
    }

