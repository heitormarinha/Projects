// Importing the username System and its type Console.
using static System.Console;


// Writing the title of table
WriteLine("Marks-MacBook-Program-13:Exercise02 markjprices$ dotnet run");

 // Writing one tec line.
WriteLine("---------------------------------------------------------------------------------------------");


//Printing the header of table.
Write(
    format: "{0,-8}",
    arg0: "Type");

Write(
    format: "{0,-4}",
    arg0: "Byte(s) of memory");

Write(
    format: "{0,34}",
    arg0: "MIN");

 WriteLine(
    format: "{0,33}",
    arg0: "MAX");

 // Writing one tec line
WriteLine("---------------------------------------------------------------------------------------------");

// Writing the content of table.

// First Line of its content
Write(
    format: "{0,-8}",
    arg0: "sbyte");

Write(
    format: "{0,-4}",
    arg0: sizeof(sbyte));

Write(
    format: "{0,47}",
    arg0: sbyte.MinValue);

 WriteLine(
    format: "{0,33}",
    arg0: sbyte.MaxValue);

// Second Line of its content
Write(
    format: "{0,-8}",
    arg0: "byte");

Write(
    format: "{0,-4}",
    arg0: sizeof(byte));

Write(
    format: "{0,47}",
    arg0: byte.MinValue);

 WriteLine(
    format: "{0,33}",
    arg0: byte.MaxValue);

// Third Line of its content
Write(
    format: "{0,-8}",
    arg0: "short");

Write(
    format: "{0,-4}",
    arg0: sizeof(short));

Write(
    format: "{0,47}",
    arg0: short.MinValue);

 WriteLine(
    format: "{0,33}",
    arg0: short.MaxValue);

// End of table
WriteLine("---------------------------------------------------------------------------------------------");    