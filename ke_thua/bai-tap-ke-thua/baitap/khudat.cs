using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap
{
    internal class khudat
    {
        // khai báo thuộc tính của khu đất 
        protected string diadiem;
        protected double dongia;
        protected double dientich;
       
        // contructor chuẩn 
        public khudat()
        {
            diadiem = "";
            dongia = 10;
            dientich = 10;
        }
        // Contructor có tham số 
        public khudat(string diadiem , double dongia,double dientich)
        {
            this.diadiem = diadiem; 
            this.dongia = dongia;   
            this.dientich = dientich;
        }
        // nhap 
        public virtual void nhap()
        {
            Console.WriteLine("nhap dia diem :");
            diadiem = Console.ReadLine();
            Console.WriteLine("nhap dongia :");
            dongia = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap dien tich :");
            dientich = double.Parse(Console.ReadLine());
        }
        // xuat 
        public virtual void xuat()
        {
            Console.WriteLine("dia diem :" + diadiem);
            Console.WriteLine("don gia : " + dongia);
            Console.WriteLine("dien tich :" + dientich);
            Console.WriteLine("gia ban :" + giaban());

        }
        public virtual double giaban()
        {
            double giaban = dientich * dongia;
            return giaban;
        }

    }
}
