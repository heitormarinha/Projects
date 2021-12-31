// Importing (using) the library namespaces ID name System.Console and Packt.Shared
// Obs: the System.Console will be imported in static.
using static System.Console;
using Packt.Shared;
//I am writing a namespace with ID name PeopleApp.
namespace PeopleApp
{
    // I am writing a class with ID name Program.
    class Program
    {
        // I am writing in static mode, without type  the Main method.
        static void Main()
        {
            var bob = new Person(); // I am declaring a local varialble in inference mode (var)named bob and assigning it with a object Person type. 
            
            bob.Name = "Bob Smith"; // I am writing a type named bob, setting its property field member named "Name" and assigning it with Bob Smith Literal value.

            bob.DateOfBirth = new DateTime(1965, 12, 22);// I am writing a type named bob, setting its property field member named "DateOfBirth" and assigning it with a DateTime type tha is passing the atguments "1965, 12, 22".

            bob.Children.Add(new Person {Name = "Alfred"});// I am writing a type named  bob, setting its List<t>(<t> is generic) property method member named "Children" which is setting its "Add" member and is passin a argument of "Person" type contructed ("new") and is setting the Name field type with "Alfred" literal valule.

            bob.Children.Add(new Person {Name = "Zoe"}); // I am writing a type named bob, setting its List of generic (List<T>) property method member named "Children" which is setting its "Add" member and is passing with arguments the constructed (new) Person type which is setting the Name field type with "Zoe" literal value.

            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;// I am writing a type named bob, setting the enum type FavoriteAncientWonder and setting it with WondersOfTheAncientWorld.StatueOfZeusAtOlympia bucketlist.


            

            /*WriteLine
            (
                format:"{0}'s favorite wonder is {1}. Its integer is {2}",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder
            );

            bob.BucketList = (WondersOfTheAncientWorld)18; // I am writing a bob type, setting its BucketList enum  type and setting it with a 18 value in  WondersOfTheAncientWorld type
            
            // That is equivalent with bob.BucketList =    WondersOfTheAncientWorld.HangingGardensOfBabylon   | WondersOfTheAncientWorld.MausoleumAtHalicarnassus; 
            
            WriteLine
            (
                $"{bob.Name}'s bucket list is {bob.BucketList}"
            );*/

            /*var alice = new Person {   Name = "Alice Jones",
            DateOfBirth = new DateTime(1998, 3, 7) };
            WriteLine
            (
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );*/

            // I am setting the public static decimal InterestRate field member of BankAccount type and I am assigning the literal value 0.012M.
            /*BankAccount.InterestRate = 0.021M;

            // In inference mode named "JonesAccount" I am instantiating a BankAccount type.
            var jonesAccount = new BankAccount();
            // I am setting its fields AccountName string  and Balance decimal type.
            jonesAccount.AccountName = "Mrs JOnes";
            jonesAccount.Balance = 2400;

            WriteLine
            (
                format: "{0} earned {1:C} interest.",
                arg0: jonesAccount.AccountName,
                arg1: jonesAccount.Balance * BankAccount.InterestRate
            );*/
            // WriteLine($"{bob.Name} is a {Person.Species}");
            
            // WriteLine($"{bob.Name} was born on {bob.HomePlanet}");

            /*var blankPerson = new Person();
            WriteLine
            (
                format:    "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
                arg0: blankPerson.Name,
                arg1: blankPerson.HomePlanet,
                arg2: blankPerson.Instantiated
            );*/

            
            /*var fruit = bob.GetFruit();
            WriteLine
            (
                $"There are {fruit.Name} {fruit.Number}."
            );*/
            
            /*(string fruitName, int fruitNumber) = bob.GetFruit("Apple", 5);
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}.");
            
            int fruitNumber2 = bob.GetFruit(5);
            WriteLine($"Deconstructed: {fruitNumber2}.");*/


            /*var thing1 = ("Neville", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children.");*/

            /*int a = 10;
            int b = 10;
            int c = 10;
            int d = 20;
            int e = 20;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");

            bob.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");

            // simplified C# 7.0 syntax for the out parameter 
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");*/

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            /*WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);*/

           // sam.FavoriteIceCream = "Chocolate Fudge";
           /* WriteLine
            (
                $"Sam's favorite ice-crem flavor is {sam.FavoriteIceCream}."
            );*/

           // sam.FavoritePrimaryColor = "rEd";
           /* WriteLine
            (
                $"Sam's favorite primary color is {sam.FavoritePrimaryColor}."
            );/*
            
            sam.Children.Add(new Person { Name = "Charlie" });
            sam.Children.Add(new Person { Name = "Ella" });*/

            // Old type of acess.
            /*WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");

            // New type of acess.
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");*/
            
            object[] passengers = 
            {
                new FirstClassPassenger { AirMiles = 1_419 },
                new FirstClassPassenger { AirMiles = 16_562 },            
                new BusinessClassPassenger(),
                new CoachClassPassenger { CarryOnKG = 25.7 },
                new CoachClassPassenger { CarryOnKG = 0 },
            };

            foreach (object  passenger in passengers)
            { 
                decimal flightCost = passenger switch 
                {
                    /*// Old.
                    FirstClassPassenger p when p.AirMiles > 35000 => 1500M, 
                    FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassenger _ => 2000M,
                    BusinessClassPassenger _ => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger _ => 650M,
                    _ => 800M
                    };*/

                    FirstClassPassenger p => p.AirMiles switch 
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                        _ => 2000M,
                    },
                    
                    BusinessClassPassenger => 1000M,
                    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassenger => 650M,
                    _ => 800M

                };

                WriteLine($"Flight costs {flightCost:C} for {passenger}");
            }

        }
    }
}
