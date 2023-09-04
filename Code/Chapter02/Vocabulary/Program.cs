//using System.Reflection;

//// declare some unused variables using types
//// in additional assemblies
//System.Data.DataSet ds;
//HttpClient client;

//string potato = "potatoes";
//Console.WriteLine($"Dingles {nameof(potato)} is a variable that has value {potato}");

//Assembly? assembly = Assembly.GetEntryAssembly();

//if (assembly == null) return;

//// Loop through the assemblies that this app references
//foreach (AssemblyName name in assembly.GetReferencedAssemblies())
//{
//    // Load the assembly so we can read its details
//    Assembly a = Assembly.Load(name);

//    // Declare a variable to count the number of methods
//    int methodCount = 0;

//    // Loop through all the types in the assembly
//    foreach (TypeInfo t in a.DefinedTypes)
//    {
//        // add uo the counts in methods
//        methodCount += t.GetMethods().Count();
//    }

//    // Output the count of types ad their methods
//    Console.WriteLine(
//        "{0:N0} types with {1:N0} methods in {2} assembly.",
//        arg0: a.DefinedTypes.Count(),
//        arg1: methodCount, arg2: name.Name);
//}

//Console.WriteLine("Temperature on {0:D} is {1}C.", DateTime.Today, 23.4);
//Console.WriteLine();

//// Let the heightInMeters variable become equal to the balue 1.88
//double heightInMeters = 1.88;
//Console.WriteLine($"The variable {nameof(heightInMeters)} has the value {heightInMeters}");

char letter = 'A'; // assigning iteral characters
char digit = '1';
char symbol = '$';
char userChoice = 'l'; //GetSomeKeyStroke(); // assigning from a fictitious funtion

Console.WriteLine($"{Convert.ToString(letter)}, {Convert.ToString(digit)}, {Convert.ToString(symbol)}, {Convert.ToString(userChoice)}");

string a = "asses\teats";
string b = @"asses\teats";
string c = "asses" +
    "teats";
string d = @"asses
teats";
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine($"Show me the {d}");
Console.WriteLine(a);