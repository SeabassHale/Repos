using System;

namespace Office_Life
{
    internal class Program
    {
        public static string playerInput;
        public static int shaneJepperd = 0;
        public static int bimTalli = 0;
        public static int coffeeDrank = 0;
        public static int hintCounter = -1;

        static void Description()
        {
            //Background
        }

        static void Main()
        {
            Console.WriteLine("Office Life\n\nPress any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
            StartDesk();
        }
        
        static void StartDesk()
        {
            hintCounter++;
            if (hintCounter >= 5)
                Console.WriteLine("HINT: Try leaving your desk");

            Console.WriteLine("You are sat at your desk in the office\n");
            Console.WriteLine("What would you like to do?\n");
            playerInput= Console.ReadLine();
            playerInput = playerInput.ToLower().Trim();
            if (playerInput == "work")
            {
                Console.WriteLine("You spend several minutes checking your emails. You quickly get bored so decide to surf the net instead before remembering that the service is heavily monitored and restricted. You'd be better off doing that elsewhere.\n");
                StartDesk();
            }
            else if (playerInput == "sit" || playerInput == "sit at desk" || playerInput == "sit down" || playerInput == "sit in chair")
            {
                Console.WriteLine("You are already sat down. Perhaps you wanted to stand up?");
                StartDesk();
            }
            else if (playerInput == "poo")
            {
                Console.WriteLine("You can't do that sat at your desk\n");
                StartDesk();
            }
            else if (playerInput == "stand" || playerInput == "stand up" || playerInput == "stop using computer" || playerInput == "stop sitting" || playerInput == "quit computing")
            {
                Console.WriteLine("You stand up and step away from your computer.\n");
                MiddleOffice();
            }
            //else if (playerInput == "inventory")
            else
            {
                Console.WriteLine("I didn't recognise that command\n");
                StartDesk();
            }
        }

        static void MiddleOffice()
        {
            {
                Console.WriteLine("You are stood in the middle of the office in front of your desk");
                {
                    if (shaneJepperd == 1)
                        Console.WriteLine("Shane Jepperd is sat at his desk which is a few seats up from yours. He's very busy and is constantly bouncing between his phone and his computer.\n");
                    else
                        Console.WriteLine("You are currently alone in the office. You could probably get away with doing anything you wanted to right now... Picking your nose, dropping a deuce on a colleagues desk... You're 95% pertain certain that the cameras aren't looking at you...");
                }
                Console.WriteLine("To the north is the north of the office where Bim Talli's and Cleo Wasp's desks are located.\nTo the east of you is the office reception through the main office entrance. The entrance door is locked magnetically and requires a keycard to open.\nTo the south is the south of the office, which is desolate and empty; a lifeless, joyless place, The only thing going for the south end of the office is that it leads to the kitchen.");

                if (coffeeDrank == 0)
                    Console.WriteLine("You're feeling thirsty. A coffee would go down really well right about now");
            }
            Console.WriteLine("What would you like to do?\n");
            playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower().Trim();

            if (playerInput == "walk" || playerInput == "move")
            {
                Console.WriteLine("I don't recognise those instructions without a direction");
                MiddleOffice();
            }
            else if (playerInput == "walk north" || playerInput == "head north" || playerInput == "north")
            {
                Console.WriteLine("You shamble to the north of the office");
                NorthOffice();
            }
            else if (playerInput == "walk east" || playerInput == "head east" || playerInput == "east")
            {
                Console.WriteLine("You shamble towards the door");
                EastOffice();
            }
            else if (playerInput == "walk south" || playerInput == "head south" || playerInput == "south")
            {
                Console.WriteLine("You stumble down to the depressing part of the office");
                SouthOffice();
            }
            else if (playerInput == "look" || playerInput == "look around" || playerInput == "describe location" || playerInput == "describe room" || playerInput == "describe" || playerInput == "description")
            {
                Console.WriteLine("Due to having a glass ceiling and being on the top floor of the building, the office is bright and airy. In fact, it's so bright that it's almost impossible to see the fading display on any of the grossly outdated monitors that fill every inch of available desk surface, and there's such a breeze coming through that you have to keep your jacket on even in the summer.");
            }
            else if (playerInput == "sit in chair" || playerInput == "sit in seat")
            {
                Console.WriteLine("Wanting to get in some cardio? You sit back down in your chair");
                StartDesk();
            }
            else if (playerInput == "sit" || playerInput == "sit down" || playerInput == "sit back down")
            {
                Console.WriteLine("Where would you like to sit?");
                playerInput = Console.ReadLine();
                playerInput = playerInput.ToLower().Trim();
                if (playerInput == "chair" || playerInput == "your chair" || playerInput == "in chair" || playerInput == "in your chair" || playerInput == "seat" || playerInput == "your seat" || playerInput == "in seat" || playerInput == "in your seat")
                {
                    Console.WriteLine("You sit down in your chair");
                    StartDesk();
                }
                else if (playerInput == "desk" || playerInput == "your desk" || playerInput == "at your desk")
                {
                    Console.WriteLine("You consider sitting on your desk for a change of view, but decide it probably wouldn't be a good idea.");
                    MiddleOffice();
                }
                else
                {
                    Console.WriteLine("I don't think you can sit there");
                    MiddleOffice();
                }
            }
            else if (playerInput == "pick nose")
            {
                if (shaneJepperd == 0)
                {
                    Console.WriteLine("You quite overtly dig for buried treasure in your nasal cavity. After a couple of minutes you strike gold and drag a chunky clump of green goop out of your nostril just as Shane Jepperd walks in to the office through the main door, locking eyes with you right in the middle of the act. Shane is too polite to say anything but you know he's disappointed and disgusted in equal measure.\n");
                    shaneJepperd = 1;
                    MiddleOffice();
                }
                else
                {
                    //Array will be input here for some random nose-picking and nose words, for funnies.
                    //Random rand = new Random();
                    //rand.Next(3);
                    Console.WriteLine("You shamelessly rummage around in your nose-holes but find nothing. You must have got all the good stuff already.\n");
                    MiddleOffice();
                }
            }
            else if (playerInput == "drop deuce" || playerInput == "drop a deuce" || playerInput == "drop deuce on colleagues desk" || playerInput == "drop deuce on colleague desk" || playerInput == "drop deuce on desk" || playerInput == "deuce on desk" || playerInput == "poo on desk" || playerInput == "poo on colleague desk" || playerInput == "poop on colleague desk" || playerInput == "poo on colleagues desk" || playerInput == "poo on a colleagues desk")
            {
                Console.WriteLine("While you could potentially get away with doing so, you're  not sure you have the guts to follow through with it");
                MiddleOffice();
            }
            else
            {
                Console.WriteLine("I didn't recognise that command\n");
                MiddleOffice();
            }
        }

        static void NorthOffice()
        {
            Console.WriteLine("You are stood in the north of the office. \nBim Talli is sat at his desk where he is furiously typing away on his keyboard as if it were a typewriter, but only using his index fingers. Bim has been working here a few years longer than you have, is hard working and dilligent, and you take great pleasure in winding him up at every opportunity you get... In fact, you think he looks stressed and could do with cheering up as soon as possible.\nTo the south is the middle of the office where your desk is located.\n");
            
            Console.WriteLine("What would you like to do?\n");
            playerInput = Console.ReadLine();
            playerInput = playerInput.ToLower().Trim();

            if (playerInput == "walk" || playerInput == "move" || playerInput == "head")
                Console.WriteLine("I don't recognise those instructions without a direction");

            else if (playerInput == "walk south" || playerInput == "head south" || playerInput == "south" || playerInput == "move south")
            {
                Console.WriteLine("You limp down to the strawberry flavour of the office");
                MiddleOffice();
            }
        }

        static void EastOffice()
        {

        }

        static void SouthOffice()
        {

        }
    }
}
