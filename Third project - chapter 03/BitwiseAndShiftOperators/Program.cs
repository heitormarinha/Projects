// Importing in static mode using the namespace "using" the namespace "System" and its "Console" type.
using static System.Console;

int a = 10; // Variable "a" will be assigned with the literal valule 10 (0000 1010 in binary).

int b = 6; // // Variable "b" will be assigned with the literal valule 10 (0000 0110 in binary).

WriteLine($"a = {a}"); 
WriteLine($"b = {b}");

// These operations happens in binary 
WriteLine($"a & b = {a & b}"); // 2-bit column only.
WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns.
WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns.



