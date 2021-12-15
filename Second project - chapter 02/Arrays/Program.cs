string[] names = new String[4]; // Can reference any array of string and Allocating memory for four strings in an array

// storing items at index positions 
names[0] = "Kate";
names[1] = "Jack";  
names[2] = "Rebecca"; 
names[3] = "Tom";

// Looping through the names 
for (int i = 0; i < names.Length; i++) 
{   // output the item at index position i   
    Console.WriteLine(names[i]);  
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
