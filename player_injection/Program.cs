using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iinforplayer _info = new inforplayer();
            _info.tennv("a");
            _info.tuoi(9);
            _info.luongmau(67);
            Iactionplayer _ac = new actionplayer();
            _ac.run(1);
            _ac.jump(2);
            _ac.idle(3);
            injection _in = new injection(_info, _ac);
            _in.print();
            Console.ReadLine();

        }
    }
}
