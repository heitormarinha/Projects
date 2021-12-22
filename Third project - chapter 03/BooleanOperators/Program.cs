// statically importing the System.Console  type to simplify statements in a console app.
using static System.Console;

// Declaring with a specifc type
bool a = true;
bool b = false;
WriteLine($"AND | a     | b ");
WriteLine($"a   | {a & a,-5} | {a & b,-5} ");
WriteLine($"b   | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR  | a     | b ");
WriteLine($"a   | {a | a,-5} | {a | b,-5} ");
WriteLine($"b   | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR | a     | b ");
WriteLine($"a   | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b   | {b ^ a,-5} | {b ^ b,-5} ");

