using System;

namespace Poem
{
    internal class Program
    {
        static void Main()
        {
            string[] poem = {
                "Treats for me and you.",
                "At the candy store",
                "Let's get a big mix",
                "The candy is so great",
                "Order treats again",
                "Life-size candy elf",
                "Lick our fingers clean",
                "Feeling kinda green",
                "Tummy getting mean",
                "Ate way too many",
                "Vomit on my shoe",
                "Candy nevermore",
            };
            for (int i = 0; i < poem.Length; i++)
            {
                Console.WriteLine($"{i+1} and {i+1} are {2 * (i+1)}");
                Console.WriteLine(poem[i]);
                Console.WriteLine();
            }
            {
            /*
            int[] nums = new int[12];
            for (int num = 1; num < 13; num++)
            {
                Console.WriteLine($"{num} and {num} are {num + num}");
                if (num == 1)
                    Console.WriteLine("Treats for me and you");
                if (num == 2)
                    Console.WriteLine("At the candy store");
                if (num == 3)
                    Console.WriteLine("Let's get a big mix.");
                if (num == 4)
                    Console.WriteLine("The candy is so great.");
                if (num == 5)
                    Console.WriteLine("Order treats again.");
                if (num == 6)
                    Console.WriteLine("Life-size candy elf.");
                if (num == 7)
                    Console.WriteLine("Lick our fingers clean.");
                if (num == 8)
                    Console.WriteLine("Feeling kinda green");
                if (num == 9)
                    Console.WriteLine("Tummy getting mean.");
                if (num == 10)
                    Console.WriteLine("Ate way too many!");
                if (num == 11)
                    Console.WriteLine("Vomit on my shoe");
                if (num == 12)
                    Console.WriteLine("Candy nevermore");
            }
            */
            /*
                if (nums[1])
                    Console.WriteLine("Treats for me and you.");
                if (nums[2])
                    Console.WriteLine("At the candy store.");
            */
        }
        }
    }
}

/*
namespace Count
{
    internal class Program
    {
        static void Maine()
        {
            Console.Title = "Examples of for loops";

            //increment
            Console.WriteLine("Count 0 to 9!");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            //decrement
            Console.WriteLine("Count down 9 to 0!");
            for (int j = 9; j > -1; j--)
                Console.WriteLine(j);
            Lunch.Program2.Lunchie();
        }
    }
}

namespace Lunch
{
    class Program2
    {
        public static void Lunchie()
        {
            string[] lunch = new string[3];
            lunch[0] = "sandwich";
            lunch[1] = "drink";
            lunch[2] = "apple";

            for (int i = 0; i < lunch.Length; i++)
            {
                Console.WriteLine("The value at " + i + " is " + lunch[i]);
            }
            Console.WriteLine($"The value of lunch.length is: {lunch.Length}");
            GroceryList.Program.Groceries();
        }
    }
}

namespace GroceryList
{
    class Program
    {
        public static void Groceries()
        {
            Console.Title = "Write Each Element in Array";
            string[] items = { "banana", "orange", "avocado", "turnip", "lemon", "pecans" };

            foreach (string element in items)
                Console.WriteLine(element);

        }
    }
}
*/