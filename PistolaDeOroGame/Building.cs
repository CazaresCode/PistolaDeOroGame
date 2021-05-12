using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
    public class Building

    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; } 
        public List<string> Exits {get;}
        public string Lobby { get; }

        public Building(int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
}
