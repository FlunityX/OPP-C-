using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace biến_tĩnh_phương_thức_tĩnh
{
    public class baitap_static
    {
        public static int count = 0;
        public static void Count()
        {
            count++;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        baitap_static dtg1 = new baitap_static();
        baitap_static.Count();
        baitap_static dtg2 =new baitap_static();
        baitap_static.Count();
        Console.WriteLine("co tat ca :"  + baitap_static.count+ " doi tuong dc khoi tao");
        Console.ReadLine();

        }
    }
}
