/*
 * [Your Title]
 * by Your Name, Date
 *  
 * This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 */

using System;

namespace Adventure
{
    public static class Game
    {

        static string CharacterName = "John Doe";


        public static void StartGame()
        {
            Console.WriteLine("Game Title");
            Console.WriteLine("Welcome to ...");
            NameCharacter();
        }

        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character's name to be?");
            CharacterName = Console.ReadLine();

            Console.WriteLine("Great! Your character is now named " + CharacterName);
        }
    }
    class Item
    {

    }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }

    }
}