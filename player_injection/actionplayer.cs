using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_injection
{
    internal class actionplayer:Iactionplayer
    {
        public void run(int d)
        {
            Console.WriteLine("run :" + d);
        }
        public void idle(int e)
        {
            Console.WriteLine("idle :" + e);
        }
        public void jump(int k)
        {
            Console.WriteLine("jump :" + k);
        }
    }
}
