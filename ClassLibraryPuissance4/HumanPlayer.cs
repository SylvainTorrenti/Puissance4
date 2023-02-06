using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(int color, string name)
        {
            Color = color;
            Name = name;
        }

        public override bool jouer(Party party)
        {
            party.Game.Display();
            Console.WriteLine("Vous souhaitez jouer sur quelle colone?");
            return true;
        }
    }
}
