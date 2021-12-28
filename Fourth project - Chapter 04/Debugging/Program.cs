// Importing(using) in static mode the System type and its Console type.
using static System.Console;

// Writing a new namespace with ID named Debugging.
namespace Debugging
{
    // Writing a class with the ID named Program.
    class Program
    {
        // Writing in static mode and with double type de function with ID named "Add" with two parametes double and their respective ID names "a" and "b".
        /// <summary>
        /// The funcion gets two arguments passed in double type and it returns they multiplicated each other. 
        /// </summary>
        /// <param name="a">Eg 3,5 1,36 ...</param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Add(double a, double b) => a + b;
        
        // Writing in static mode and without type(void) the function/method with ID named RunAdd.
        /// <summary>
        /// Call the function ADD.
        /// </summary>
        static void RunAdd()
        {
            double argument1 = 4.5; // Declaring with double type the variable with ID named argument1, and after assigning it with a literal value 4.5.
            double argument2 = 2.5;// Declaring with double type the variable with ID named argument2, and after assigning it with a literal value 2.5.
            double answer = Add(argument1, argument2); // Declaring with double type the variable named anwer and assigning it with a double type value of return of Add function/method.

            // Priting a stand output in terminal with a string interpoled.
            WriteLine($"{argument1} + {argument1} = {answer}");
        } // End of function RunAdd.

        // Writing in static mode and without type, the Main method responsable to inicialize and finish the program.
        static void Main()
        {
            // Calling the RunAdd method/function.
            RunAdd();
        }
    } // End of class Program.
} // End of namespace Debugging.