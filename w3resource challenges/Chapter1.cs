using System;
using Microsoft.CSharp;



namespace w3resource_challenges
{
    internal class Chapter1
    {
        Console.Write($"Choose a case 1 - 10: ");
        int c = Convert.ToInt32(Console.ReadLine());
        
        try
        {
            switch (c)
            {
                case 1:
                    {
                        Console.WriteLine("Hello world!");
                        Console.WriteLine("My name is Seb.");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(1 + 2);
                        break;
                    }
                case 3:
                    {
    Console.WriteLine(10 / 2);
    break;
}
                case 4:
                    {
    Console.WriteLine(-1 + 4 * 6);
    Console.WriteLine((35 + 5) % 7);
    Console.WriteLine(14 + -4 * 6 / 11);
    Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
    break;
}
                case 5:
                    {
    int num1, num2, num3;
    Console.Write("Input the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("input the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Number swapping");
    num3 = num1;
    num1 = num2;
    num2 = num3;
    Console.WriteLine($"First number is {num1}");
    Console.WriteLine($"Second number is {num2}");
    break;
}
                case 6:
                    {
    int int1, int2, int3;
    Console.Write("Input the first number to multiply: ");
    int1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number to multiply: ");
    int2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the third number to multiply: ");
    int3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Expected Output:");
    Console.WriteLine($"{int1} x {int2} x {int3} = " + int1 * int2 * int3);
    break;
}
                case 7:
                    {
    int num1, num2;
    Console.Write("Input the first number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the second number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Expected Output:");
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
    //mod means remainder apparently
    Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    break;
}
                case 8:
                    {
    //Write a C# program that takes a number as input and print its multiplication table.
    int num1;
    Console.WriteLine("Test Data");
    Console.Write("Enter the number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    for (int num2 = 0; num2 <= 10; num2++)
    {
        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
    }
    break;
}
                case 9:
                    Challenge9 challenge9 = new Challenge9();
break;
                case 10:
                    Challenge10 challenge10 = new Challenge10();
break;
    }
}
