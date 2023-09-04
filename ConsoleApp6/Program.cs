using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the exercises thingy. Please select an exercise");
            Console.Write("Name List / Fibonacci Numbers / Pi Calculator: ");
            var menuSelection = Console.ReadLine();

            if (menuSelection.Trim().ToUpper() == "NAME LIST")
                NameList();

            if (menuSelection.Trim().ToUpper() == "FIBONACCI NUMBERS")
                FibonacciNumber();

            if (menuSelection.Trim().ToUpper() == "PI CALCULATOR")
                PiCalc();
        }

        static void FibonacciNumber()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count <= 19)
            {
                var previousa = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previousa2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previousa + previousa2);

            }

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

        static void NameList()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the names list");

            var names = new List<string>
            { "Seb", "Ana", "Felipe" };

            names.Add("Poo");
            names.Add("Fart");
            names.Remove("Ana");

            while (true)
            {
                Console.WriteLine();
                Console.Write("input instruction (LIST / ADD / DELETE / SEARCH / SORT / EXIT): ");

                var userInput = Console.ReadLine();

                if (userInput.ToUpper() == "LIST")
                {
                    foreach (var name in names)
                        Console.WriteLine(name);
                }

                if (userInput.ToUpper() == "ADD")
                {
                    Console.Write("Please input name to add: ");
                    names.Add(Console.ReadLine());
                }

                if (userInput.ToUpper() == "DELETE")
                {
                    Console.Write("Please input name to delete: ");
                    names.Remove(Console.ReadLine());
                }

                if (userInput.ToUpper() == "SEARCH")
                {
                    Console.Write("Please input name to search for: ");
                    string nameInput = Console.ReadLine();

                    var index = names.IndexOf(nameInput);
                    if (index == -1)
                        Console.WriteLine($"Name {nameInput.ToUpper()} not found");
                    else
                        Console.WriteLine($"Found {nameInput.ToUpper()} at {index}");
                }

                if (userInput.ToUpper() == "SORT")
                {
                    names.Sort();
                    Console.WriteLine("Name list sorted alphabetically.");
                }

                if (userInput.ToUpper() == "EXIT")
                {
                    Console.WriteLine();
                    Main();
                }
            }


        }

        static void PiCalc()
        {

//            double pi = (Math.PI);
//            Console.WriteLine(pi);
            string piString = Math.PI.ToString();
//            var piNumbers = new List<string>[];
            string[] piNumbers = piString.Split();
            foreach (var item in piNumbers)
                Console.WriteLine(item);

        }
    }
}