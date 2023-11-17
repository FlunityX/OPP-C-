using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal  class nhapho : khudat
    {
        private int sotang;
        public nhapho() : base()
        {
            sotang = 7;
        }
        public nhapho(string diadiem, double dongia, int sotang, double dientich)
            : base(diadiem, dongia, dientich)
        {
            this.sotang=sotang;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine(" nhap so tang ");
            sotang = int.Parse(Console.ReadLine());
        }
        public override double giaban()
        {
            double giaban = dientich * dongia * sotang;
            return giaban;
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("so tang " + sotang);
        }

    }
}
