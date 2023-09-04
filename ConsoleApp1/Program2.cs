{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("     _____ _____ ______ _____  _____");
    Console.WriteLine("    / ___// __ // __  // ___/ / ___/");
    Console.WriteLine("   / /__ / /_/// /_/ // /    / /__");
    Console.WriteLine("  /__  // ___// __  // /    / ___/");
    Console.WriteLine(" ___/ // /   / / / // /___ / /__");
    Console.WriteLine("/____//_/   /_/ /_//_____ /____/");
    Console.WriteLine("");
    Console.WriteLine("     _____  ______  ___    __  _____");
    Console.WriteLine("    / __ / / __  / /   |  / / /  __/");
    Console.WriteLine("   / /_// / / / / / /| | / / / / ___ ");
    Console.WriteLine("  / ___/ / / / / / / | |/ / / / /  / ");
    Console.WriteLine(" / /    / /_/ / / /  |   / / /__/ /");
    Console.WriteLine("/_/    /_____/ /_/   |__/  |_____/");
    Console.WriteLine("               (II)");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n\nWelome to the thrilling world of space table pong!\nGet ready to face fearsome foes in nail biting battles that will require all your brains, brawn, wit and cunning, as\n" +
        "well as a splash of luck.\n" +
        "\n" +
        "This exciting adventure will let you be the hero or villain in a world of your design, in your own adventure, your way, and all delivered through the truly mind expanding medium of text." +
        "\n\n" +
        "Let's get your character created and set them free in to the world of Space Pong II: Dropped Balls\n");
    Console.ForegroundColor = ConsoleColor.White; 
    Console.WriteLine("Press Enter to continue");
    Console.ReadLine();
}
{
    String PlayerName = "Aaron Aardvark";
    String RealName = "Something Awesome";
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Before we begin, we're going to need to set up your character. Firstly, they'll need a name... Make it something \nthat will really blow your Space Pong (II) foes away, fill them with fear, make them quake in their pathetic \nspace booties... \n\n" +
        "Make it, Something Awesome\n");
    Console.ForegroundColor = ConsoleColor.White; 
    Console.WriteLine("Player name:");
    PlayerName = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (PlayerName != RealName)
    {
        Console.WriteLine($"\n{PlayerName}? Really? No, that won't do. You'll have to start the game again. Try and think of Something Awesome next time.");
    }
    else
    {
        Console.WriteLine($"\n{PlayerName}? \nWhat a brilliant name! Stunning! Magnifique! Your Space Pong (II) foes are sure to be crying and cowering \nat just the mention of your name.\n");
        Console.WriteLine("Now, let's begin\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(format:"You are standing in the middle of the International Space Pong Tournament arena vestibule, waiting in line to register for the ISPT Open. \nYou're not sure why you thought of entering the tournament as you find Space Pong incredibly, tediously boring and now the thought of waiting in line any longer to play the ridiculous game makes your feet itch.");
        Console.WriteLine("Looking aroud the vestibule, you see a ");
    }
}
    /*$"Name:\t {PlayerName});
Console.WriteLine("\nPlease update your player name to Something Awesome\n");
Console.Write("Please input your first name: ");
PlayerName = Console.ReadLine();
Console.Write("Please input your age: ");
PlayerAge = Console.ReadLine();
Console.WriteLine($"\nPlayer details have been updated.\nYour new details are\nName:\t" + PlayerName + "\nAge:\t" + PlayerAge + "\n\nGAME OVER. You have died of being a loser.\n\nHonestly, did you think a character called " + FirstName + " " + LastName + " would be worthy enough to go on an exciting \nadventure called Space Pong II: Dropped Balls?\n\nThanks for playing! Please try again with a better character.");


    */