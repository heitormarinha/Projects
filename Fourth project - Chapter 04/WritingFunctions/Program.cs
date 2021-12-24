// Importing in "static" mode the namespace System type and its Console type
using static System.Console;

namespace WritingFunctions 
{   
    class Program 
    {

    // The method is declared above/before the main method.
        
        static void TimesTable(byte number) // Creating a method that handle one argumet in byte type in static mode. 
        {

            WriteLine("This is the {numer} times table:");// Literal string .
            for (int row = 1; row <= 12; row++) // Iteration with for.
            {
                WriteLine(
                    $"{row} x {number} = {row * number}"
                ); // End of "block" WriteLine.
                WriteLine();
            }
                       
        } // End of TimesTable method.

        // Creating other method/funciton.
        static void RunTimesTable() // Making a function 
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
            while (isNumber); // End of iterarion DO.        
        }
        static void Main(string[] args)
        {
            RunTimesTable();
        } // End of Main method.
    } // End of Class Program.
} // End of Namespace <WritingFunctions>.