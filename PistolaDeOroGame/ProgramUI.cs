using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PistolaDeOroGame
{
    public class ProgramUI
    {

        public void Run()


            {
            // Insert introduction here------------------
            Console.WriteLine("\n\n\nBrave traveler, what is your Name?\n\n\n");

            MainPlayer player = new MainPlayer()
            {
                Name = Console.ReadLine()
            };

            Console.WriteLine($"\n\n\nThank you for entering your name, {player.Name}.\n\n\n So, tell me, what is your favorite food at this time?");

            player.FavFood = Console.ReadLine();
            
            //Transportation

            Console.WriteLine("\n\n\nAh. That does sound pretty tasty. Too bad I don't have any of it on me. But I think they sell that at the Saloon in Pistola De Oro. It is straight ahead. How would you like to get there, pick one:\n\n\n" +
                "1. Horse\n" +
                "2. Spaceship\n" +
                "3. Wagon\n" +
                "4. Walking");

            bool keepRunning = true;
            while (keepRunning)
            {
                string transportation = Console.ReadLine();

                if (transportation == "1")
                {
                    Console.WriteLine("Hi Ho Silver, You enter town riding fast");
                }
                else if (transportation == "2")
                {
                    Console.WriteLine("Beam me down Scotty, Your dropped off at the edge of the town");
                }
                else if (transportation == "3")
                {
                    Console.WriteLine("The wheels on the wagon go round and round as your wagon speeds into town.");
                }
                else if (transportation == "4")
                {
                    Console.WriteLine("What, you need to get your steps in? \n\n\n You drag your feet into town exhausted as you reach its limits.\n\n\n");
                }
                else
                {
                    Console.WriteLine("Stick to the script bub");
                    return;

                }
                player.Transpo = (Transportation)Convert.ToInt32(transportation);
               
                }
        }


    }
}
