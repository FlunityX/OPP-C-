using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace player_injection
{
    internal class injection
    {
        private Iinforplayer player;
        private Iactionplayer player_action;
        public injection(Iinforplayer player, Iactionplayer player_action)
        {
            this.player = player;
            this.player_action = player_action;
        }
        public void print()
        {
          
        }
    }
}
