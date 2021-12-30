namespace Packt.Shared
{   
    [System.Flags]
    public enum WondersOfTheAncientWorld : byte
    {    
        None = 0b_0000_0000, //i.e == 0,
        GreatPyramidOfGiza = 0b_0000_0001, //i.e == 1,
        HangingGardensOfBabylon = 0b_0000_0010, // i.e == 2,
        StatueOfZeusAtOlympia = 0b_0000_0100,
        TempleOfArtemisAtEphesus = 0b_0000_1000,
        MausoleumAtHalicarnassus = 0b_0001_0000,
        ColossusOfRhodes = 0b_0010_0000,
        LighthouseOfAlexandria = 0b_0100_0000  
     } 
}