namespace Packt.Shared;
public class BusinessClassPassenger
{
    public override string ToString() => $"Business Class"; 
}
public class FirstClassPassenger
{
    public int AirMiles { get; set;}
    public override string ToString() => $"First Class with {AirMiles:N0} air miles";
} 
public class CoachClassPassenger
{
    public decimal CarryOnKG { get; set; }
    public override string ToString() => $"Coach Class with {CarryOnKG:N2} KG carry on";
}