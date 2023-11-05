namespace baitap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" CHAO MUNG BAN DEN VOI THONG KE KHU DAT");
            Console.WriteLine("1.nhap thong tin nha san vuon");
            Console.WriteLine("2.nhap thong tin nha pho ");
            Console.WriteLine("3.xem thong tin mac dinh ");
            Console.WriteLine("4.thoat ");
            Console.WriteLine("moi ban chon chuc nang ");
            do
            {
                int chon;
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nhapho np = new nhapho();
                        np.nhap();
                        np.xuat();
                        break;
                    case 2:
                        nhasanvuon nsv = new nhasanvuon();
                        nsv.nhap();
                        nsv.xuat();
                        break;
                    case 3:
                        nhapho np1 = new nhapho(" bien hoa ", 6, 8, 14);
                        np1.xuat();
                        nhasanvuon nsv1 = new nhasanvuon("trang bom", 8, 10, 25);
                        nsv1.xuat();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh...");
                        return;
                    default:
                        Console.WriteLine("NHAP LAI . SO KO HOP LE ");
                        break;
                }
            } while (true);
            Console.ReadLine();
        }

    }
}