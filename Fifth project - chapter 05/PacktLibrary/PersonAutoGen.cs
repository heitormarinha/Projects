namespace Packt.Shared;
public partial class Person   
{   
        public string Origin 
        {   
            get   
            {     
                return $"{Name} was born on {HomePlanet}";
            } 
        }
    
    // two properties defined using C# 6+ lambda expression syntax 
    public string Greeting => $"{Name} says 'Hello!'";

    public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

    public string? FavoriteIceCream { get; set; } // auto-syntax
    
    private string? favoritePrimaryColor;
    public string? FavoritePrimaryColor 
    {
        get => favoritePrimaryColor;    
        
        set => 
           favoritePrimaryColor = (value?.ToLower()) switch
            {
                "red" => value.ToLower(),
                "green" => value.ToLower(),
                "blue" => value.ToLower(),
                _ => throw new System.ArgumentException($"{value} is not a primary color. " + "Choose from : red, green and blue.")
            };
    }

    // Indexers.
    public Person this[int index]
    {
        get => Children[index];
        set => Children[index] = value;
    }

}
