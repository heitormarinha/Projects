// Importing in "static" mode the namespace System and its Console type
using static System.Console;

namespace Arguments 
{   
    class Program 
    {

        // Declaring the main function responsable to iniciate and to finish the program.
        // The round bracket "[]" responsable to incoc the string method and point with index to args typed.
        static void Main(string[] args)
        {
        if (args.Length == 0)
            {
                WriteLine("There are no arguments"); // Literal string value and the method is used pertence the Console type
            }
            else
            {
                WriteLine("There is at lest on argument"); // Literal string value and the method is used pertence the Console type
            }

        // Pattern matching with the if statement
        // Adding as removing the "" to change the behavior.
        object o = "3"; // Declaring a variable with ID "o" and specficing the type with the "object tppe" and assigning it with a literal value "3" in string numbe value.
        
        int j = 4; // Declaring a variable with the ID "j" and speciging its type with integer (int) and assigning its value with literal value "4" in whole number.
        
        if (o is int i) // Pattern matching "is"
        {
            WriteLine($"{i} x {j} = {i * j}");
        }
        else
        {
            WriteLine("o is not an int so it cannot multiply");
        }


        }
    }
}