using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
    public class Building
    {
        /// <summary> What the building is connected to.</summary>
        public List<string> Exits {get;}
        /// <summary>  item in the room to be generated randomly. </summary>
        /// <summary> The lobby is the first room the user enters. This would leave to another room, or rooms. So there is a "cw" stating the possible options on what to do or where to go.</summary>
        public string Lobby { get; }
        public bool HasGoldPistol { get; }

        public Building( string lobby, List<string> exits)
        {
            Exits = exits;
            Lobby = lobby;
        }
    }
}
