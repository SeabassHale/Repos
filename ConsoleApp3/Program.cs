namespace Adventure
{
    class Program
    {
        static void Main()
        {
            Game.TitleScreen();
            Console.ReadKey();
        }
    }
    public static class Game
    {
        static readonly string[] PartOne =
        {
            "For some reason you find yourself curled up in a ball, lying in a small pool of vomit in the opening of a dungeon. Judging by the taste in your mouth and the stains down the front of your shirt, the vomit is yours. You wrack your brain trying to remember how you got here, but nothing comes. Your head is pounding and you feel sick, dizzy and dehydrated. Did someone hit you over the head and dump you here? You want to curl up again and go back to sleep but know you can't stay in such a dangerous place, so unsteadily get on your feet. \n\nBefore you can look around properly you're accosted by a shambling beast of some sort! The monster is unbelievably hairy, bears an eye-watering stench and you can see some torturous weapons clenched tightly in its taloned paws.\n\nIt lunges towards you in attack\n",
            "You catch your breath and look over the unconscious man lying on the floor in front of you. He has a now split plastic coffee cup and a soft cap clenched in his hands. You recognise the style of cup from somewhere, and the face seems vaguely recognisable, but you can't place where from. You rummage around in the homeless man's pockets and find nothing but a now broken wind-up pocket-torch and a token with the letters AA stamped on one side and the number 24 on the other. It's not a lot, but you shove the token in to your pocket.\n",
            "You start raising your hands up getting ready to beg for forgiveness, but then realise the beast is no beast at all, but a man and it seems he recognises you. He's ranting and raving quite loudly, but you can't make out a word he's saying as the syllabals and consonants all slur together.\n\nAfter a short while, the man looks you up and down, admiring the vomit caking your clothes before letting out a sharp bark of delighted laughter. He reaches in to his pocket and passes you a small wind-up torch, giving you a wink as he turns and wanders back the way he came.\n\n The torch is of the sort kept on keyrings, and while not especially bright, could provide a little light to help navigate in pitch black areas. You drop the torch in to your pocket.\n",
            "You take a moment to assess your surroundings.\n\nThe dungeon is reasonably well lit, but positively filthy. You are stood on an elevated ledge over some steel rails set around 6 feet lower rolling off in to the pitch darkness to your left and right. The words Elephant and Castle are emblazoned in giant letters across the wall over the rail tracks.\n\nWith no better plan, you jump down to the tracks below and start walking.\n",
            "Within a few minutes, you are walking in absolute darkness. You try to use the rails as a foot guide in the darkness, but your feet keep slipping off the smoothed steel surface so end up walking on the planks instead, making sure to walk slowly and carefully. Before too long you feel a gust of warm, acrid smelling air blowing in your face and the ground starts to shake. Behind you, some distant shining light at the end of the tunnel is noisily making its way towards you.\n\nYou desperately search around for a space to hide, but the tunnel offers little in the way of cover. The monstrosity at the end of the tunnel is bearing down on you with a roar so load that it makes it hard to think. You start running and almost immediately trip over the planks, ending up sprawled prone between the rails.\n\nWith no choice, you lay as flat and still as you can, hoping whatever it is that's chasing you either gives up or has a sudden change of heart...\n\nFor a few minutes, the noise is so deafening that you can't hear yourself screaming.\n\nThen, as quickly as it appeared and started harassing you, the monstrosity is gone.\n",
            "you successfully make it to the next station\n",
            "transition to the next part of the story\n",
        };

        static readonly string[] PartTwo =
        {
            "As you crawl out of the station your stomach growls. You make your way in to a corner shop, despite having no money. Will you steal a TINNY or a SANDWICH?",
            "steal a tinny",
            "steal a sandwich",
            "escape from shop. Fight shopkeeper?",
            "drink tinny and feel re-energised",
            "eat sandwich and feel sick",
            "head back in to underground",
        };

        static readonly string[] PartThree =
        {
            "Get on train to central. FIGHT yob or make FRIENDS",
            "Fight train yob. Find lighter in his pocket",
            "Make friends with yob. Get given baggy of coke",
            "Get off train",
            "You help some person light cig",
            "You get in fight for offering coke to some guy that asked for a lighter",
            "Head outside and get arrested",
        };

        static int Scenarios = 3;

        static int playerHealth = 100;

        static int monsterHealth = 10;

        static string MonsterName = "";

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

        static void CombatText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }


        public static void TitleScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n ███▄    █  ▒█████  ▄▄▄█████▓    ▄▄▄         ▓█████▄  ██▀███   ▒█████   ██▓███     \n ██ ▀█   █ ▒██▒  ██▒▓  ██▒ ▓▒   ▒████▄       ▒██▀ ██▌▓██ ▒ ██▒▒██▒  ██▒▓██░  ██▒   \n▓██  ▀█ ██▒▒██░  ██▒▒ ▓██░ ▒░   ▒██  ▀█▄     ░██   █▌▓██ ░▄█ ▒▒██░  ██▒▓██░ ██▓▒   \n▓██▒  ▐▌██▒▒██   ██░░ ▓██▓ ░    ░██▄▄▄▄██    ░▓█▄   ▌▒██▀▀█▄  ▒██   ██░▒██▄█▓▒ ▒   \n▒██░   ▓██░░ ████▓▒░  ▒██▒ ░     ▓█   ▓██▒   ░▒████▓ ░██▓ ▒██▒░ ████▓▒░▒██▒ ░  ░   \n░ ▒░   ▒ ▒ ░ ▒░▒░▒░   ▒ ░░       ▒▒   ▓▒█░    ▒▒▓  ▒ ░ ▒▓ ░▒▓░░ ▒░▒░▒░ ▒▓▒░ ░  ░   \n░ ░░   ░ ▒░  ░ ▒ ▒░     ░         ▒   ▒▒ ░    ░ ▒  ▒   ░▒ ░ ▒░  ░ ▒ ▒░ ░▒ ░        \n   ░   ░ ░ ░ ░ ░ ▒    ░           ░   ▒       ░ ░  ░   ░░   ░ ░ ░ ░ ▒  ░░          \n         ░     ░ ░                    ░  ░      ░       ░         ░ ░              \n                                              ░                                    \n");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            NameCharacter();
            ChapterOne();
        }

        static void NameCharacter()
        {
            Console.WriteLine("What would you like your character to be called?");
            CharacterName = Console.ReadLine();
            Console.WriteLine($"You are called {CharacterName}, a pathetic individual. Let your adventure commence...\n");
            //ChapterOne();
        }

        public static void ChapterOne()
        {
            for (int section = 1; section <= Scenarios; section++)
            {

                string input = "";

                switch (section)
                {
                    case 1:
                        Narrative(PartOne[0]);
                        Choice1:
                        Console.Write("Will you FIGHT or attempt to BEFRIEND:");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        if (input == "fight")
                        {
                            monsterHealth = 20;
                            MonsterName = "Homeless Man";
                            CombatCalculation();
                            Narrative(PartOne[1]);
                        }

                        else if (input == "befriend")
                            Narrative(PartOne[2]);
                        else
                        {
                            Console.WriteLine("Command unrecognised.");
                            goto Choice1; 
                        }
                        Narrative(PartOne[3]);
                        Console.WriteLine("Press Enter to contine");
                        Console.ReadKey();
                        if (input == "fight")
                        {
                            Narrative(PartOne[4]);
                            Console.WriteLine("You take 20 points of damage from stumbling around in the dark");
                            playerHealth = (playerHealth - 20);
                            Console.WriteLine($"Your health is now {playerHealth}");
                        }
                        else
                            Narrative(PartOne[5]);
                        Narrative(PartOne[6]);
                        break;

                    case 2:
                        Narrative(PartTwo[0]);
                        Choice2:
                        Console.Write("Enter your choice:");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        if (input == "tinny")
                            Narrative(PartTwo[1]);
                        else if (input == "sandwich")
                            Narrative(PartTwo[2]);
                        else
                        {
                            Console.WriteLine("Command unrecognised.");
                            goto Choice2;
                        }
                        Narrative(PartTwo[3]);
                        monsterHealth = 30;
                        MonsterName = "Shopkeeper";
                        CombatCalculation();
                        if (input == "tinny")
                        {
                            Narrative(PartTwo[4]);
                            playerHealth = 100;
                        }
                        else
                            Narrative(PartTwo[5]);
                        Narrative(PartTwo[6]);
                        break;

                    case 3:
                        Narrative(PartThree[0]);
                        Console.Write("Enter your choice:");
                        input = Console.ReadLine();
                        input = input.ToLower();
                        if (input == "fight")
                        {
                            Narrative(PartThree[1]);
                            monsterHealth = 50;
                            CombatCalculation();
                        }
                        else
                            Narrative(PartThree[2]);
                        Narrative(PartThree[3]);
                        if (input == "fight")
                            Narrative(PartThree[4]);
                        else
                            Narrative(PartThree[5]);
                        Narrative(PartThree[6]);
                        break;
                }

            }

            {
                /*
            Narrative("For some reason you find yourself curled up in a ball, lying in a small pool of vomit in the opening of a dungeon. Judging by the taste in your mouth and the stains down the front of your shirt, the vomit is yours. You wrack your brain trying to remember how you got here, but nothing comes. Your head is pounding and you feel sick, dizzy and dehydrated. Did someone hit you over the head and dump you here? You want tp curl up again and go back to sleep but know you know you can't stay in such a dangerous place so unsteadily get on your feet. \n\nBefore you can look around properly you're accosted by a shambling beast of some sort! The monster is unbelievably hairy, bears an eye-watering stench and you can see some torturous weapons clenched tightly in its taloned paws.\nIt lunges towards you in attack\n");
            CombatCalc.Calculation.CombatCalculation();
            Narrative("You were victorious in battle against the foul, unstoppable beast.\n\nUpon closer inspection of the unspeakable horror, you realise it wasn't a foul beast, but a mere man with a now split plastic coffee cup and a soft cap clenched in his hands. You recognise the style of cup from somewhere, but you can't place where.\n\nYou take a moment to assess your surroundings.\n\nThe dungeon is reasonably well lit, but positively filthy. You are stood on an elevated ledge with a set of steel rails set around 6 feet lower rolling off in to the pitch darkness to the North and South. The words Elephant and Castle are emblazoned in giant letters across the wall over the rail tracks. Well there's nowhere else to go and nothing else to do, so you jump down on the the tracks.");
            Choice();
            */
            }
        }

        /*
        static void Choice()
        {
            string input = "";
            Console.WriteLine("Which way up the tracks will you head? North or South?");
            input = Console.ReadLine();
            input = input.ToLower();
            if (input == "north")
            {
                Narrative("You hop down on to the tracks and run North. Within a few minutes, you feel a gust of warm, acrid smelling air blowing in your face and the ground starts to shake. Some light at the end of the tunnel is making its way towards you, and fast.\n\nYou desperately search around for a space to hide, but the tunnel offers little in the way of cover. The monstrosity at the end of the tunnel is bearing down on you with a roar so load that it makes it hard to think. You start to turn around and run back the way you came, but it's no good, the tunneling nightmare is to quick for you...\n\nYou are run over by a train.");
                Console.WriteLine("You have died. Press any key to start again\n\n");
                Console.ReadKey();
                Game.TitleScreen();
            }
            else
            {
                Narrative("You climb down on to the tracks and head south.");
                ChapterTwo();
            }
        }
        */
        public static void ChapterTwo()
        {
            Narrative("After walking for a couple of minutes, you arrive at a small, dimly lit opening where the tunnel widens just a little as a small recluse opens up along the left hand wall.\n\nYou walk over to have a closer look.");
        }

        public static void ChapterThree()
        {

        }

        public static void CombatCalculation()
        {
            Random dice3 = new();
            Random dice6 = new();

            //int monsterHealth = 10;
            //int playerHealth = 100;

            string input2 = "";
            int monsterAttack = 2;
            int monsterAttackBonus = dice3.Next(2, 4);
            int playerAttack = 3;
            int playerAttackBonus = dice6.Next(2);
            int playerDefence = 6;

            Console.WriteLine("Press any key to continue\n");

            Console.ReadKey();
            while (monsterHealth > 0 && playerHealth > 0)
            {
                CombatStart:
                Console.WriteLine($"{MonsterName} stands opposite you. Would you like to ATTACK with weapon, BLOCK, or use ITEM?");
                input2 = Console.ReadLine();
                input2 = input2.Trim();
                input2 = input2.ToLower();
                if (input2 == "attack")
                {
                    int monsterSuccess = (dice3.Next(3) * monsterAttack) + monsterAttackBonus;
                    int playerAttackSuccess = (dice6.Next(4) * playerAttack) + playerAttackBonus;

                    if (monsterSuccess > playerAttackSuccess)
                    {
                        CombatText($"You were hit for {monsterSuccess} damage");
                        playerHealth -= monsterSuccess;
                        Console.WriteLine($"You have {playerHealth} health remaining.");
                        Console.WriteLine($"{MonsterName} has {monsterHealth} health remaining\n");
                    }
                    else if (playerAttackSuccess > monsterSuccess)
                    {
                        CombatText($"You strike {MonsterName} for {playerAttackSuccess} hit points, causing it to yelp in pain");
                        monsterHealth -= playerAttackSuccess;
                        Console.WriteLine($"{MonsterName} has {monsterHealth} health remaing");
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
                        CombatText("You both miss striking each other\n");
                    }
                    goto CombatStart;
                }

                if (input2 == "block")
                {
                    int monsterSuccess = (dice3.Next(2) * monsterAttack) + monsterAttackBonus;
                    int playerDefenceSuccess = (dice6.Next(4) * playerDefence);
                    
                    if (monsterSuccess > playerDefenceSuccess)
                    {
                        CombatText($"A sly attack fron {MonsterName} slips through your defences and you were hit for {monsterSuccess} damage");
                        playerHealth -= monsterSuccess;
                        Console.WriteLine($"You have {playerHealth} health remaining.");
                        Console.WriteLine($"{MonsterName} has {monsterHealth} health remaining\n");
                    }
                    else if (playerDefenceSuccess > monsterSuccess)
                    {
                        CombatText($"{MonsterName} swipes at you for {monsterSuccess} hit points, but you artfully dodge the attack");
                        Console.WriteLine($"{MonsterName} has {monsterHealth} health remaing");
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

                }

                goto CombatStart;
            }
            if (monsterHealth <= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine("You have died. Press any key to start again\n\n");
                Console.ReadKey();
                Game.TitleScreen();
            }

            if (playerHealth > 0)
            {
                return;
            }
        }
    }
    /*
    class Choices()
    {
        string input = "";
        Console.WriteLine("Which direction of the tracks will you follow? North or South?")
    }
    */
    class Player
    {
        public int playerHealth = 100;
        public int playerDefence = 100;
    }
    class Item
    {

    }
    class Enemies
    {
        /*
        public static void Enemy1()
        {
            Random dice3 = new();
            int monsterHealth = 50;
            int monsterAttack = 2;
            int monsterAttackBonus = dice3.Next(2, 4);
        }*/
    }
    class Combat
    {
        /*
        static void CombatText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void Narrative(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void CombatCalculation()
        {
            //Random dice3 = new();
            Random dice6 = new();

            //int monsterHealth = 5;
            int playerHealth = 100;

            //int monsterAttack = 2;
            //int monsterAttackBonus = dice3.Next(2, 4);
            int playerAttack = 3;
            int playerAttackBonus = dice6.Next(2);

            Console.WriteLine("Press any key to continue\n");

            Console.ReadKey();
            while (monsterHealth > 0 && playerHealth > 0)
            {
                int monsterSuccess = (dice3.Next(3) * monsterAttack) + monsterAttackBonus;
                int playerAttackSuccess = (dice6.Next(4) * playerAttack) + playerAttackBonus;

                if (monsterSuccess > playerAttackSuccess)
                {
                    CombatText($"You were hit for {monsterSuccess} damage");
                    playerHealth -= monsterSuccess;
                    Console.WriteLine($"You have {playerHealth} health remaining.");
                    Console.WriteLine($"The monster has {monsterHealth} health remaining\n");
                }
                else if (playerAttackSuccess > monsterSuccess)
                {
                    CombatText($"You strike the beast for {playerAttackSuccess} hit points, causing it to yelp in pain");
                    monsterHealth -= playerAttackSuccess;
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
                    CombatText("You both miss striking each other\n");
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            if (monsterHealth <= 0)
            {
                
                //Narrative("You were victorious in battle against the foul, unstoppable beast.\n\nUpon closer inspection of the unspeakable horror, you realise it wasn't a foul beast, but a mere man with a now split plastic coffee cup and a soft cap clenched in his hands. You recognise the style of cup from somewhere, but you can't place where.\n\nYou take a moment to assess your surroundings.\n\nThe dungeon is reasonably well lit, but positively filthy. You are stood on an elevated ledge with a set of steel rails set around 6 feet lower rolling off in to the pitch darkness to the North and South. The words Elephant and Castle are emblazoned in giant letters across the wall over the rail tracks. Well there's nowhere else to go and nothing else to do, so you jump down on the the tracks.");
                

            }
            else
            {
                Console.WriteLine("You have died. Press any key to start again\n\n");
                Console.ReadKey();
                //Game.StartGame(); Temporarily commented out as it was producing an error.
            }


            
            if (playerHealth > 0)
            {
                //Console.WriteLine("After a short spell, you see some light up ahead.");
                //Adventure.Game.ChapterTwo();
            }
            */
    }
}