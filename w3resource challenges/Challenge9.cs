namespace w3resource_challenges
{
    public class Challenge9
    {
        public Challenge9()
        {
            int num1, num2, num3, num4;
            Console.Write("Enter the First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Fourth number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average of {0}, {1}, {2} and {3} is {4}", num1, num2, num3, num4, (num1 + num2 + num3 + num4) / 4);
        }
    }


}
