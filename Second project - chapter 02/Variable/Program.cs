// Storing any type of object
object height = 1.88; // Storing a douible in an object
object name = "Amir"; // Storing a string in an object
Console.WriteLine($"{name} is {height} metres tall."); // String interpoled

int lenght1 = name.Lenght; // It gives a error because the compiler doen't know if the object is a string
int lenght2 = ((string)name).Length; // It tell the compiler that the object is a string (explicit cast)
Console.WriteLine($"{name} has {length2} charecter"); // It is a interpoled string and lenght2 was assigned with a reference value instead a literal value.

// Storing a string in dynamic object keyword.
dynamic anotherName = "Ahmed";

// This compiles, but would throw an exception at run-time and if you laater store a data type which does not have a propertu named lenght

int lenght = anotherName.Lenght;