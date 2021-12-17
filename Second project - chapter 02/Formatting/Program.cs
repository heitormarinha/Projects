// Importing the System namespace  plus the Console type.
using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// Using format method of string
// EG1:
WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// EG2:
WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount =56789;

WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: "Name",
    arg1: "Count");

WriteLine(   
    format: "{0,-8} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(   
    format: "{0,-8} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

Write("Type your first name and press ENTER: ");
// Getting the text inpit form user using the "ReadLine method" of system.console
string? firstName = ReadLine();

Write("Type your age and press ENTER: ");
string? age = ReadLine();

// WriteLine(   $"Hello {firstName}, you look good for {age}.");

WriteLine(
    format:"Hello {0}, you look good for {1}!",
    arg0: firstName,
    arg1: age);

// Getting key input from user
Write("Press any key comination:");
ConsoleKeyInfo key = ReadKey();
// Printing the information gotten
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);

