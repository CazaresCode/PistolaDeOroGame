using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
    public abstract class Building

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
    public class Saloon : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public Saloon (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    public class TradingPost : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public TradingPost (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    public class Bank : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public Bank (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    public class Church : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public Church (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    public class Hotel : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public Hotel (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    public class Mine : Building
    {
        /// <summary> For Randomizer  </summary>
        public int Rooms { get; }
        public List<string> Exits { get; }
        public string Lobby { get; }

        public Mine (int rooms, List<string> exits, string lobby)
        {
            Rooms = rooms;
            Exits = exits;
            Lobby = lobby;
        }
    }
    
}
