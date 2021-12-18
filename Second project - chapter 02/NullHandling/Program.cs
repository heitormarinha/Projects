#nullable enable
// int  thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!

int? thisCouldtBeNull = null; // The suffix "?"  symbol indicate the nullable value type
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());

thisCouldtBeNull = 7;
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());

// Check that the variable is not null before using it
if (thisCouldtBeNull != null)
{
    // acess a member of thisCoudBeNull
    // int length = (thisCouldtBeNull).Length; // Could throw exception cause the int does not have the Length member

}

// If you are trying to use a member of a variable that might be null, use the null-conditional  operator "?"

string? authorName = null;

// The following throws the ID of type int special name a NullReferenceException
int? x = authorName?.Length; 

// Instead of throwing an exception, null is assigned to y
int? y = authorName?.Length; // the suffix "?" let the null be assingned.

// result will be 3 if authorName?.Length is null 
var result = authorName?.Length ?? 3;  
Console.WriteLine(result);
