#nullable enable
// int  thisCannotBeNull = 4;
// thisCannotBeNull = null; // compile error!

int? thisCouldtBeNull = null; // The suffix "?"  symbol indicate the nullable value type
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());

thisCouldtBeNull = 7;
Console.WriteLine(thisCouldtBeNull);
Console.WriteLine(thisCouldtBeNull.GetValueOrDefault());
