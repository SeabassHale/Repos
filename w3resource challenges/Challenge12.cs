namespace w3resource_challenges
{
    internal class Challenge12
    {
        internal Challenge12()
        {
            //Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            Console.Write("Enter a digit: ");
            int dispDigit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", dispDigit);
            Console.WriteLine("{0}{0}{0}{0}", dispDigit);
            Console.WriteLine("{0} {0} {0} {0}", dispDigit);
            Console.WriteLine("{0}{0}{0}{0}", dispDigit);

        }

    }
}
