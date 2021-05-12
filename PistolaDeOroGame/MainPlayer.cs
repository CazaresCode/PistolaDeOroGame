using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
        public enum Transportation { horse, spaceship, wagon, walking }
    /// <summary>
    /// Main Player is the user. 
    /// </summary>
    public class MainPlayer
    {
        public string Name { get; set; }
        public string FavFood { get; set; } // Add it towards the end as a reward in addition to the golden pistol.
        public Transportation Transpo { get; set; }
        public bool IsAlive { get; }

        public MainPlayer(string name, string favFood, Transportation transportation, bool isAlive)
        {
            Name = name;
            FavFood = favFood;
            Transpo = transportation;
            IsAlive = isAlive;
        }

        public MainPlayer()
        {
        }
    }
}
