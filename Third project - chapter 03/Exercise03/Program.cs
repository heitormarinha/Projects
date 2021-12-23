// Importing the System type and its Console type in static mode.
using static System.Console;
// Importing the Math type of System type in static mode. 
using static System.Math;

namespace Exercise03
{
    class program
    {
        static void Main()
        {
            
            /*// int number = int.MaxValue + 1;
            // WriteLine($"This is what happen when the int is divided by 0 (6 /0){number / 0}.");

            // WriteLine($"This is what happen when the int is divided by 0 (6 /0){number / 0}.");

            try 
            {
                checked
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++) 
                    {   
                        WriteLine(i);           
                    } // End of for.
                } // Endo of checked.
            } // End of try.
            catch(OverflowException) 
            {
                WriteLine("The code overflowed but I caught the exception.");
            } // End of catch.
            */

            /*WriteLine("Exercise03 3.3");
            int max = 100;
            for (int i = 1; i <= max; i++)
            {
                if ((i % 3) == 0)
                {
                    Write("Fizz");
                }
                else if ((i % 5) == 0)
                {
                    Write("Buzz");
                }
                else
                {
                    Write(i);
                }
                if (i < max)
                {
                    Write(',');
                }
                else
                {
                     Write('.');
                }      
            }*/
            
            WriteLine("Enter a number between 0 and 255");
            int fistNumber;
            string? input = ReadLine();
            if (int.TryParse(input, out fistNumber))
            {
                
            }
            else
            {
                WriteLine("The first input could not be parsed");
                return;
            }
            
            WriteLine("Enter a number between 0 and 255");
            int secondNumber;
            input = ReadLine();
            if (int.TryParse(input, out secondNumber))
            {
               
            }
            else
            {
                WriteLine("The second input could not be parsed.");
                return;
            }
          
            int result = (fistNumber / secondNumber);
            WriteLine($"{fistNumber} divided by {secondNumber} is {result}");

        } //End of Main method.
    } // End of Program Class.
} // End of namespace HandlingExceotions.
