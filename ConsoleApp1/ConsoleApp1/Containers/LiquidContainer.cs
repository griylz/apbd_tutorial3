namespace ConsoleApp1.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoMass) : base(cargoMass)
    {
        
    }
    
    public override void Load(double cargoMass)
    {                                         
        throw new NotImplementedException();  
    }                                         
}