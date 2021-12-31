using System.Collections.Generic;
namespace Packt.Shared;

// The public Keyword is
public partial class Person : object
{
    // I am creating a member of this class with public encapsulation, type List of <Type> and the type chose wsa the Class Person. I also assigned it with a constructor of its type.  
    public List<Person> Children = new List<Person>();
    public string? Name;
    public DateTime DateOfBirth;
    
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public const string Species = "Homo Sapien";
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
// constructors
    public Person() 
    {
        // set default values for fields
        // including read-only fields
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }
    public (string Name, int Number) GetFruit(string name, int number) => (Name: name, Number: number);
   public int GetFruit(int number) =>  number;

   public void PassingParameters(int x, ref int y, out int z)
   {
       // out parameters cannot have a default
       // AND must be initialized inside the method
       z = 99;

       //Increment each parameter.
       x++;
       y++;
       z++;
   }
}
