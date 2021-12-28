// Importing in "static" mode the namespace System type and its Console type
using static System.Console;
 using System.Text.RegularExpressions;

namespace WritingFunctions // Declaring a name space.
{   
    class Program // Declaring a Class
    {
        // The method is declared above/before the main method.
        // Declaring the function with decimal type and in static mode
        static string CalculateTax(decimal amount, string? twoLetterRegionCode) =>
                   
            twoLetterRegionCode switch
            {
                String x when 
                Regex.IsMatch(x, "[a..z]+") => "Lowercase",
                String y when
                Regex.IsMatch(y, @"[\d]+") => "Number",
                "CH" => $"You must pay {amount * 0.08M} in sales tax.",
                "BB" => $"You must pay {amount * 0.05M} in sales tax.",
                 _ => "Other case"
                            
            }; // End of Switch expression.  

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
                WriteLine($"{CalculateTax(amount, region)}");
               
            } // End of if.
            else
            {
                WriteLine("You did not enter a valid amount!");
            } // End of Else.

        } // End of RunCalculateTax method/function.
        static void TimesTable(byte number) // Creating a method that handle one paramenter in byte type in static mode and with tha ID name TimesTable.
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
        
        // Writing in static mode and int type the function/method named/ID FibImperati with its parameter with int type
        /// <summary>. 
        /// Pass a 32-bit int and it will return a Fibonanci iperator
        /// </summary>
        /// <param name="term">Will pass thity arguments with iterator statement with for.</param>
        /// <returns>Will return the addition of the 2 last numbers.</returns>
        static int FibImperative(int term)
        {
            int input = term switch
            {
                1 => 0,
                2 => 1,
                _ => FibImperative(term - 1) + FibImperative(term - 2)
            };// End of Switch
        return input;    
        } // End of FibImperatibe function.

        // Writing in static mode without the type the named ID RunFibImperative.
        /// <summary>
        /// Call the FibImperative
        /// </summary>
        /// <param name="args"></param>
        static void RunFibImperative()
        {
            // Writing the iterator statement with for.
            for (int i = 1; i <= 30; i++) // Inicializer expression ; conditional expression ; iterator expression.
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(i));
            }// End of for.
        }// End of RunFibImperative function / method.

        // Writing  in static mode with int type and named ID FibFunctional and its parameter with int type named term.
        /// <summary>
        /// Passing some arguments and it will return the addition of the last 2 terms.
        /// </summary>
        /// <param name="term">Eg 1,2,3,4 ... 30</param>
        /// <returns>0,1,1,2,3...514,229</returns>
        static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2) // Recursive function
        };// End of switch and function.

        // Writing in static mode without type(void) namede ID RunFibFunctional.
        /// <summary>
        /// Call the FibFunctional and CardinalToOrdinal in a literal string.
        /// </summary>
        static void RunFibFunctional()
        {
            // Writing a iterator statement.
            for (int i =  1; i <= 30; i++)
            {
                WriteLine("The {0} term of Fibonacci sequence is {1:N0}",
                    arg0: CardinalToOrdinal(1),
                    arg1: FibFunctional(i)
                );// End of strinf and its arguments.
            }// End of iterator statement with for.
        }// End of function RunFibFunctional.

        static void Main(string[] args)
        {
            // RunTimesTable();
            // RunCalculateTax();
            // RunCardinalToOrdinal();
            // RunFactorial();
            // RunFibImperative();
            // RunFibFunctional();
            

        } // End of Main method.
    } // End of Class Program.
} // End of Namespace <WritingFunctions>.