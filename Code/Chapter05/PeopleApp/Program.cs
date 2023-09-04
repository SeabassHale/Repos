using Packt.Shared;
using System;
using static System.Console;

namespace PeopleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var bob = new Person(); // C# 1.0 or later
            Person bob = new();
            // WriteLine(bob.ToString());
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22); // c# 1.0 or later
            bob.FavouriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

            WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth);

            WriteLine(format: "{0}'s favourite wonder is {1}. It's integer is {2}",
                arg0: bob.Name,
                arg1: bob.FavouriteAncientWonder,
                arg2: (int)bob.FavouriteAncientWonder);

            bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;

            // bob.BucketList = (WondersOfTheAncientWorld)96;

            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

            Person alice = new()
            {
                Name = "Alice Jones",
                DateOfBirth = new(1998, 3, 7), // c# 9.0 or later
                FavouriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza
            };

            WriteLine(format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth);
        }
    }
}