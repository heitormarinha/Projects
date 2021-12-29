// Importing (using) the library namespaces ID name System.Console and Packt.Shared
// Obs: the System.Console will be imported in static.
using static System.Console;
using Packt.Shared;
//I am writing a namespace with ID name PeopleApp.
namespace PeopleApp
{
    // I am writing a class with ID name Program.
    class Program
    {
        // I am writing in static mode, without type  the Main method.
        static void Main()
        {
            var bob = new Person();
            WriteLine(bob.ToString());
        }
    }
}
