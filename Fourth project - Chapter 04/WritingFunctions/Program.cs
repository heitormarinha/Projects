// Importing in "static" mode the namespace System type and its Console type
using static System.Console;

namespace WritingFunctions // Declaring a name space.
{   
    class Program // Declaring a Class
    {

        // The method is declared above/before the main method.
        
        static void TimesTable(byte number) // Creating a method that handle one argumet in byte type in static mode and with tha ID name TimesTable.
        {

            WriteLine($"This is the {number} times table:");// Interpoled string .

            // Starting a iteration statements (aka loop.)
            // An initializer (which executes once at the start of the loop.), a conditional(Which executes on everu interation at the start of the loop to check wheteher the looping should continue) and a iterator expressions(which executes on everu loop at the botton of the statement).
            for (int row = 1; row <= 12; row++) // Iteration(loop) with for.
            {
                WriteLine(
                    $"{row} x {number} = {row * number}"
                ); // End of "block" WriteLine.
                WriteLine();
            }
                       
        } // End of TimesTable method.

        // Creating other method/funciton.
        static void RunTimesTable() // Making a function in static mode and void (without a type).
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255");
                isNumber = byte.TryParse(ReadLine(), out byte number);
                
                if (isNumber)         
                {           
                    TimesTable(number);
                }         
                else         
                {          
                     WriteLine("You did not enter a valid number!");
                }      
            } // End of block of iteration do.      
            while (isNumber); // End of iterarion with DO.        
        } // End of RunTimesTable function.
        static void Main(string[] args)
        {
            RunTimesTable();
        } // End of Main method.
    } // End of Class Program.
} // End of Namespace <WritingFunctions>.