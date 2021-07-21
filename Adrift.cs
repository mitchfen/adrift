using System;
using Pastel;

namespace Adrift 
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Global variables
            Player player = new Player();

            while (player.keepGoing) {
               switch (player.location) {
                    // Cryo
                    case 'C':
                        cryo(player);
                        break;
                    case 'c':
                        corridor(player);
                        break;
                    /*
                    case 'g':
                        galley(input, player);
                        break;
                    case 'e':
                        engineRoom(input, player);
                        break;
                    case 'h':
                        hydroponics(input, player);
                        break;
                    case 'a':
                        AIcore(input, player);
                        break;
                    case 's':
                        storage(input, player);
                        break;
                    case 'R':
                        primaryReactor(input, player);
                        break;
                    case 'b':
                        bridge(input, player);
                        break;
                    case 'o':
                        observationDeck(input, player);
                        break;
                    // Main corridor
                    case 'm':
                        mainCorridor(input, player);
                        break;
                    // Secondary reactor
                    case 'z':
                        secondaryReactor(input, player);
                        break;
                    // switch to blank room to trigger win
                    case 'w':
                        break;
                    // q to quit
                    case 'q':
                        return 0;
                    */
                }
            }
            Console.WriteLine("You win <3");
        }

        static void cryo(Player player) 
        {
            while (player.location == 'C'){
                write("You are now in the cryo bay.");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "help":
                        helpFunction(player);
                        break;
                    case "look":
                        write("You are standing in the cryo bay.");
                        write("The door on your left leads to the aft corridor.");
                        write("There are four cryo pods and a terminal here.");
                        break;
                    case "activate terminal":
                        terminal1(player);
                        break;
                    case "go left":
                        player.location = 'c';
                        break;
                    case "read leaflet":
                        readLeaflet(player);
                        break;
                    case "inventory":
                        inventoryChecker(player);
                        break;
                    case "quit":
                        player.location = 'q';
                        break;
                    default:
                        invalidCommand(input);
                        break;
                }
            }
        }

        static void corridor(Player player) 
        {
            while (player.location == 'c'){
                write("You are standing in the corridor.");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "help":
                        helpFunction(player);
                        break;
                    case "look":
                        write("You are standing in the corridor.");
                        break;
                    case "activate terminal":
                        terminal1(player);
                        break;
                    case "go left":
                        player.location = 'c';
                        break;
                    case "read leaflet":
                        readLeaflet(player);
                        break;
                    case "inventory":
                        inventoryChecker(player);
                        break;
                    case "quit":
                        player.location = 'q';
                        break;
                    default:
                        invalidCommand(input);
                        break;
                }
            }
        }

        static void helpFunction(Player player) 
        {
            write("Helping you stub");
        }

        static void terminal1(Player player) 
        {
            write("Terminal 1 stub");
        }

        static void readLeaflet(Player player) 
        {
            write("Reading leaflet stub");
        }

        static void inventoryChecker(Player player) 
        {
            write("Checking inventory stub");
        }

        static void invalidCommand(string input) 
        {
            write("idk what " + input + " means");
        }
        static void write(string msg)
        {
            Console.WriteLine(msg.Pastel("#1E90FF"));
        }
    }
}
