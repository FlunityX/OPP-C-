using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class vevip: vebinhthuong
    {
        string thucankemtheo;
        public vevip() : base()
        {
            thucankemtheo = "";
        }
        public vevip(string mave, int giave, string tenphim, string giochieu, string sothutughe, string thucankemtheo):base(mave,giave,tenphim,giochieu,sothutughe)
        {
            this.thucankemtheo = thucankemtheo;
        }
        public override void nhap()
        {
            base.nhap();
            Console.WriteLine("nhap thuc an kem theo");
            thucankemtheo = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("thuc an kem theo "+thucankemtheo);
        }
    }
}
