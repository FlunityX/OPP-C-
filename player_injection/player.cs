using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_injection
{
    public interface Iinforplayer
    {
        void tennv(string a);
        void luongmau(int b);
        void tuoi(int c);
    
    }
    public interface Iactionplayer
    {
        void run(int d);
        void idle(int e);
        void jump(int k);
    }
    internal class player
    {
    }
}
