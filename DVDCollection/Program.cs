using System;

namespace DVDCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var collection = new DVDLibrary("SnDLi");
            Console.WriteLine(collection.Name);

            collection.LibraryAddition("Jurassic Park", "PG", 123, DateTime.Today, DateTime.Now);
            collection.LibraryAddition("Jurassic Park 2: More Dinos", "PG", 121, DateTime.Today, DateTime.Now);
            collection.LibraryAddition("Jurassic Park 3: Never Keep a Good Dino Down", "15", 117, DateTime.Today, DateTime.Now);
            collection.LibraryAddition("Fear and Loathing in Las Vegas", "15", 97, DateTime.Today, DateTime.Now);
            collection.LibraryAddition("Finding Dory 2: Something Smells Fishy", "18", 85, DateTime.Today, DateTime.Now);

            Console.WriteLine(collection.GetChangesHistory());


            collection.LibraryAddition("The Simpsons Movie", "12", 109, DateTime.Now, DateTime.Now);

            Console.WriteLine(collection.GetChangesHistory());

            //var jurassicPark = new DVD("Jurassic Park", 0);
            //Console.WriteLine(jurassicPark.Title);

            //var jurassicPark2 = new DVD("Jurassic Park 2: The Search for More Dinosaurs", 0);

            //var jurassicPark3 = new DVD("Jurassic Park 3: Can't Keep a Good Dino Down", 15);

            //Console.WriteLine(jurassicPark3.Title);
        }
    }
}
