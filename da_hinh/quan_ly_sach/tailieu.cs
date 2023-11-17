using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_sach
{
    internal class tailieu
    {
        protected int maso;
        protected string ten;
        protected double giamua;
        public double Giamua
        {
            get { return giamua; }
            set { giamua = value; }
        }

        public int songaythue;
        public tailieu() {
            maso = 0;
            ten = "";
            giamua = 0;
        }
        public tailieu(int maso,string ten, double giamua) {
            this.maso = maso;
            this.ten = ten;
            this.giamua = giamua;
        }
        public virtual void nhap()
        {
            Console.WriteLine("nhap ma so tai lieu :");
            maso = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten tai lieu :");
            ten = Console.ReadLine();
            Console.WriteLine("nhap gia mua tai lieu :");
            giamua = int.Parse(Console.ReadLine());
        }
        public virtual void inthongtin() {
            double giathuetailieu =  giathue(songaythue);
            Console.WriteLine("ma so tai lieu :{0} , ten tai lieu {1}  ", maso, ten );
        }
        public virtual double giathue (int songaythue)
        {
            double dongia= 0.01 * giamua;
            double giathue = dongia * songaythue;
            return giathue;
        }
    }
}
