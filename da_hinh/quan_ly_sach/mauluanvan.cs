using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace quan_ly_sach
{
    internal class mauluanvan : tailieu
    {
        private int namthuchien ;
        private string detai;
        private string tacgia;
        private string linhvucnghiencuu;
        public mauluanvan() : base()
        {
            namthuchien = 0;
            detai = "";
            tacgia = "";
            linhvucnghiencuu ="";
        }
        public mauluanvan(int maso, string ten, int namthuchien , string detai,string tacgia,string linhvucnghiencuu )
            : base(maso, ten, 0)
        {
            this.namthuchien = namthuchien;
            this.detai = detai;
            this.tacgia = tacgia;
            this.linhvucnghiencuu = linhvucnghiencuu;
        }
        public override void nhap()
        {
            Console.WriteLine("vi mau luan van ko can mua nen gia mua = 0 , nhap gia mua = 0 !");
            base.nhap();
            
            if (giamua == 0)
            {

                Console.WriteLine("nhap nam thuc hien ");
                namthuchien = int.Parse(Console.ReadLine());
                Console.WriteLine("nhap ten de tai:");
                detai = Console.ReadLine();
                Console.WriteLine("nhap ten tac gia:");
                tacgia = Console.ReadLine();
                Console.WriteLine("nhap linh vuc nghien cuu :");
                linhvucnghiencuu = Console.ReadLine();
            }
        }
        public override void inthongtin()
        {
            base.inthongtin();
            Console.WriteLine(" nam thuc hien " + namthuchien);
            Console.WriteLine("ten de tai " + detai);
            Console.WriteLine("ten tac gia " + tacgia);
            Console.WriteLine("linh vuc nghien cuu " + linhvucnghiencuu);
        }
        public override double giathue(int songaythue)
        {
            return 0;
        }

    }
}
