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
            //PistolaDeOroGame_Repo coverPage = intro;
            Console.WriteLine("\n\n\n\n\n\n\nI may not have gone where I intended to go, but I think I have ended up where I inteded to be." +
                "\n\n\nPress any key to continue...");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\t\t\t-Douglas Adams." +
                "\n\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\n\t\tWelcome to:\n\n\n\t\t\tPistola De Oro" +
                "\n\n\nPress any key to continue...");
            Console.Clear();

            Console.WriteLine("After 1000 nights reading by an open fire. I am so close to reaching my final goal.\n\n" +
                "El Diablo Roja or the red devil spent 16 years terrorizing the town of Petite plateau and was the direct cause of the name change to Pistola De Oro.\n\n" +
                "Known for his gold pistol at his side people came from miles around to see the impressive piece of equipment.\n\n" +
                "This eventually led to his paranoia that his beloved pistol would be stolen.\n\n" +
                "The last two years of his life he was said to have killed over 50 innocent people merely curious about its craftsmanship.\n" +
                "It was because of this in 1972 he was gunned down." +
                "\n\n\nPress any key to continue...");
            Console.ReadKey();

            Console.WriteLine("\t\t\t\t\t\t\tBut his signature gold pistol was never found...." +
                "\n\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("There are many archeologists who say that his pistol doesn’t exist that there was a mistranslation. But I know it exists. I have read all the accounts and that is why I am here today. I will preserve the History. I will set accounts right." +
                "\n\n\nPress any key to continue begin your adventure.");
            Console.ReadKey();
            Console.Clear();
            // end of intro 

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
            Console.Clear();

            //Transportation
            bool keepRunning = true;
            while (keepRunning)
            {
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
                player.Transpo = (Transportation)Convert.ToInt32(transportation);
                Console.ReadKey();
            }

            //They are at the street:
            Console.Clear();
            Console.WriteLine("\n\n\n\tAs you arrive you noticed the town is darker than normal. You pull out your trusty lantern. Your research indicated the gold pistol should be hidden here.\n\n\n" +
                "You might want to explore the buildings by typing GO and then your LOCATION. For example, GO STREET.\n\n\n" +
                "Okay?\n\n" +
                "Press any key to begin YOUR adventure.\n" +
                "\t\t\t\t\t\t\t\tGOOD LUCK!");
            Console.ReadKey();
            Console.Clear();

            Building currentBuilding = street;


            //random generator
            Array values = Enum.GetValues(typeof(PistolRoom));
            Random random = new Random();
            PistolRoom randomRoom = (PistolRoom)values.GetValue(random.Next(values.Length));
            int randomRoomInt = (int)randomRoom;

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
                if (randomRoomInt == 0 && command.StartsWith("go") && currentBuilding == rightMine)
                {
                    Console.WriteLine($"You found the gold pistol next to the pickaxe!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 1 && command.StartsWith("go") && currentBuilding == door1Hotel)
                {
                    Console.WriteLine($"You found the gold pistol under the bed!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 2 && command.StartsWith("go") && currentBuilding == upstairsSaloon)
                {
                    Console.WriteLine($"You found the gold pistol in a box!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                 if (randomRoomInt == 3 && command.StartsWith("go") && currentBuilding == restroomTradingPost)
                {
                    Console.WriteLine($"You found the gold pistol in the toliet bowl!!!\n\n\n" +
                        $"Ew\n\n\n" +
                        $"BUT! You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 4 && command.StartsWith("go") && currentBuilding == cellarSaloon)
                {
                    Console.WriteLine($"You found the gold pistol hidden in a crate of sasparilla!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 5 && command.StartsWith("go") && currentBuilding == backroomTradingPost)
                {
                    Console.WriteLine($"You found the gold pistol behind a false wooden wallpanel!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 6 && command.StartsWith("go") && currentBuilding == kitchenHotel)
                {
                    Console.WriteLine($"You found the gold pistol in a rotten buffalo carcass!! YUCK!!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 7 && command.StartsWith("go") && currentBuilding == vaultBank)
                {
                    Console.WriteLine($"You found the gold pistol behind a valuable painting of El Diablo Rojo hanging on the back of the vualt door!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (randomRoomInt == 8 && command.StartsWith("go") && currentBuilding == tellerWindowBank)
                {
                    Console.WriteLine($"You found the gold pistol in a small cubby beneath the register!!\n\n\n\n\n" +
                        $"You won, {player.Name}! Please enjoy a plate of {player.FavFood}.");
                    break;
                }
                if (command.StartsWith("go") && currentBuilding == sanctuaryChurch)
                {
                    Console.WriteLine($"Yout foot never hits the ground you instantly fall to your death!! Don't you read Edgar Allen Poe!?!? \n\n\n" +
                        $"Try Again, {player.Name}!");
                    alive = false;
                }
                if (command.StartsWith("go") && currentBuilding == straightMine)
                {
                    Console.WriteLine($"Its so dark you don't see the large rock in front of you you trip and land face first into a pickaxe instantly dying.!!\n\n" +
                        $"Try Again, {player.Name}!");
                    alive = false;
                }
                if (command.StartsWith("go"))
                {
                    Console.WriteLine();
                    
                }
                else
                {
                    Console.WriteLine("\n\n\nYou know I can't help you. If you are lost, GO back to the STREET\n\n\n");
                }
            }
            Console.WriteLine("You could travel back in time and play again...\n\n\n\n\n\n" +
                "\t\t\t\t\t\twho knows where the pistol would be next time...");
            Console.ReadKey();
        }

        // Item stuff

        private enum PistolRoom { rightMine, door1, upstairsSaloon, restroomTradingPost, cellarSaloon, backroomTradingPost, kitchenHotel, vaultBank, tellerWindowBank };

        // The buildings and their rooms are below:
        //saloon
        private static Building saloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can head UPSTAIRS, down to the CELLAR, or head back to the STREET.\n\n\n",
            new List<string> { "cellar", "upstairs", "street" }
            );

        private static Building upstairsSaloon = new Building(
            "\n\n\nYou mosey into the saloon. The floor is sticky.\n\n\n" +
            "You can only go back to the SALOON. NO jumping out of windows...\n\n\n",
            new List<string> { "saloon" }
            );

        private static Building cellarSaloon = new Building(
            "\n\n\nYou step into a sticky situation. It is a little chilly... could it be the ghost who haunts this building?\n\n\n" +
            "You can only go back to the SALOON lobby.\n\n\n",
            new List<string> { "saloon" }
            );

        //Trading Post
        private static Building tradingPost = new Building(
            "\n\n\nYou are in the Trading Post. The goods sparkle enough to catch your eye. The clerk nods at you.\n\n\n" +
            "You can go to the BACKROOM, RESTROOM or head back to the STREET.\n\n\n",
            new List<string> { "backroom", "street", "restroom" }
            );

        private static Building backroomTradingPost = new Building(
            "\n\n\nYou are in a small storage room, but it smells oddly nice in here. It might be the perfurme, actually. \n\n\n" +
            "You can only go back to the TRADING POST lobby.\n\n\n",
            new List<string> { "trading post" }
            );

        private static Building restroomTradingPost = new Building(
            "\n\n\nNo judging for checking out the throne room.\n\n\n" +
            "You can only go back to the TRADING POST lobby.\n\n\n",
            new List<string> { "trading post" }
            );

        //Mine
        private static Building mine = new Building(
            "\n\n\nThe mine shaft is quiet. It is still dark due to the lantern flickering. Do you really think it is a good idea to move another step forward?" +
            "\n\n\nYou could STRAIGHT ahead into the darkness, turn RIGHT, or just turn back to the STREET.\n\n\n",
            new List<string> { "street", "straight", "right" }
            );

        private static Building straightMine = new Building(
            "\n\n\nYou fall into a hole. It goes on for miles, that you... die.\n\n\n\n\nI told you, didn't I?\n\n\n",
            new List<string> { }
            );

        private static Building rightMine = new Building(
            "\n\n\nYou see timesheets with names on it." +
            "\n\n\nYou should go back the same way you came here. Go back to the MINE entrance.\n\n\n",
            new List<string> { "mine" }
            );

        //hotel
        private static Building hotel = new Building(
            "\n\n\n Your investigation leads you to the hotel. The air is dry and mice scurry along the partially rotted floor.\n\n\n" +
            "You can either go up to the SECOND FLOOR, to the KITCHEN or head back to the STREET.\n\n\n",
            new List<string> { "second floor", "kitchen", "street" }
            );

        private static Building secondFloorHotel = new Building(
            "\n\n\nYou creep upstairs. You notice only two doors are intact as the rest of the upstairs has been destroyed by time.\n\n\n" +
            "You can either go to DOOR1, DOOR2 or head back to the HOTEL main floor.\n\n\n",
            new List<string> { "door1", "door2", "hotel" }
            );

        private static Building door1Hotel = new Building(
            "\n\n\nYou pull the door handle and the door creeks loudly. You take a step as you light up the lantern to see a mostly intact room. Including tub mirror and small bed. \n\n\n" +
            "You can either go to DOOR2 or head back to the HOTEL lobby.\n\n\n",
            new List<string> { "door2", "hotel" }
            );

        private static Building door2Hotel = new Building(
            "\n\n\n You pull on the handle breaking it off. Using the lanturn you peer through the door hole and see and red glowing eye angrily looking back. You turn to leave pale as a ghost. \n\n\n" +
            "You can either go search the HOTEL lobby or head back to DOOR1.\n\n\n",
            new List<string> { "hotel", "door1" }
            );

        private static Building kitchenHotel = new Building(
            "\n\n\n Swearing you can smell food you head toward the kitchen. You see the woodburning stove flicker then fire explodes out its doors.\n\n\n" +
            "You can either go up to the SECOND FLOOR or head back to the HOTEL lobby.\n\n\n",
            new List<string> { "second floor", "hotel" }
            );

        //bank
        private static Building bank = new Building(
            "\n\n\nWhile meandering you spot the bank. Your eyes turn into dollar signs. $$\n\n\n" +
            "You can either go into the VAULT, TELLER WINDOW, or head back to the STREET.\n\n\n",
            new List<string> { "vault", "teller window", "street" }
            );

        private static Building tellerWindowBank = new Building(
            "\n\n\nYou slowly edge toward the derelict TELLER WINDOW to your left. You search through all the drawers.\n\n\n" +
            "You can either go into the VAULT or head back to the BANK lobby.\n\n\n",
            new List<string> { "vault", "bank" }
            );

        private static Building vaultBank = new Building(
            "\n\n\nYou excitedly head towards the vault. Your antipation that this will be the final destination of the pistol is rising. You search every inch of the vault.\n\n\n" +
            "You can only go back to the BANK lobby.\n\n\n",
            new List<string> { "bank" }
            );

        //church
        private static Building church = new Building(
            "\n\n\nEerily you edge toward the church. A raven croaks as you take your first step toward the pitch black of the santuary and you swear it says nevermore.\n\n\n" +
            "You can take another step forward towards the SANCTUARY or head back to the STREET.\n\n\n",
            new List<string> { "sanctuary", "street" }
            );

        private static Building sanctuaryChurch = new Building(
            "\n\n\nYour foot never reaches solid ground. You fall 100 feet into a dark solitary room closed off from the mine breaking your neck.\n\n\n" +
            "Again, I tried to warn you... Haven't you read Edgar Allen Poe?!\n\n\n",
            new List<string> { }
            );

        //street
        private static Building street = new Building(
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
        private readonly Dictionary<string, Building> Buildings = new Dictionary<string, Building>
        {
            {"street", street},
            {"saloon", saloon},
            {"upstairs", upstairsSaloon },
            {"cellar", cellarSaloon },
            {"trading post", tradingPost},
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
