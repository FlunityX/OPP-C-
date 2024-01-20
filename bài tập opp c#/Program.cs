
using System;
using System.Collections.Generic;

namespace bài_tập_opp_c_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            managernhanvien _mg = new managernhanvien();
            do
            {
                Console.WriteLine("-----Chào mừng bạn đến với quản lý nhân viên-----");
                Console.WriteLine("1. Nhập nhân viên");
                Console.WriteLine("2. Xuất nhân viên");
                Console.WriteLine("3. Danh sách nhân viên giảm dần về lương");
                Console.WriteLine("4. Nhân viên có tuổi lớn nhất");
                Console.WriteLine("5. Thoát chương trình");
                Console.WriteLine("---- Mời bạn chọn: ");
                int luachon = int.Parse(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        Console.WriteLine("a. Nhân viên văn phòng");
                        Console.WriteLine("b. Nhân viên bán hàng");
                        Console.WriteLine("c. Nhân viên sản xuất");
                        Console.WriteLine("Nhập lựa chọn của bạn: ");
                        string luachon1 = Console.ReadLine();
                        switch (luachon1.ToLower())
                        {
                            case "a":
                                nhanvienvanphong nvvp = new nhanvienvanphong();
                                nvvp.nhap();
                                _mg.themvemoi(nvvp);
                                break;
                            case "b":
                                nhanvienbanhang nvbh = new nhanvienbanhang();
                                nvbh.nhap();
                                _mg.themvemoi(nvbh);
                                break;
                            case "c":
                                nhanviensx nvsx = new nhanviensx();
                                nvsx.nhap();
                                _mg.themvemoi(nvsx);
                                break;
                        }
                        break;

                    case 2:
                        _mg.xuattatca();
                        break;
                    case 3:
                        _mg.sapxepnhanviengiamdan();
                        break;
                    case 4:
                        _mg.nhanviencotuoilonnhat();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Vui lòng nhập lại");
                        break;
                }

                Console.ReadLine(); // Đọc đầu vào từ người dùng

            } while (true);
        }
    }
}