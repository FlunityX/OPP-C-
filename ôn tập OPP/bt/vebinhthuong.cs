using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class vebinhthuong
    {
        protected string mave;
        protected int giave;
        protected string tenphim;
        protected string giochieu;
        protected string sothutughe;

         public string getmave()
        {
            return mave;
        }
       

        public vebinhthuong()
        {
            mave = "";
            giave = 0;
            tenphim = "";
            giochieu = "";
            sothutughe = "";
        }
        public vebinhthuong(string mave, int giave, string tenphim, string giochieu,string sothutughe)
        {
            this.mave = mave;
            this.tenphim = tenphim;
            this.giave = giave;
            this.giochieu = giochieu;
            this.sothutughe = sothutughe;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ma ve");
            mave = Console.ReadLine();
            Console.WriteLine("nhap gia ve");
            
            giave = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten phim");
            tenphim = Console.ReadLine();
            Console.WriteLine("nhap gio chieu");
            giochieu = Console.ReadLine();
            Console.WriteLine("nhap su thu tu ghe");
            sothutughe = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine(" ma ve"+mave);
            Console.WriteLine("gia ve"+giave);
            Console.WriteLine("ten phim"+tenphim);
            Console.WriteLine("gio chieu"+giochieu);
            Console.WriteLine("su thu tu ghe"+sothutughe);
        }
    }
}
