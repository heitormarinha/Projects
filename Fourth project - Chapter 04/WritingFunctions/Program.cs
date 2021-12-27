// Importing in "static" mode the namespace System type and its Console type
using static System.Console;
 using System.Text.RegularExpressions;

namespace WritingFunctions // Declaring a name space.
{   
    class Program // Declaring a Class
    {
        // The method is declared above/before the main method.
        // Declaring the function with decimal type and in static mode
        static void CalculateTax(decimal amount, string? twoLetterRegionCode)
        {
           
            // Declaring with decimal type one variable with ID name rate and assigning the literal value 0.0M to set by default.
            string? msg = twoLetterRegionCode switch
            {
                var x when 
                Regex.IsMatch(x, "[a..z]+") => "Lowercase",
                var y when
                Regex.IsMatch(y, @"[\d]+") => "Number",
                "CH" => $"You must pay {amount * 0.08M} in sales tax.",
                "BB" => $"You must pay {amount * 0.05M} in sales tax.",
                 _ => "Other case"
                            
            }; // End of Switch expression. 
        WriteLine(msg); 
        } //End of The CalculateTax method.

        // Declaring the RunCalculateTax function/mathod in static mode and without type with the ID name RUn CalculateTax.
        static void RunCalculateTax()
        {
            Write("Enter an amount:"); // Output with lieral string.
            string? amountInText = ReadLine(); // Take the value  in input standard (tpped).
            // The string need be nullabled.

            Write("Enter a two-letter region code:");
            string? region = ReadLine();

            // Creating the select statement.

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                CalculateTax(amount, region);
               
            } // End of if.
            else
            {
                WriteLine("You did not enter a valid amount!");
            } // End of Else.

        } // End of RunCalculateTax method/function.
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
            // RunTimesTable();
            RunCalculateTax();
        } // End of Main method.
    } // End of Class Program.
} // End of Namespace <WritingFunctions>.