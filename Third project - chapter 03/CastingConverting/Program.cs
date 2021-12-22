// Importing in static mode the System type and its member Console type.
using static System.Console;
using static System.Convert;
using static System.Math;

namespace CastingConverting
{
    class Program
    {
        static void Main()
        {
            
            /*// Casting numbers implicitly and explicitly

            int a = 10;
            double b = a; // An int can be saffely cast into a double cause it does not lose information
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // Compiler gives an error for this line.
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");*/

            /*// Converting with the System.Convert type
            
           double g = 8.8;
           int h = ToInt32(g);
           WriteLine($"g is {g} and h is {h}"); //Converting's ToInt32 method  rounds the double value 9.8  up to 10 instead of trimming the part after the decimal point.

           double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
           foreach (double n in doubles) 
           {   
               WriteLine
               (
                   format:"Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                   arg0: n,
                   arg1: Round
                            (
                                value: n,
                                digits: 0,
                                mode: MidpointRounding.AwayFromZero
                            ) // MidpointRounding.AwayFromZero is the primary school  rule
                );// End of WriteLine.
            }// End of foreach.*/

        
            /*// Converting from any type to a string.
            // All types have a method named ToString that they inherit from   the System.Object class.
            int number = 12;
            WriteLine(number.ToString());
        
            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new object();
            WriteLine(me.ToString());*/

            /*// Parsing from strings to numbers or dates and time.
            // The opposite of ToString is Parse. Only a few types have a Parse method, including all the  NUMBERS types and DateTime.

            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("4 July 1980");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}.");

            // Avoiding exceptions using the TryParse method.
            // To avoid errors, you can use the TryParse method instead. TryParse attempts to convert the  input string and returns true if it can convert it and false if it cannot.*/

            Write("How many eggs are there?");
            int count;
            string input = ReadLine();

            if (int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("Input could not be parsed");
            }

            

        }// End of Main method.
    } // End of Program class
} // End of Pragram namespace