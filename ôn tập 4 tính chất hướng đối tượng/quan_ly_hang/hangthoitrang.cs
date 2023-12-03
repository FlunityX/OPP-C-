using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hang
{
    internal class hangthoitrang:mathang
    {
        string ten;
        string kichco;
        string mausac;
        public hangthoitrang(string ten, string kichco, string mausac, int masanpham, string hangsanxuat, string giaban)
        {
            this.ten = ten;
            this.kichco = kichco;
            this.mausac = mausac;
        }
        public hangthoitrang() : base() {
            ten = "";
            kichco = "";
            mausac = "";
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap ten mat hang :");
            ten = Console.ReadLine();
            Console.Write("nhap kich co :");
            kichco = Console.ReadLine();
            Console.Write("nhap mau sac :");
            mausac = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("ten mat hang " + ten);
            Console.WriteLine(" kich co :"+kichco);
            Console.WriteLine("mau sac :" + mausac);

        }
    }
}
