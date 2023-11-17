using System;
using System.Collections.Generic;
using System.Linq;

namespace quan_ly_sach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<tailieu> dstailieu = new List<tailieu>();
            Console.WriteLine("CHAO MUNG BAN DEN VOI QUAN LY TAI LIEU");
            Console.WriteLine("1. Nhap thong tin SACH GIAO KHOA");
            Console.WriteLine("2. Nhap thong tin TAP CHI");
            Console.WriteLine("3. Xem thong tin MAU LUAN VAN");
            Console.WriteLine("4. Thoat");
            Console.WriteLine("Moi ban chon chuc nang");

            bool exitProgram = false;

            do
            {
                int chon;
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sachgiaokhoa sgk = new sachgiaokhoa();
                        sgk.nhap();
                        dstailieu.Add(sgk);
                        break;
                    case 2:
                        tapchi tc = new tapchi();
                        tc.nhap();
                        dstailieu.Add(tc);
                        break;
                    case 3:
                        mauluanvan mlv = new mauluanvan();
                        mlv.nhap();
                        dstailieu.Add(mlv);
                        break;
                    case 4:
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("NHAP LAI. SO KHONG HOP LE");
                        break;
                }

                if (exitProgram)
                {
                    break;
                }
            } while (true);
            // Xuat danh sach
            Console.WriteLine("------------------------------------------");
            foreach (var i in dstailieu)
            {
                i.inthongtin();
                Console.WriteLine("Gia thue: " + i.giathue(1));
            }
 
        // Tìm loại tài liệu có giá thuê nhỏ nhất nếu chỉ thuê 1 ngày
        var taiLieuGiaThueNhoNhat = dstailieu.Where(t => t.giathue(1) > 0).OrderBy(t => t.giathue(1)).FirstOrDefault();
            if (taiLieuGiaThueNhoNhat != null)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Loại tài liệu có giá thuê nhỏ nhất nếu chỉ thuê 1 ngày:");
                taiLieuGiaThueNhoNhat.inthongtin();
                Console.WriteLine("Gia thue: " + taiLieuGiaThueNhoNhat.giathue(1));
            }
            else
            {
                Console.WriteLine("Không có tài liệu nào có giá thuê nếu chỉ thuê 1 ngày.");
            }
            // Sắp xếp danh sách tài liệu theo thứ tự giá mua tăng dần
            var danhSachSapXep = dstailieu.OrderBy(t => t.Giamua).ToList();

            // In danh sách đã sắp xếp
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Danh sách tài liệu sau khi sắp xếp theo giá mua tăng dần:");
            foreach (var taiLieu in danhSachSapXep)
            {
                taiLieu.inthongtin();
                Console.WriteLine("Gia mua: " + taiLieu.Giamua);
            }
            Console.ReadKey();
        }
    }
}