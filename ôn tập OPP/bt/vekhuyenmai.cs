using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class vekhuyenmai: vebinhthuong
    {
        int sotienkhuyenmai;
        public vekhuyenmai():base()
        {
            sotienkhuyenmai = 0;
        }
        public vekhuyenmai(string mave, int giave, string tenphim, string giochieu, string sothutughe,int sotienkhuyenmai) : base(mave, giave, tenphim, giochieu, sothutughe)
   
        {
            this.sotienkhuyenmai = sotienkhuyenmai;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap so tien khuyen mai ");
            sotienkhuyenmai = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so tien khuyen mai "+sotienkhuyenmai);
        }
    }
}
