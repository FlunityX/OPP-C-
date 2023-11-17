using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class nhasanvuon : khudat
    {
        private double dientichsanvuon;
        public nhasanvuon() : base() {
            dientichsanvuon = 6;
        }
        public nhasanvuon(string diadiem, double dongia, double dientichsanvuon, double dientich)
            : base(diadiem, dongia, dientich)
        {
            this.dientichsanvuon = dientichsanvuon;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine(" nhap dien tich san vuon :");
            dientichsanvuon = double.Parse(Console.ReadLine());
        }
        public override double giaban()
        {
            double giaban = (dientich * dongia + dientichsanvuon * dongia) * 0.5;
            return  giaban;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("dien tich san vuon " + dientichsanvuon);
  } 

    }
}
