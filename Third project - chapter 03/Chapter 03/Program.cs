// Importing the System namespace and the Console type.
using statically System.Console;

// UNARY OPERATORS.

// Declaring the local variables a,b,c,d and other.
// Declaring with specific types. <> different of using type inference.
int a = 3; // the type int has the ID a, and is assigned (=) with literal value 3.
int b = a++; // Operator unary increment (++), and the ++ operator executes after the assignment;  this is known as a postfix operator.


// Method "WriteLine" of the type "Console" of the namespace "System" imported.
WriteLine($"a is {a}, b is {b}");

// To increment before the assignment,  then use the prefix operator like this following.
int c = 3;
int d = ++c; // Increment "c" before assigning it.
WriteLine($"c is {c}, d is {d}");

// BINARY ARITHMETIC OPERATORS.

int e = 11;
int f =3;
// Performing arithmetic operations.
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

// If the first operand is a floating-point number, such as g with the value 11.0, then the divide  operator returns a floating-point value.
// Example:
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}"); // 3, floating points.





