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
                String x when 
                Regex.IsMatch(x, "[a..z]+") => "Lowercase",
                String y when
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
        
        // Writing a function with ID name XCardinalToOrdinal with string type in static mode.
        /// <summary>
        /// Pass a 32-bit integer and it'll be converted in its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3, and so  on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        static string CardinalToOrdinal(int number )
        {
            // Creating a switch selective statement.
            switch (number)
            {
                // Special cases.
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default: // To other cases.
                int lastDigit = number % 10; // Declareting the ID name lastDigit variable with int type and assigning it with the expression (number % 10).
               
                // Writing a select statement with switch expression.
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number}{suffix}";
            } // End of Switch.
        } // Endo of CardialToOrdinal function/method.
        
        // Writing the ID name RunCardinalTOOrdinal without a type (void) in static mode.
        static void RunCardinalToOrdinal()
        {
            // Writing a iterarion statement.
            //  int variable - initializer expression
            // variable number <= literal value - conditional expression
            // variable++ - iterator expression
            for (int number = 1; number<= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");// Printing a output in interpoled string.
            }
            WriteLine();
        }

        // writing a function named Factorial with int type in static mode, and it will have the argument named number with int type.
        static int Factorial(int number)
        {
           // Throwing overflow exceptins with checked statement.
           // that does not let the compiler implicit deny overflow which is allowed by default.
           checked
           {
                int input = number switch
                {
                    <1 => 0,
                    1 => 1,
                    _ => number * Factorial(number -1)
                };// End of Switch expressive.
            return input; 
           }// End of checked
        } // End of Factorila function/method.
        
        // Writing the function named RunFactorial without type(void) with static mode and without argument.
        static void RunFactorial()
        {
            // Writing the iterator statement with the for keyword and its (inicializer, condicional and iterator expressions)
            for (int i = 1; i< 15 ; i++)
            {
                // Handling exceptions wrapping error-prone in try/catch bolck
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                // Catching specific excepitions (in this case OverFLowException)
                // Throwed by checked block
                catch (OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer.");
                }
            } // End of the for iterator statement.
        }// End of RunFactorial method.

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            // RunFactorial();

        } // End of Main method.
    } // End of Class Program.
} // End of Namespace <WritingFunctions>.