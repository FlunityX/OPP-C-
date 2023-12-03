using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hang
{
    internal class mathang
    {
        public int masanpham { get; set; }
        protected string hangsanxuat;
        public double giaban { get; set; }

        

        public mathang()
        {
            masanpham = 0;
            hangsanxuat = "";
            giaban = 0;
        }
        public mathang(int masanpham, string hangsanxuat, double giaban)
        {
            this.masanpham = masanpham;
            this.hangsanxuat = hangsanxuat;
            this.giaban = giaban;
        }
        public virtual void nhap()
        {
            Console.Write(" nhap ma san pham :");
            masanpham = int.Parse(Console.ReadLine());
            Console.Write(" nhap hang san xuat :");
            hangsanxuat = Console.ReadLine();
            Console.Write("gia ban : ");
            giaban = double.Parse(Console.ReadLine());
        }
        public virtual void xuat()
        {
            Console.WriteLine(" ma san pham : " + masanpham);
            Console.WriteLine(" hang san xuat  : " + hangsanxuat);
            Console.WriteLine(" gia ban : " + giaban);
        }
    }
}
