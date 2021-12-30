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
            /* var bob = new Person(); // I am declaring a local varialble in inference mode (var)named bob and assigning it with a object Person type. 
            
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
            BankAccount.InterestRate = 0.021M;

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
            );

        }
    }
}
