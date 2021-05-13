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

            Console.WriteLine($"\n\n\nThank you for entering your name, {player.Name}.\n\n\n So, tell me, what is your favorite food at this time?\n\n\n");

            player.FavFood = Console.ReadLine();

            Console.WriteLine("\n\n\nAh. That does sound pretty tasty. Too bad I don't have any of it on me. But I think they sell that at the Saloon in Pistola De Oro. It is straight ahead.\n\n\n");
            Console.ReadKey();
            //Transportation

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("\n\n\nHow would you like to get there, pick one:\n\n\n" +
                    "1. Horse\n" +
                    "2. Spaceship\n" +
                    "3. Wagon\n" +
                    "4. Walking\n\n\n");

                string transportation = Console.ReadLine();

                if (transportation == "1")
                {
                    Console.WriteLine("\n\n\nHi Ho Silver, You enter town riding fast\n\n\n"); //rewrite later
                    keepRunning = false;
                }
                else if (transportation == "2")
                {
                    Console.WriteLine("\n\n\nBeam me down Scotty, You're dropped off at the edge of the town.\n\n\n");
                    keepRunning = false;
                }
                else if (transportation == "3")
                {
                    Console.WriteLine("\n\n\nThe wheels on the wagon go round and round as your wagon speeds into town.\n\n\n");
                    keepRunning = false;
                }
                else if (transportation == "4")
                {
                    Console.WriteLine("\n\n\nWhat, you need to get your steps in? \n\n\n You drag your feet into town exhausted as you reach its limits.\n\n\n");
                    keepRunning = false;
                }
                else
                {
                    Console.WriteLine("\n\n\nStick to the script bub!\n\n\n");
                    keepRunning = true;
                }
                player.Transpo = (Transportation)Convert.ToInt32(transportation); // (AC) would the first incorrect num mess up at the end when you access it again?
                Console.ReadKey();
            }

            //They are at the street:
            Console.Clear();
            Console.WriteLine("\n\n\nYou finally arrived to the town and it is pretty dark. You pull out your trusty lantern. Your research indicated the gold pistol is in this town.\n\n\n" +
                "The best way to navigate through this town is by starting with GO and typing the name of the capitialized word/n/n" +
                "like this:\n" +
                "go street\n" +
                "OR\n" +
                "go to the street\n" +
                "OR\n" +
                "go to the scary and dusty street.\n\n\n");

            Building currentBuilding = street;

            bool alive = true;
            while (alive)
            {
                Console.WriteLine(currentBuilding.Lobby);

                string command = Console.ReadLine().ToLower();

                Console.Clear();

                // command to go or exit

                if (command.StartsWith("go"))
                {
                    bool foundExit = false;
                    foreach (string exit in currentBuilding.Exits)
                    {
                        if (command.Contains(exit) && Buildings.ContainsKey(exit))
                        {
                            currentBuilding = Buildings[exit];
                            foundExit = true;
                            break;
                        }
                    }
                    if (!foundExit)
                    {
                        Console.WriteLine("\n\nYou are running out of time, oil, and perfurme. Better make a move. FAST!.\n\n\n");
                    }
                }

                // grab the pistol
                //else if (command.StartsWith("get ") || command.StartsWith("take ") || command.StartsWith("grab ") || command.StartsWith("retrieve "))
                //{
                //    bool foundItem = false;
                //    foreach (Item item in currentBuilding.Items)
                //    {
                //        if (!foundItem && command.Contains(item.ToString()))
                //        {
                //            Console.WriteLine($"You found a(n) {item}." +
                //                $"Press any key to continue...");
                //            currentBuilding.RemoveItem(item);
                //            inventory.Add(item);
                //            foundItem = true;
                //            Console.ReadKey();
                //            break;
                //        }
                //    }
                //    if (!foundItem)
                //    {
                //        Console.WriteLine("Are you sure it is there... It is getting late.");
                //    }
                //}



                else
                {
                    Console.WriteLine("\n\n\nYou know I can't help you. If you are lost, GO back to the STREET\n\n\n");
                }
            }
            Console.ReadKey();
        }

        //Item stuff

        public List<Item> inventory = new List<Item>();


        //The buildings and their rooms are below:

        //saloon
        public static Building saloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can head UPSTAIRS, down to the CELLAR, or head back to the STREET.\n\n\n",
            new List<string> { "cellar", "second floor", "street" }
            );

        public static Building upstairsSaloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can only go back to the SALOON. NO jumping out of windows...\n\n\n",
            new List<string> { "saloon" }
            );

        public static Building cellarSaloon = new Building(
            "\n\n\nYou step into a sticky situation. It is a little chilly... could it be the ghost who haunts this building?\n\n\n" +
            "You can only go back to the SALOON lobby.\n\n\n",
            new List<string> { "saloon" }
            );

        //Trading Post
        public static Building tradingPost = new Building(
            "\n\n\nYou are in the Trading Post. The goods sparkle enough to catch your eye. The clerk nods at you.\n\n\n" +
            "You can go to the BACKROOM, RESTROOM or head back to the STREET.\n\n\n",
            new List<string> { "backroom", "street", "restroom" }
            );

        public static Building backroomTradingPost = new Building(
            "\n\n\nYou are in a small storage room, but it smells oddly nice in here. It might be the perfurme, actually. \n\n\n" +
            "You can only go back to the TRADING POST lobby.\n\n\n",
            new List<string> { "trading post" }
            );

        public static Building restroomTradingPost = new Building(
            "\n\n\nNo judging for checking out the throne room.\n\n\n" +
            "You can only go back to the TRADING POST lobby.\n\n\n",
            new List<string> { "trading post" }
            );


        //Mine
        public static Building mine = new Building(
            "\n\n\nThe mine shaft is quiet. It is still dark due to the lantern flickering. Do you really think it is a good idea to move another step forward?" +
            "\n\n\nYou could STRAIGHT ahead into the darkness, turn RIGHT, or just turn back to the street.\n\n\n",
            new List<string> { "street", "straight", "right" }
            );

        public static Building straightMine = new Building(
            "\n\n\nYou fall into a hole. It goes on for miles, that you... die.\n\n\n\n\nI told you, didn't I?\n\n\n",
            new List<string> { }
            );

        public static Building rightMine = new Building(
            "\n\n\nYou see timesheets with names on it." +
            "\n\n\nYou should go back the same way you came here. Go back to the MINE entrance.\n\n\n",
            new List<string> { "mine" }
            );

        //hotel
        public static Building hotel = new Building(
            "\n\n\n Your investigation leads you to the hotel. The air is dry and mice scurry along the partially rotted floor.\n\n\n" +
            "You can either go up to the SECOND FLOOR, to the KITCHEN or head back to the STREET.\n\n\n",
            new List<string> { "second floor", "kitchen", "street" }
            );

        public static Building secondFloorHotel = new Building(
            "\n\n\nYou creep upstairs. You notice only two doors are intact as the rest of the upstairs has been destroyed by time.\n\n\n" +
            "You can either go to DOOR1, DOOR2 or head back to the HOTEL main floor.\n\n\n",
            new List<string> { "door1", "door2", "hotel" }
            );

        public static Building door1Hotel = new Building(
            "\n\n\nYou pull the door handle and the door creeks loudly. You take a step as you light up the lantern to see a mostly intact room. Including tub mirror and small bed. \n\n\n" +
            "You can either go to DOOR2 or head back to the HOTEL lobby.\n\n\n",
            new List<string> { "door2", "hotel" }
            );

        public static Building door2Hotel = new Building(
            "\n\n\n You pull on the handle breaking it off. Using the lanturn you peer through the door hole and see and red glowing eye angrily looking back. You turn to leave pale as a ghost. \n\n\n" +
            "You can either go search the HOTEL lobby or head back to DOOR1.\n\n\n",
            new List<string> { "hotel", "door1" }
            );

        public static Building kitchenHotel = new Building(
            "\n\n\n Swearing you can smell food you head toward the kitchen. You see the woodburning stove flicker then fire explodes out its doors.\n\n\n" +
            "You can either go up to the SECOND FLOOR or head back to the HOTEL lobby.\n\n\n",
            new List<string> { "second floor", "hotel" }
            );

        //bank
        public static Building bank = new Building(
            "\n\n\nWhile meandering you spot the bank. Your eyes turn into dollar signs. $$\n\n\n" +
            "You can either go into the VAULT, TELLER WINDOW, or head back to the STREET.\n\n\n",
            new List<string> { "vault", "teller window", "street" }
            );

        public static Building tellerWindowBank = new Building(
            "\n\n\nYou slowly edge toward the derelict TELLER WINDOW to your left. You search through all the drawers.\n\n\n" +
            "You can either go into the VAULT or head back to the BANK lobby.\n\n\n",
            new List<string> { "vault", "bank" }
            );

        public static Building vaultBank = new Building(
            "\n\n\nYou excitedly head towards the vault. Your antipation that this will be the final destination of the pistol is rising. You search every inch of the vault.\n\n\n" +
            "You can only go back to the BANK lobby.\n\n\n",
            new List<string> { "bank" }
            );

        //church
        public static Building church = new Building(
            "\n\n\nEerily you edge toward the church. A raven croaks as you take your first step toward the pitch black of the santuary and you swear it says nevermore.\n\n\n" +
            "You can take another step forward towards the SANCTUARY or head back to the STREET.\n\n\n",
            new List<string> { "sanctuary", "street" }
            );

        public static Building sanctuaryChurch = new Building(
            "\n\n\nYour foot never reaches solid ground. You fall 100 feet into a dark solitary room closed off from the mine breaking your neck.\n\n\n" +
            "Again, I tried to warn you... Haven't you read Edgar Allen Poe?!\n\n\n",
            new List<string> { }
            );

        //street
        public static Building street = new Building(
            "\n\nYou are on the STREET.\n\n\n" +
            "You see several buildings.\n\n" +
            "SALOON\n" +
            "TRADING POST\n" +
            "HOTEL\n" +
            "BANK\n" +
            "CHURCH\n" +
            "MINE\n\n\n",
            new List<string> { "saloon", "trading post", "hotel", "bank", "church", "mine" });

        // Disctionary for the locations
        public readonly Dictionary<string, Building> Buildings = new Dictionary<string, Building>
        {
            {"street", street},
            {"saloon", saloon},
            {"upstairs", upstairsSaloon },
            {"cellar", cellarSaloon },
            {"trading Post", tradingPost},
            {"backroom", backroomTradingPost },
            {"restroom", restroomTradingPost },
            {"mine", mine },
            {"right", rightMine },
            {"straight", straightMine },
            {"hotel", hotel},
            {"kitchen", kitchenHotel},
            {"second floor", secondFloorHotel},
            {"door1", door1Hotel},
            {"door2", door2Hotel},
            {"church", church},
            {"sanctuary", sanctuaryChurch },
            {"bank", bank},
            {"vault", vaultBank},
            {"teller window", tellerWindowBank}
        };
    }
}
