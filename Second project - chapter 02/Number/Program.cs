
/*
// Unsigned integer means positive whole number, and this including 0.
uint naturalNumber = 23;

// Integer means negative or positive whole number, and this including 0.
int integerNumber = -23;

// Float means single-precision floating point, and need a F suffix makes it a float literal.
float realNumber = 2.3F;

// Double means double-precision floating pont.
double anotherRealNumber = 2.3;// Double literal
*/

// Three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// Now we are checking if the three variables have the same value.
// Both the following output of the statements are "true".
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine(   $"{decimalNotation == hexadecimalNotation}");

// The sizeof return the value in bytes that the variable need in memory.
// Range of possible numbers in int variable
Console.WriteLine($"The int  variable uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");

// Range of possible numbers in double variable
 Console.WriteLine($"The double variable uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
