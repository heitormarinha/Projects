// Importing the type "Console" in the namespace named system.
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Printing the length or args
            WriteLine($"there are {args.Length} arguments.");
            // Printing the args
            foreach (string arg in args) // args in the arg length
            {
                WriteLine(arg);
            }
        }
    }
}
