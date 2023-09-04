/*
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
//
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
//
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue = "a";
Console.WriteLine(myValue != "a");
//
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
//
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
//
int saleAmount = 999;

//int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
//
Random coin = new Random();
int coinFlip = coin.Next(0, 2);
Console.WriteLine($"{(coinFlip == 0 ? "Heads" : "Tails")}");
*/
string permission = "Admin|Manager";
int level = 53;
if (permission.Contains("Admin"))
{
    Console.WriteLine($"{(level > 55 ? "Welcome, Super Admin user." : "Welcome, Admin user.")}");
}
else
{
    Console.WriteLine($"{(level >= 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
}    