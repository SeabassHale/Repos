namespace w3resource_challenges
{
    internal class Challenge11
    {
        internal Challenge11()
        {
            //Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20
            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
        }
    }
}
