using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hang
{
    internal class maytinhxachtay : mathang
    {
        int dungluongocung;
        int dungluongram;
        string dophangiai;
        public maytinhxachtay() : base()
        {
            dungluongocung = 0;
            dungluongram = 0;
            dophangiai = "";
        }
        public maytinhxachtay(int dungluongocung,int dungluongram, string dophangiai, int masanpham, string hangsanxuat, string giaban)
        {
            this.dungluongocung = dungluongocung;
            this.dungluongram = dungluongram;
            this.dophangiai = dophangiai;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write(" nhap dung luong o cung :");
            dungluongocung = int.Parse(Console.ReadLine());
            Console.Write(" nhap dung luong ram:");
            dungluongram = int.Parse(Console.ReadLine());
            Console.Write(" nhap do phan giai :");
            dophangiai = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine(" dung luong o cung " + dungluongocung);
            Console.WriteLine(" dung luong ram " + dungluongram);
            Console.WriteLine(" do phan giai:" + dophangiai);
        }
    }
}
