using System;
using CombatCalc;

namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
    public static class Game
    {
        static string CharacterName = "Jack Daniels";

        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Narrative(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void StartGame()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n ███▄    █  ▒█████  ▄▄▄█████▓    ▄▄▄         ▓█████▄  ██▀███   ▒█████   ██▓███     \n ██ ▀█   █ ▒██▒  ██▒▓  ██▒ ▓▒   ▒████▄       ▒██▀ ██▌▓██ ▒ ██▒▒██▒  ██▒▓██░  ██▒   \n▓██  ▀█ ██▒▒██░  ██▒▒ ▓██░ ▒░   ▒██  ▀█▄     ░██   █▌▓██ ░▄█ ▒▒██░  ██▒▓██░ ██▓▒   \n▓██▒  ▐▌██▒▒██   ██░░ ▓██▓ ░    ░██▄▄▄▄██    ░▓█▄   ▌▒██▀▀█▄  ▒██   ██░▒██▄█▓▒ ▒   \n▒██░   ▓██░░ ████▓▒░  ▒██▒ ░     ▓█   ▓██▒   ░▒████▓ ░██▓ ▒██▒░ ████▓▒░▒██▒ ░  ░   \n░ ▒░   ▒ ▒ ░ ▒░▒░▒░   ▒ ░░       ▒▒   ▓▒█░    ▒▒▓  ▒ ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ▒▓▒░ ░  ░   \n░ ░░   ░ ▒░  ░ ▒ ▒░     ░         ▒   ▒▒ ░    ░ ▒  ▒   ░▒ ░ ▒░  ░ ▒ ▒░ ░▒ ░        \n   ░   ░ ░ ░ ░ ░ ▒    ░           ░   ▒       ░ ░  ░   ░░   ░ ░ ░ ░ ▒  ░░          \n         ░     ░ ░                    ░  ░      ░       ░         ░ ░              \n                                              ░                                    \n");
            Console.ResetColor();
            Console.WriteLine("Welcome to Drop, a depressing adventure game");
            NameCharacter();
        }

        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character to be called?");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"You are called {CharacterName}, a pathetic individual. Let your adventure commence...\n");
            ChapterOne();
        }
        public static void ChapterOne()
        {
            Narrative("For some reason you find yourself curled up in a ball, lying in a small pool of vomit in the opening of a dungeon. Judging by the taste in your mouth and the stains down the front of your shirt, the vomit is yours. You wrack your brain trying to remember how you got here, but nothing comes. Your head is pounding and you feel sick, dizzy and dehydrated. Did someone hit you over the head and dump you here? You want tp curl up again and go back to sleep but know you know you can't stay in such a dangerous place so unsteadily get on your feet. \n\nBefore you can look around properly you're accosted by a shambling beast of some sort! The monster is unbelievably hairy, bears an eye-watering stench and you can see some torturous weapons clenched tightly in its taloned paws.\nIt lunges towards you in attack\n");
            CombatCalc.Calculation.CombatCalculation();
        }
        public static void ChapterTwo()
        {
            Console.WriteLine("Which direction would you like to walk?");
        }
    }
    class Player
    {
        //public int playerHealth = 100;
    }
    class Item
    {

    }
    class Enemies
    {

    }
}
