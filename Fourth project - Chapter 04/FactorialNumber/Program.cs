// I am importing in static mode the System type and its Console.
using static System.Console;

// I am importing the FactorialPackt library.
using FactorialPackt;

// I am writing the namescace ID name FactorialNumber.
namespace FactorialNumber
{
    class Program
    {
        // Writing in static mode and without type the Main function.
        static void Main()
        {
            int number = 4;
            new Factorial().FactorialCalculation(number);
        }
    }
}