using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hang
{
    internal class hangdienthoai:mathang
    {
        double kichthuocmanhinh;
        string dophangiai;
        public hangdienthoai() : base() {
            kichthuocmanhinh = 0.0;
            dophangiai = "";
        }
        public hangdienthoai(double kichthuocmanhinh, string dophangiai,int masanpham , string hangsanxuat , string giaban)
        {
            this.kichthuocmanhinh = kichthuocmanhinh;
            this.dophangiai = dophangiai;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("nhap kich thuoc man hinh :");
            kichthuocmanhinh = double.Parse(Console.ReadLine());
            Console.Write("nhap do phan giai :");
            dophangiai = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("kich thuoc man hinh "+kichthuocmanhinh);
            Console.WriteLine(" do phan giai :"+dophangiai);
        }
    }
}
