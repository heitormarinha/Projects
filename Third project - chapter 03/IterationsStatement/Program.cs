// Improting (using) type Keyword name special System and its member Console type in mode static.
using static System.Console;
 
namespace iterationStatements // lopp
{
    class Program
    {
        static void main()
        {
            int x = 0;

            // Iteration (loop) whith "while".
            while (x < 10)
            {
                WriteLine(x);
                x++; // Unary operator "++" prefixed to increment after finih the while.     
            }

            // Looping with the do statement

            string? password = string.Empty;

            do
            {
                Write("Enter your password:");
                password = ReadLine();
            }
            while (password != "Pa$$w0rd");
            {
                WriteLine("Correct!");
            }
        } // End of main mehtod.
    }// End of Program class.
}// End of IterationStatement Namespace.

