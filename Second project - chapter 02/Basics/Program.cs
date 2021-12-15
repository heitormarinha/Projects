// #error version
using System; // a semicolon indicates the end of a statement

namespace Basics
{ // A open brace indicates the start of a block
    class Program
    {
        static void Main(string[] args)
        {
           double heighInMetres = 1.88;
           // See https://aka.ms/new-console-template for more information
            Console.WriteLine($"The variable {nameof(heighInMetres)} has a value {heighInMetres}");
        }
    }
} // A close brace indicates the end of a block
