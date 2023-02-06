using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class Party
    {
        public ComputerPlayer ComputerPlayer { get; set; }

        public HumanPlayer HumanPlayer { get; set; }

        public Game CurrentGame { get; set; }

        public Party(ComputerPlayer computerPlayer, HumanPlayer humanPlayer, Game game)
        {
            ComputerPlayer = computerPlayer;
            HumanPlayer = humanPlayer;
            CurrentGame = game;
        }
        public bool IsEmpty()
        {

        }
    }
}
