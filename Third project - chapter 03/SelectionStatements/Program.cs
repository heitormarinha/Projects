// Importing in "static" mode the namespace System and its Console type
using static System.Console;
using System.IO;
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
            // Branching with the switch statement
            A_label:
                var number = (new Random()).Next(1,7); //  Declaring the variable eith de ID "number" in inferring type mode with random value by the assigning the return value of the Next method invocated by "()"  in  the target-typed mode of the Random type.
            
                WriteLine($"MY random number is {number}."); // Interpoled string.
            
            switch (number)
            {
                case 1:
                    WriteLine("One.");
                    break; // jumps to end of switch statement.
                case 2:
                    WriteLine("Two.");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four was chose for Random's Next method");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                WriteLine("Default.");
                break;
            } // End of switch.

        // Pattern matching with the switch statement 
        //String path = <path>.
        
        string path = @"E:\Documents\CSProjects\Third project - chapter 03"; // Assigning the varbatin string;

        Write("Press R for readonly or W for write: ");// Literal string value.
        ConsoleKeyInfo key = ReadKey(); // Getting the character Typed.
        WriteLine(); // Jump one line.

        Stream? s = null; // Declaring the variable s and setting it in "Stream type", and after assigning the null value into its.

        
        if (key.Key == ConsoleKey.R) 
        {   
            s = File.Open(     
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate,
                FileAccess.Read);
        }
        else
        {
            s = File.Open(
                Path.Combine(path, "file.txt"),
                FileMode.OpenOrCreate,
                FileAccess.Write);  
            
        }

        string message = string.Empty;

        switch (s)
        {
            case FileStream writeableFile when s.CanWrite:
                message = "The stream is a file that I can write to.";
                break; //Jump to end fo switch.

            case FileStream readOnlyFile:
                message = "The stream is a read-only file.";
                break;

            case MemoryStream ms:
                message = "The stream is a memory address.";
                break;

            default: // Always evalueted last despite its corrent position
                message = "The stream is some other type.";
                break;
                    
            case null:
                message = "The stream is null;";
                break;
        } // End of switch.

    WriteLine(message);
    } // End of Main method.
    } // End of Class Program.
} // End of Namespace <Arguments>.