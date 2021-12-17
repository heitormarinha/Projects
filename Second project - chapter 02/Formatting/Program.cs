int numberOfApples = 12;
decimal pricePerApple = 0.35M;

// Using format method of string
// EG1:
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

// EG2:
Console.WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount =56789;

Console.WriteLine(
    format: "{0,-8} {1,6:N0}",
    arg0: "Name",
    arg1: "Count");

Console.WriteLine(   
    format: "{0,-8} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

Console.WriteLine(   
    format: "{0,-8} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

Console.Write("Type your first name and press ENTER: ");
// Getting the text inpit form user using the "ReadLine method" of system.console
string? firstName = Console.ReadLine();

Console.Write("Type your age and press ENTER: ");
string? age = Console.ReadLine();

// Console.WriteLine(   $"Hello {firstName}, you look good for {age}.");

Console.WriteLine(
    format:"Hello {0}, you look good for {1}!",
    arg0: firstName,
    arg1: age);