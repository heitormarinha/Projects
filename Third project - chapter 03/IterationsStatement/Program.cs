// Improting (using) type Keyword name special System and its member Console type in mode static.
using static System.Console;
 
namespace iterationStatements // lopp
{
    class Program
    {
        static void Main()
        {
            /*int x = 0;

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
            }*/

            // Looping with the for statement
            for (int y = 1; y<= 10 ; y++)
            {
                WriteLine(y);
            }
            
            // Looping with the foreach statement
            string[] names = { "Adam", "Barry", "Charlie" }; // Declared one array with "string" type and the ID "names" and assigned with 4 <values>.

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }




        } // End of main mehtod.
    }// End of Program class.
}// End of IterationStatement Namespace.

