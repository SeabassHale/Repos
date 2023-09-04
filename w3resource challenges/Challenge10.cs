namespace w3resource_challenges
{
    public class Challenge10
    {
        public Challenge10()
        {
            //Write a C# program that takes three numbers (x,y,z) as input and print the output of (x+y)z and xy+yz.
            int num1, num2, num3;
            Console.Write("Enter x: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter z: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {num1}, {num2} and {num3} for (x+y)z is {(num1 + num2) * num3} and xy+yz is {(num1 * num2) + (num2 * num3)}");
        }
    }


}
