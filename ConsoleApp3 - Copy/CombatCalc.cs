using System;
using Adventure;

namespace CombatCalc
{
    class Calculation
    {
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
        public static void CombatCalculation() 
        {
            Random dice3 = new();
            Random dice6 = new();

            int monsterHealth = 5;
            int playerHealth = 100;

            int monsterAttack = 2;
            int monsterAttackBonus = dice3.Next(2, 4);
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
                Narrative("You were victorious in battle against the foul, unstoppable beast.\n\nUpon closer inspection of the unspeakable horror, you realise it wasn't a foul beast, but a mere man with a now split plastic coffee cup and a soft cap clenched in his hands. You recognise the style of cup from somewhere, but you can't place where.\n\nYou take a moment to assess your surroundings.\n\nThe dungeon is reasonably well lit, but positively filthy. You are stood on an elevated ledge with a set of steel rails set around 6 feet lower rolling off in to the pitch darkness to the North and South. The words Elephant and Castle are emblazoned in giant letters across the wall over the rail tracks. Well there's nowhere else to go and nothing else to do, so you jump down on the the tracks.");
            }
            else
            {
                Console.WriteLine("You have died. Press any key to start again\n\n");
                Console.ReadKey();
                Game.StartGame();
            }



            if (playerHealth > 0)
            {
                //Console.WriteLine("After a short spell, you see some light up ahead.");
                Adventure.Game.ChapterTwo();
            }
        }
}
            }