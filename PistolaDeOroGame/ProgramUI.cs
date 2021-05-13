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
            Console.Clear();
            Console.WriteLine("You finally arrived to the town and it is pretty dark. You pull out your trusty lantern. Your research indicated the gold pistol is in this town.\n\n" +
                "To begin your search, type: go [location]");

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
                        Console.WriteLine("You are running out of time, oil, and perfurme. Better make a move. FAST!.");
                    }
                }
                else
                {
                    Console.WriteLine("You know I can't help you. If you are lost, GO to the STREET");
                }
                // grab the pistol
            }
            Console.ReadKey();
        }

        //The type of buildings are below:

        //saloon
        public static Building saloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can either go to the CELLAR or head back to the STREET.\n",
            new List<string> { "cellar", "second floor", "street" }
            );

        public static Building secondFloorSaloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can only go back to the saloon. NO jumping out of windows...\n",
            new List<string> { "saloon" }
            );

        public static Building cellarSaloon = new Building(
            "\n\n\nYou step into a sticky situation. It is a little chilly... could it be the ghost who haunts this building?\n\n\n" +
            "You can only go upstairs \n",
            new List<string> { "saloon" }
            );


        //Trading Post
        public static Building tradingPost = new Building(
            "\n\n\nYou are in the Trading Post. The goods sparkle enough to catch your eye. The clerk nods at you.\n\n\n" +
            "You can either go to the BACKROOM or head back to the STREET.\n",
            new List<string> { "backroom", "street" }
            );

        public static Building storageRoomTradingPost = new Building(
            "\n\n\nYou are in a small storage room, but it smells oddly nice in here. It might be the perfurme, actually. \n\n\n" +
            "You can only go back to the lobby of the Trading Post.\n",
            new List<string> { "trading post" }
            );

        public static Building restroomTradingPost = new Building(
            "\n\n\nNo judging for checking out the throne room.\n\n\n" +
            "You can only go back to the lobby of the Trading Post.\n",
            new List<string> { "trading post" }
            );


        //Mine

        public static Building mine = new Building(
            "\n\n\nThe mine shaft is quiet. It is still dark due to the lantern flickering. Do you really think it is a good idea to move another step forward?" +
            "\n\nYou could STRAIGHT ahead into the darkness, turn RIGHT, or just turn back to the street.",
            new List<string> { "street", "straight", "right" }
            );

        public static Building straightMine = new Building(
            "\n\n\nYou fall into a hole. It goes on for miles, that you... die.\n\n\n\n\nI told you, didn't I?",
            new List<string> { }
            );

        public static Building rightMine = new Building(
            "\n\n\nYou see timesheets with names on it." +
            "\n\nYou should go back the same way you came here.",
            new List<string> { "mine" }
            );

        //hotel
        public static Building hotel = new Building(
            "\n\n\n Your investigation leads you to the hotel. The air is dry and mice scurry along the partially rotted floor.\n\n\n" +
            "You can either go UPSTAIRS, to the KITCHEN or head back to the STREET.\n",
            new List<string> { "upstairs", "kitchen", "street" }
            );

        public static Building upstairsHotel = new Building(
            "\n\n\nYou creep upstairs. You notice only two doors are intact as the rest of the upstairs has been destroyed by time.\n\n\n" +
            "You can either go to DOOR1, DOOR2 or head back to the HOTEL main floor.\n",
            new List<string> { "door1", "door2", "hotel" }
            );

        public static Building door1Hotel = new Building(
            "\n\n\nYou pull the door handle and the door creeks loudly. You take a step as you light up the lantern to see a mostly intact room. Including tub mirror and small bed. \n\n\n" +
            "You can either go to DOOR2 or head back to the HOTEL lobby.\n",
            new List<string> { "door2", "hotel" }
            );

        public static Building door2Hotel = new Building(
            "\n\n\n You pull on the handle breaking it off. Using the lanturn you peer through the door hole and see and red glowing eye angrily looking back. You turn to leave pale as a ghost. \n\n\n" +
            "You can either go search the HOTEL lobby or head back to DOOR1.\n",
            new List<string> { "hotel", "door1" }
            );

        public static Building kitchenHotel = new Building(
            "\n\n\n Swearing you can smell food you head toward the kitchen. You see the woodburning stove flicker then fire explodes out its doors.\n\n\n" +
            "You can either go UPSTAIRS or head back to the HOTEL lobby.\n",
            new List<string> { "upstairs", "hotel" }
            );

        //bank
        public static Building bank = new Building(
            "\n\n\nWhile meandering you spot the bank. Your eyes turn into dollar signs. $$\n\n\n" +
            "You can either go into the VAULT, TELLER WINDOW, or head back to the STREET.\n",
            new List<string> { "vault", "teller window", "street" }
            );

        public static Building tellerWindowBank = new Building(
            "\n\n\nYou slowly edge toward the derelict TELLER WINDOW to your left. You search through all the drawers.\n\n\n" +
            "You can either go into the VAULT or head back to the BANK lobby.\n",
            new List<string> { "vault", "bank" }
            );

        public static Building vaultBank = new Building(
            "\n\n\nYou excitedly head towards the vault. Your antipation that this will be the final destination of the pistol is rising. You search every inch of the vault.\n\n\n" +
            "You can only go back to the BANK lobby.\n",
            new List<string> { "bank" }
            );

        //church
        public static Building church = new Building(
            "\n\n\nEerily you edge toward the church. A raven croaks as you take your first step toward the pitch black of the santuary and you swear it says nevermore.\n\n\n" +
            "You can take another step forward towards the SANCTUARY or head back to the STREET.\n",
            new List<string> { "sanctuary", "street" }
            );

        public static Building sanctuaryChurch = new Building(
            "\n\n\nYour foot never reaches solid ground. You fall 100 feet into a dark solitary room closed off from the mine breaking your neck.\n\n\n" +
            "Again, I tried to warn you... Haven't you read Edgar Allen Poe?!\n\n\n\n\n",
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
            "MINE",
            new List<string> { "saloon", "trading post", "hotel", "bank", "church", "mine" });

        // Disctionary for the locations
        public readonly Dictionary<string, Building> Buildings = new Dictionary<string, Building>
        {
            {"street", street},
            {"saloon", saloon},
            {"second floor", secondFloorSaloon },
            {"cellar", cellarSaloon },
            {"trading Post", tradingPost},
            {"storage room", storageRoomTradingPost },
            {"restroom", restroomTradingPost },
            {"mine", mine },
            {"right", rightMine },
            {"straight", straightMine },
            {"hotel", hotel},
            {"kitchen", kitchenHotel},
            {"upstairs", upstairsHotel},
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
