/*
This is going to be a story set during one night that a recovering alcoholic has fallen off the wagon. This won't be apparant from the beginning but will be inferrable from the descriptions of events as the story progresses. Undecided at present on the greater reason for drinking again... Work? Relationship? Both? Probably both. Targeting being a commentary on the challenges faced by working class and the lack of support under the current government, but may just end up being tasteless shit.
*/

//character name
string characterName = "Jack Daniels";

//print out game title and overview

    Console.WriteLine("Drip");
    Console.WriteLine("Welcome to Drip. A wholly depressing game\n\n");

    //ask player for a name, and save it


    Random dice3 = new Random();
    Random dice6 = new Random();

    int monsterHealth = 100;
    int playerHealth = 100;

    int monsterAttack = 2;
    int monsterAttackBonus = dice3.Next(2, 4);
    int playerAttack = 3;
    int playerAttackBonus = dice6.Next(2);



    Console.WriteLine("For some reason you are wandering in a dungeon. In front of you is a shambling beast of some sort! The monster is unbelievably hairy, bears a eye-watering stench and you can see some torturous weapons clenched tightly in its taloned paws.\nIt lunges towards you in attack\n");
    {
        Console.WriteLine("Press any key to continue\n");
        Console.ReadKey();
        while (monsterHealth > 0 && playerHealth > 0)
        {
            int monsterSuccess = (dice3.Next(3) * monsterAttack) + monsterAttackBonus;
            int playerAttackSuccess = (dice6.Next(4) * playerAttack) + playerAttackBonus;

            if (monsterSuccess > playerAttackSuccess)
            {
                Console.WriteLine($"You were hit for {monsterSuccess} damage");
                playerHealth = (playerHealth - monsterSuccess);
                Console.WriteLine($"You have {playerHealth} health remaining.");
                Console.WriteLine($"The monster has {monsterHealth} health remaining\n");
            }
            else if (playerAttackSuccess > monsterSuccess)
            {
                Console.WriteLine($"You strike the beast for {playerAttackSuccess} hit points, causing it to yelp in pain");
                monsterHealth = (monsterHealth - playerAttackSuccess);
                Console.WriteLine($"The monster has {monsterHealth} health remaing");
                Console.WriteLine($"You have {playerHealth} health remaining\n");
            }
            else if (monsterHealth <= 0)
            {
                Console.WriteLine("You were victorious. Press Enter to continue");
                Console.ReadLine();
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("You have died. Please start again");
            }
            else
            {
                Console.WriteLine("You both miss striking each other\n");
            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
        if (monsterHealth <= 0)
        {
            Console.WriteLine("You were victorious in battle against the foul, unstoppable beast.\n\nUpon closer inspection of the unspeakable horror, you realise it wasn't a foul beast, but a mere man with a now split plastic coffee cup and a soft cap clenched in his hands. You recognise the style of cup from somewhere, but you can't place where.\n\nYou take a moment to assess your surroundings.\n\nThe dungeon is reasonably well lit, but positively filthy. You are stood on an elevated ledge with a set of steel rails set around 6 feet lower rolling off in to the pitch darkness to the North and South. The words Elephant and Castle are emblazoned in giant letters across the wall over the rail tracks. Well there's nowhere else to go and nothing else to do, so you jump down on the the tracks and start wandering North.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You have died. Please start again");
        }
    }
    if (playerHealth > 0)
    {
        Console.WriteLine("After a short spell, you see some light up ahead.");
    }
