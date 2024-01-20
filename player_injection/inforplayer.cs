using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_injection
{
    internal class inforplayer:Iinforplayer
    {
       public void tennv(string a)
        {
            Console.WriteLine("ten nhan vat la :"+a);
        }
       public  void luongmau(int b)
        {
            Console.WriteLine("luong mau hien tai" + b);
        }
       public void tuoi(int c)
        {
            Console.WriteLine("tuoi " + c);
        }
    }
}
