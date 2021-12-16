// Storing any type of object
object height = 1.88; // Storing a douible in an object
object name = "Amir"; // Storing a string in an object
Console.WriteLine($"{name} is {height} metres tall."); // String interpoled

// int lenght1 = name.Lenght; // It gives a error because the compiler doen't know if the object is a string
int length2 = ((string)name).Length; // It tell the compiler that the object is a string (explicit cast)
Console.WriteLine($"{name} has {length2} characters."); // It is a interpoled string and lenght2 was assigned with a reference value instead a literal value.

// Storing a string in dynamic object keyword.
dynamic anotherName = "Ahmed";

// This compiles, but would throw an exception at run-time and if you later store a data type which does not have a property named lenght
int length = anotherName.Length;

// Specifying and inferring the type of a local variable - (camelCasing)
// Declaring and assign values to some local variables using specific types
/*int population = 66_000_000; // 6 milion in UK
double weight = 1.88; // In Kilogram
decimal price = 4.99M; // In pounds sterling
string fruit = "apples"; // String use double-quotes
char letter = 'Z'; // Chars use single-quotes
bool happy = true; // Booleans have value of true or false*/

// Specifying and inferring the type of a local variable - (camelCasing)
// Declaring and assign values to some local variables without specific types, so using var keyword
/**var population = 66_000_000; // 66 million in UK  
var weight = 1.88; // in kilograms 
var price = 4.99M; // in pounds sterling 
var fruit = "Apples"; // strings use double-quotes  
var letter = 'Z'; // chars use single-quotes 
var happy = true; // Booleans have value of true or false*/

// Geeting the default values of the local variable
Console.WriteLine($"default(int) = {default(int)}.");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine(   $"default(DateTime) = {default(DateTime)}");
Console.WriteLine(   $"default(string) = {default(string)}");
//test 2