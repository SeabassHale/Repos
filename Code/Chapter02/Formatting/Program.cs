﻿using static System.Console;

// FORMATTING USING NUMBERED POSITIONAL VALUES

int whileRunner = 0;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted); // writes the string to a file

WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

string firstName = "Dave";
string lastName = "Matthews";
string fullName = $"{firstName} {lastName}";

WriteLine(fullName);

string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

//Write("Type your first name and press ENTER: ");
//string? firstNames = ReadLine();

//Write("Type your last name and press ENTER: ");
//string? age = ReadLine();

//WriteLine($"Hello {firstNames}, you look good for {age}");

while (whileRunner == 0)
    {
    Write("Press any key combination: ");
    ConsoleKeyInfo key = ReadKey();
    WriteLine();
    WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
        arg0: key.Key,
        arg1: key.KeyChar,
        arg2: key.Modifiers);
}