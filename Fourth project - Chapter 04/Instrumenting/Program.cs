// Importing the System type (domain) and its Diagnostics type.
using System.Diagnostics;
// Importing the System type and its IO type.
using System.IO;

// I am writiting the namespace Instrumenting.
namespace Instrumenting
{
    //I am writing a class with Id name Program
    class Program
    {
        // I am writing in static mode without type (void) the ID name Main method/function and its parameter in string type with ID name args.
        static void Main(string[] args)
        {
            // I am writing to a text file in the project folder/dictory.
            Trace.Listeners.Add(new TextWriterTraceListener(
                File.CreateText("log.txt")));
            
            // Text writer is buffered, so this options calls Flush() on all listener after writing.
            Trace.AutoFlush = true;

            // Printing the output with Debug and Trace type in literal string.            
            Debug.WriteLine("Debug says, I am watching!");
            Trace.WriteLine("Trace says, I am watching");  
        }

    }
}