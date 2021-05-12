﻿using System;
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

            Console.WriteLine("\n\n\nAh. That does sound pretty tasty. Too bad I don't have any of it on me. But I think they sell that at the Saloon in Pistola De Oro. It is straight ahead.\n\n\n");
            Console.ReadKey();
            //Transportation

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("How would you like to get there, pick one:\n\n\n" +
                    "1. Horse\n" +
                    "2. Spaceship\n" +
                    "3. Wagon\n" +
                    "4. Walking");

                string transportation = Console.ReadLine();

                if (transportation == "1")
                {
                    Console.WriteLine("Hi Ho Silver, You enter town riding fast"); //rewrite later
                    keepRunning = false;
                }
                else if (transportation == "2")
                {
                    Console.WriteLine("Beam me down Scotty, Your dropped off at the edge of the town");
                    keepRunning = false;
                }
                else if (transportation == "3")
                {
                    Console.WriteLine("The wheels on the wagon go round and round as your wagon speeds into town.");
                    keepRunning = false;
                }
                else if (transportation == "4")
                {
                    Console.WriteLine("What, you need to get your steps in? \n\n\n You drag your feet into town exhausted as you reach its limits.\n\n\n");
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("Stick to the script bub");
                    keepRunning = true;
                }
                player.Transpo = (Transportation)Convert.ToInt32(transportation); // (AC) would the first incorrect num mess up at the end when you access it again?
                Console.ReadKey();
            }


            //They are at the street:

            Console.WriteLine("You finally arrived to the town and it is pretty dark. What would you like to do next?");
            Building currentBuilding = street;

            bool alive = true;
            while (alive)
            {
                Console.WriteLine(currentBuilding.Lobby);

                string command = Console.ReadLine().ToLower();

                Console.Clear();

                // command to go or exit

                if (command.StartsWith("go") || command.StartsWith("exit"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentBuilding.Exits)
                    {
                        if(command.Contains(exit) && Buildings.ContainsKey(exit))
                        {
                            currentBuilding = Buildings[exit];
                            foundExit = true;
                            break;
                        }
                        if (!foundExit)
                        {
                            Console.WriteLine("At full tilt you high tail it to the street.");
                        }
                    } 
                }
                else
                {
                    Console.WriteLine("Cheeseburger");
                }


                // grab the pistol



            }


            
            Console.ReadKey();






        }

        //The type of buildings are below:
        public static Building saloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can either go to the CELLAR or head back to the STREET.\n",
            new List<string> { "cellar", "street" }
            );

        public static Building tradingPost = new Building(
            "\n\n\nYou are in the Trading Post. The goods sparkle enough to catch your eye. The clerk nods at you.\n\n\n" +
            "You can either go to the BACKROOM or head back to the STREET.\n",
            new List<string> { "backroom", "street" }
            );

        public static Building hotel = new Building(
            "\n\n\n Your investigation leads you to the hotel. The air is dry and mice scurry along the partially rotted floor.\n\n\n" +
            "You can either go to the KITCHEN or head back to the STREET.\n",
            new List<string> { "kitchen", "street" }
            );

        public static Building bank = new Building(
                    "\n\n\nWhile meandering you spot the bank. Your eyes turn into dollar signs. $$\n\n\n" +
                    "You can either go into the VAULT or head back to the STREET.\n",
                    new List<string> { "vault", "street" }
                    );

        public static Building church = new Building(
                    "\n\n\nEerily you edge toward the church. A raven croaks as you take your first step toward the pitch black of the santuary and you swear it says nevermore.\n\n\n" +
                    "You can either go to the SANTUARY or head back to the STREET.\n",
                    new List<string> { "santuary", "street" }
                    );

        public static Building street = new Building(
            "\n\n\n You are on the street. The light from the moon shines off on your trusty pistol.\n\n\n" +
            "You see several buildings.\n\n" +
            "SALOON\n" +
            "TRADING POST\n" +
            "HOTEL\n" +
            "BANK\n" +
            "CHURCH", 
            new List<string> { "saloon", "trading post", "hotel", "bank", "church" }
            );


        public readonly Dictionary<string, Building> Buildings = new Dictionary<string, Building>
        {
            {"street", street},
            {"saloon", saloon},
            {"trading Post", tradingPost},
            {"hotel", hotel},
            {"bank", bank},
            {"Church", church},
            };
    }
}
