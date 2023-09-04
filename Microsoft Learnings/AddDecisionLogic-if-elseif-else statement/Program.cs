/*Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int insultroll = dice.Next(1, 4);


int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}\n");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll3) && (roll2 == roll3))
    {
        Console.WriteLine("Wow, you rolled 3 of a kind! Have an extra six points, for being so flipping lucky!\n");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles? Have a couple of bonus points.\n");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("Congratulations, you've won a car!");
    if (insultroll == 2)
    {
        Console.WriteLine("Try not to crash this one.");
    }
    else
    {
        Console.WriteLine("Vroom vroom!");
    }
}
else if (total >= 10)
{
    Console.WriteLine("Congratulations, you've won a laptop!");
    if (insultroll == 2)
    {
        Console.WriteLine("Don't get this one confiscated by the police again!");
    }
    else
    {
        Console.WriteLine("It's state of the art!");
    }
}
else if (total == 7)
{
    Console.WriteLine($"Congratulations, you've won a trip!");
    if (insultroll == 2)
    {
        Console.WriteLine("Now get in the back of the van!");
    }
    else
    {
        Console.WriteLine("Hope it's somewhere nice!");
    }
}
else
{
    Console.WriteLine("Congratulations, you've won a kitten!");
    if (insultroll == 2)
    {
        Console.WriteLine("Don't \"play\" with this one like you did that gerbil.");
    }
    else
    {
        Console.WriteLine("Awww, cute.");
    }
}


// Other simple boolean expressions can be created by using operators to compare two values. Operators include:
//
// ==, the "equals operator" to test for equality
// >, the "greater than operator", to test that the value on the left is greater than the value on the right
// <, the "less than operator" to test that the value on the left is less than the value on the right
// >=, the "greater than or equal to operator"
// <=, the "less than or equal to operator"
// and so on
//
// string Playername = "Hot Dog";
// Console.WriteLine("Your current name is Hot Dog. Please input your name");
// string Playername2 = Console.ReadLine();
// bool result = Playername == Playername2;
// Console.WriteLine(result);
// if (result == true)
// {
//      Console.WriteLine("You momma a smelly pig");
// }
*/

Random random = new Random();
int daysUntilExpiration = random.Next(24);
int discountPercentage = 0;

if ((daysUntilExpiration > 1) && (daysUntilExpiration <= 10))
{
    if ((daysUntilExpiration >= 5) && (daysUntilExpiration <= 10))
    {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else
    {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
        discountPercentage = 10;
    }
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");
}
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}