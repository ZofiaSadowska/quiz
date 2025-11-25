using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class Player
    {
        public Player() { }

        public static Player Instance { get; } = new Player(); 

        public string Player1Name { get; set; }
        public int Player1Score { get; set; }

        public string Player2Name { get; set; }
        public int Player2Score { get; set; }
    }
}
