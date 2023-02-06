using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer(int color)
        {
            Color = color;
            Name = "Ordinateur";
        }

        public override bool jouer(Party party)
        {
            party.Game.Display();
            Console.WriteLine("Vous souhaitez jouer sur quelle colone?");
            return true;
        }
    }
}
