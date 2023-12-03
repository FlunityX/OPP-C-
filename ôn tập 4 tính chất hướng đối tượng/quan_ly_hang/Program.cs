using quan_ly_hang;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

dondathang dondathang = new dondathang();

int chonchucnang = 0;

do
{
    Console.WriteLine("1. Them don hang ");
    Console.WriteLine("2. Xoa don hang theo ten");
    Console.WriteLine("3. So tien cao nhat ");
    Console.WriteLine("4. In ra mat hang hoa don cao nhat ");
    Console.Write("Chon chuc nang (1-4): ");
    chonchucnang = int.Parse(Console.ReadLine());

    switch (chonchucnang)
    {
        case 1:
            {
                Console.WriteLine("a. Hang dien thoai");
                Console.WriteLine("b. May tinh xach tay ");
                Console.WriteLine("c. Hang thoi trang ");
                Console.Write("Chon mat hang muon mua (a/b/c): ");
                string mathangdachon = Console.ReadLine();
                if (mathangdachon.ToLower() == "a")
                {
                    hangdienthoai mh = new hangdienthoai();
                    mh.nhap();
                    dondathang.nhapdonhang();
                    dondathang.themmathangmoi(mh);
                }
                else if (mathangdachon.ToLower() == "b")
                {
                    maytinhxachtay mh = new maytinhxachtay();
                    mh.nhap();
                    dondathang.nhapdonhang();
                    dondathang.themmathangmoi(mh);
                }
                else if (mathangdachon.ToLower() == "c")
                {
                    hangthoitrang mh = new hangthoitrang();
                    mh.nhap();
                    dondathang.nhapdonhang();
                    dondathang.themmathangmoi(mh);
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le");
                }
                break;
            }
        case 2:
            {
                Console.WriteLine("Nhap ma san pham mat hang can xoa ");
                int mhcanxoa = int.Parse(Console.ReadLine());
                dondathang.xoamathang(mhcanxoa);
                break;
            }
        case 3:
            {
                dondathang.TinhTongTien();
                dondathang.xuatdonhang();
                break;
            }

        case 4:
            {
                dondathang.xuatdonhang();
                dondathang.giabancaonhat();
                break;
            }
        default:
            {
                Console.WriteLine("Lua chon khong hop le");
                break;
            }
    }

    Console.WriteLine("Nhan Enter de tiep tuc...");
    Console.ReadLine();

} while (true);

