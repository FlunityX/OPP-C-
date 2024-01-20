using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bài_tập_opp_c_
{
    internal class nhanviensx:nhanvien
    {
        private int solgsp;
        private int solgvct;
        private int pccv;
        public nhanviensx() : base()
        {
            solgsp = 0;
            solgvct = 0;
            pccv = 0;
    }
        public nhanviensx(int solgsp, int solgvct, int pccv,int maso, string hoten, string ngaysinh) : base(maso, hoten, ngaysinh)
        {
            this.solgsp = solgsp;
            this.solgvct = solgvct;
            this.pccv = pccv;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so lg san pham theo chi tieu :");
            solgsp = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so lg vuot chi tieu :");
            solgvct = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap phu cap cong viec ");
            pccv = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so lg san pham theo chi tieu"+solgsp);
            Console.WriteLine("so luong vuot chi tieu "+solgvct);
            Console.WriteLine("phu cap cong viec" + pccv);
        }
        public override void tinhluong()
        {
            double luongnvsx = solgsp * 10000 + solgvct * 20000 + pccv;
            Console.WriteLine("luong nhan vien san xuat la :"+luongnvsx);
        }
    }
}
