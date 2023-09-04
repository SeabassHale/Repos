namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     _____ _____ ______ _____  _____");
            Console.WriteLine("    / ___// __ // __  // ___/ / ___/");
            Console.WriteLine("   / /__ / /_/// /_/ // /    / /__");
            Console.WriteLine("  /__  // ___// __  // /    / ___/");
            Console.WriteLine(" ___/ // /   / / / // /___ / /__");
            Console.WriteLine("/____//_/   /_/ /_//_____ /____/");
            Console.WriteLine("             PONG");
            Console.WriteLine("               2");
            Console.WriteLine("\n\nWelome to the thrilling world of space table pong!\nGet ready to face fearsome foes in nail biting battles that will require all your brains, brawn, wit and cunning, as\nwell as a splash of luck. \n\nThis exciting adventure will let you be the hero or villain in a world of your design, in your own adventure, your way, and all delivered through the truly mind melding medium of text.\n\nLet's get your character created and set them free in to the world of Space Pong II: Dropped Balls\n\nHit Enter to begin!");
            Console.ReadLine();
            String FirstName = "Aaron";
            String LastName = "Aardvark";
            String PlayerAge = "21";
            Console.WriteLine("Default Player Details");
            Console.WriteLine("Name:\t" + FirstName + " " + LastName + "\nAge:\t" + PlayerAge);
            Console.WriteLine("\nPlease update your player details\n");
            Console.Write("Please input your first name: ");
            FirstName = Console.ReadLine();
            Console.Write("Please input your last name: ");
            LastName = Console.ReadLine();
            Console.Write("Please input your age: ");
            PlayerAge = Console.ReadLine();
            Console.WriteLine($"\nPlayer details have been updated.\nYour new details are\nName:\t" + FirstName + " " + LastName + "\nAge:\t" + PlayerAge + "\n\nGAME OVER. You have died of being a loser.\n\nHonestly, did you think a character called " + FirstName + " " + LastName + " would be worthy enough to go on an exciting \nadventure called Space Pong II: Dropped Balls?\n\nThanks for playing! Please try again with a better character.");
        }
    }
}