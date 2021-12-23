// Importing the System type and its Console type in static mode.
using static System.Console;

namespace CheckingForOverflow
{
    class program
    {
        static void Main()
        {
            
            try 
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"Initial value {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                    x++;
                    WriteLine($"After incrementing: {x}");
                }// Endo of checked.
            } // End of try.
            
                catch(OverflowException) 
                {
                    WriteLine("The code overflowed but I caught the exception.");
                } // End of catch.

            
        } //End of Main method.
    } // End of Program Class.
} // End of namespace HandlingExceotions.