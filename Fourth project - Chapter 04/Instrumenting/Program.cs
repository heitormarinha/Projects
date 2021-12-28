// Importing the System type (domain) and its Diagnostics type.
using System.Diagnostics;
// Importing the System type and its IO type.
using System.IO;

//I am importing the Microsoft.Extensions.Configuration namespace.
using Microsoft.Extensions.Configuration;

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

            // I am declaring a variable with ID name builder with ConfigurationBuilder type in inference mode(var).
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            // The builder has the type ConfigurationBuilder and it has the preview setting.

            // I am Declaring the ID named configuration variable with the IConfigurationRoot type.
            IConfigurationRoot configuration = builder.Build();

            // I am declaring the variable in inference mode with TraceSwitch type and with the ID name ts(traceSwitch)
            var traceSwitch = new TraceSwitch
            (
                displayName: "PacktSwitch",
                description: "This switch is set via a JSON config."
            );
            
            configuration.GetSection("PacktSwitch").Bind(traceSwitch);

            Trace.WriteLineIf(traceSwitch.TraceError, "Trace error");
            Trace.WriteLineIf(traceSwitch.TraceWarning, "Trace warning");
            Trace.WriteLineIf(traceSwitch.TraceInfo, "Trace information");
            Trace.WriteLineIf(traceSwitch.TraceVerbose, "Trace verbose");


        } // End of Main method.
    } // End of Class Program.
} // End of name space.