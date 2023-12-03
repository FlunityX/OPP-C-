using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quan_ly_hang
{
    internal class dondathang
    {
        int masodathang;
        string ngaydatmathang;
        string username;
        string tenkhachhang;
        string diachinhan;
        string phuongthucvanchuyen;
        double thueVAT;
        List<mathang> dsmathang = new List<mathang>();
        public dondathang()
        {
            masodathang = 0;
            ngaydatmathang = "";
            username = "";
            tenkhachhang = "";
            diachinhan = "";
            phuongthucvanchuyen = "";
            thueVAT = 0.0;
        }
        public dondathang(int masodathang, string ngaydatmathang, string username, string tenkhachhang, string diachinhan, string phuongthucvanchuyen, double thueVAT)
        {
            this.masodathang = masodathang;
            this.ngaydatmathang = ngaydatmathang;
            this.username = username;
            this.tenkhachhang = tenkhachhang;
            this.diachinhan = diachinhan;
            this.phuongthucvanchuyen = phuongthucvanchuyen;
            this.thueVAT = thueVAT;
        }
        public void nhapdonhang()
        {
            Console.Write(" nhap ma so dat hang :");
            masodathang = int.Parse(Console.ReadLine());
            Console.Write(" nhap ngay dat mat hang :");
            ngaydatmathang = Console.ReadLine();
            Console.Write(" nhap username : ");
            username = Console.ReadLine();
            Console.Write(" nhap ten khach hang : ");
            tenkhachhang = Console.ReadLine();
            Console.Write(" nhap dia chi nhan hang :");
            diachinhan = Console.ReadLine();
            Console.Write(" nhap phuong thuc van chuyen : ");
            phuongthucvanchuyen = Console.ReadLine();
            Console.Write(" nhap thue VAT :");
            thueVAT = double.Parse(Console.ReadLine());
        }
        public void xuatdonhang() 
        {
            Console.WriteLine("ma so dat hang :" + masodathang);
            Console.WriteLine("ngay dat mat hang :" + ngaydatmathang);
            Console.WriteLine("username :" + username);
            Console.WriteLine("ten khach hang " + tenkhachhang);
            Console.WriteLine("dia chi nhan hang " + diachinhan);
            Console.WriteLine("phuong thuc van chuyen :" + phuongthucvanchuyen);
            Console.WriteLine("thue VAT " + thueVAT);
        }
        public void xoamathang(int mamathangcanxoa)
        {
            var mathangxoa = dsmathang.Where(o => o.masanpham == mamathangcanxoa).FirstOrDefault();
            if (mathangxoa == null)
            {
                Console.WriteLine(" khong tim thay ma san pham nay :" + mamathangcanxoa + "trong danh sach");
            }
            else
                dsmathang.Remove(mathangxoa);
        }
        public void themmathangmoi(mathang mathangcanthem)
        {
            dsmathang.Add(mathangcanthem);
        }
        public void giabancaonhat()
        {
            var Giabancaonhat = dsmathang.OrderByDescending(o => o.giaban).FirstOrDefault();
            Console.WriteLine("Hoa don co gia tri thanh toan cao nhat: ");
            if (Giabancaonhat != null)
            {
                xuatdonhang();
                Console.WriteLine("Mat hang co gia ban cao nhat: ");
                Giabancaonhat.xuat(); 
            }
            else
            {
                Console.WriteLine("Danh sach mat hang rong.");
            }
        }

        public void TinhTongTien()
        {
            double tongTien = 0;

            foreach (mathang item in dsmathang)
            {
                tongTien += item.giaban;
            }

            Console.WriteLine("Tong tien: " + tongTien);
        }



    }
}
