using System;

namespace Add_Logic_to_code_using_do_while_and_while
{
    internal class Program
    {
        static void Main()
        {
            /*
            do
            {
                //This code executes at least one time
            } while (true)
            

            Random random = new Random();
            //int current = 0;
            int current = random.Next(1, 11);

            
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1,11);
            }
            Console.WriteLine($"Last number: {current}");
            */

            //Random random = new Random();
            //int current = random.Next(1, 11);

            //do
            //{
            //    current = random.Next(1, 11);

            //                if (current >= 8) continue;

            //Console.WriteLine(current);
            //} while (current != 7);

            int heroHealth = 10;
            int monstHealth = 10;
            int attack = 0;

            do
            {
                Random random = new Random();

                attack = random.Next(1, 11);
                monstHealth -= attack;
                Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monstHealth} health.");

                if (monstHealth <= 0)
                {
                    Console.WriteLine("Hero wins!");
                    break;
                }
                
                attack = random.Next(1, 11);
                heroHealth -= attack;
                Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth} health.");

                if (heroHealth <= 0)
                {
                    Console.WriteLine("Monster wins!");
                    break;
                }

            } while (monstHealth >= 1 && heroHealth >= 1);

        }
    }
}
