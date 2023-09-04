/*
string[] fraudulentOrderIDS = new string[3];
//Arrays are declared in the same way as any other object using []. object+array([]) name = new object[number of indexes]

fraudulentOrderIDS[0] = "A123";
fraudulentOrderIDS[1] = "B456";
fraudulentOrderIDS[2] = "C789";
Indexes are assigned similarly to object values.

//fraudulentOrderIDS[3] = "D000"; Note the 3 references the 4th item in an array (i.e. 0 = 1) so in this example is requesting an out-of-bounds index
*/
/*
string[] fraudulentOrderIDS = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDS[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDS[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDS[2]}");

fraudulentOrderIDS[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDS[0]}");

Console.WriteLine($"There are {fraudulentOrderIDS.Length} fraudulent orders to process.");
//the .Length property will print the number of indexes/elements an array has.
*/

//Looping through an array using foreach

/*
string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
foreach (int number in numbers)
{
    Console.WriteLine($"{number} x by 2 = " + number*2);
}
*/
/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");
*/
/*
 Use the foreach statement to iterate through each element in an array, executing the associated code block once for each element in the array.
The foreach statement sets the value of the current element in the array to a temporary variable, which you can use in the body of the code block.
Use the ++ increment operator to add 1 to the current value of a variable.
*/

//Challenge

string[] fakeorderIDs = { "B123", "C234", "A345", "C15", "B177", "G2002", "C235", "B179", "C111111"};
foreach ( string orderID in fakeorderIDs )
{
    Console.WriteLine($"Order ID: {orderID}");
    if (orderID.StartsWith("B"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\tOrder {orderID} identified as fraud. Order Rejected");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (orderID.Contains("1"))
        {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\tOrder {orderID} identified as potential fraud. Sent for review");
        Console.ForegroundColor = ConsoleColor.White;
    }
    }

/*
 You found the challenge pretty straightforward. Once passed, you added in the else if statement for potential fraud and made it look a little more interesting with the font colour changes.

Further things to look in to will be how to extract individual items from Arrays (i.e. to new individual variables for further manipulation) and how to feed Arrays with constantly changing data (such as with live orders coming in and being routed through the process dynamically)
*/