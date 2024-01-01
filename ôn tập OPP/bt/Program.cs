using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quanlyve Ql = new Quanlyve();

            do
            {
                Console.WriteLine("1. Them ve moi ");
                Console.WriteLine("2. Tim kiem");
                Console.WriteLine("3. Xoa ve");
                Console.WriteLine("4. Hien thi danh sach");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("Chon chuc nang");

                int chonchucnang;
                if (!int.TryParse(Console.ReadLine(), out chonchucnang))
                {
                    Console.WriteLine("Nhap khong hop le. Vui long nhap lai.");
                    continue;
                }

                switch (chonchucnang)
                {
                    case 1:
                        Console.WriteLine("------Chon ve muon nhap --------");
                        Console.WriteLine("a. Ve binh thuong");
                        Console.WriteLine("b. Ve vip ");
                        Console.WriteLine("c. Ve khuyen mai");
                        string so = Console.ReadLine().ToLower();

                        switch (so)
                        {
                            case "a":
                                var vth = new vebinhthuong();
                                vth.nhap();
                                Ql.themvemoi(vth);
                                break;
                            case "b":
                                var vkm = new vekhuyenmai();
                                vkm.nhap();
                                Ql.themvemoi(vkm);
                                break;
                            case "c":
                                var vp = new vevip();
                                vp.nhap();
                                Ql.themvemoi(vp);
                                break;
                            default:
                                Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Nhap ve muon tim");
                        string mavemuontim = Console.ReadLine();
                        Ql.Timkiemmve(mavemuontim);
                        break;
                    case 3:
                        Console.WriteLine("Nhap ma ve can xoa");
                        string mavemuonxoa = Console.ReadLine();
                        Ql.xoatheomave(mavemuonxoa);
                        break;
                    case 4:
                        Ql.hienthi();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Lua chon khong hop le. Vui long nhap lai.");
                        break;
                }

            } while (true);
        }
    }
}

