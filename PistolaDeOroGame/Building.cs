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
        /// <summary> The lobby is the first room the user enters. This would leave to another room, or rooms. So there is a "cw" stating the possible options on what to do or where to go.</summary>
        public string Lobby { get; }
        public Building( string lobby, List<string> exits)
        {
            Exits = exits;
            Lobby = lobby;
        }
    }

    //public class Saloon : Building
    //{

    //}
    //public class TradingPost : Building
    //{
    //    public new List<string> Exits { get; }
    //    public new string Lobby { get; }

    //    public TradingPost(List<string> exits, string lobby)
    //    {
    //        Exits = exits;
    //        Lobby = lobby;
    //    }
    //}
    //public class Bank : Building
    //{
    //    public List<string> Exits { get; }
    //    public string Lobby { get; }

    //    public Bank (List<string> exits, string lobby)
    //    {
    //        Exits = exits;
    //        Lobby = lobby;
    //    }
    //}
    //public class Church : Building
    //{
    //    public List<string> Exits { get; }
    //    public string Lobby { get; }

    //    public Church (List<string> exits, string lobby)
    //    {
    //        Exits = exits;
    //        Lobby = lobby;
    //    }
    //}
    //public class Hotel : Building
    //{
    //    public List<string> Exits { get; }
    //    public string Lobby { get; }

    //    public Hotel (List<string> exits, string lobby)
    //    {
    //        Exits = exits;
    //        Lobby = lobby;
    //    }
    //}
    //public class Mine : Building
    //{
    //    public List<string> Exits { get; }
    //    public string Lobby { get; }

    //    public Mine (List<string> exits, string lobby)
    //    {
    //        Exits = exits;
    //        Lobby = lobby;
    //    }
    //}
    
}
