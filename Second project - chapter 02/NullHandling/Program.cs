// int  thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!

int? thisCouldtBeNull = null; // The suffix "?"  symbol indicate the nullable value type
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());

thisCouldtBeNull = 7;
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());

class Address
{
    public string? Building; // Nullable field because of the "?" suffix in the string type
    
// C# extension warns of problems with non-nullable field
    // public string Street; // Non-Nullable field
    // public string City; // Non-Nullable field
    // public string Region; // Non-Nullable field 

  // Assign the empty string value to each of the three fields that are non-nullable
    public string Street = string.Empty;
    public string City = string.Empty;
    public string Region = string.Empty;
}

// Adding statements to instantiate an Address and set its properties
var address = new Address();
address.Building = null;
address.Street = null;
address.City = "London";
address.Region = null;