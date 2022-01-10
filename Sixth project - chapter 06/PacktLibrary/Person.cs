// I am Importing the System type.
using System;

// I am Importing the System type and its member Collections type with its member Gereric.
using System.Collections.Generic;

// I am importing  in static mode the System type and its member Console type.
using static System.Console;

namespace PacktLibrary;
public class Person
{
    // I am defining a field with public acess modifier, string type and named <Name>.
    public string? Name;
    
    // I am defining a field with public acess modifier DateTime type  named <DateOfBirth>.
    public DateTime DateOfBirth;

    // I am writing a field with a public acess modifier, with Collection type (List) of <person> named Children asssigned with a collection of itself
    public List<Person>? Children = new();

    // I am writing a method with a public acess modifier and void named <WriteToConsole>.
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth}");
    }

}
