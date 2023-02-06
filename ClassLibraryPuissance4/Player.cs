using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puissance4
{
    public abstract class Player
    {
        public int Color { get; protected set; }
        public string Name { get; protected set; }

        public abstract bool jouer(Party party);
    }
}
