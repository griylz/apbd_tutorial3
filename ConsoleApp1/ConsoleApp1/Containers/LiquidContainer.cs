using ConsoleApp1.Exceptions;
using ConsoleApp1.intefaces;

namespace ConsoleApp1.Containers;

public class LiquidContainer : Container,IHazardNotification
{
    public bool IsHazardous { get; private set; }
    

    public LiquidContainer(int height, double containerWeight, int depth, double maxPayload, bool isHazardous) : base(height, containerWeight, depth, maxPayload, "L")
    {
        IsHazardous = isHazardous;
    }
    
    public override void Load(double mass)
    {                                         
        double maxAllowed = IsHazardous ? MaxPayload * 0.5 : MaxPayload * 0.9;
        if (mass > maxAllowed)
        {
            throw new OverFillException($"Attempt to overload a liquid container. Container Serial: {SerialNumber}");
        }
        CargoMass = mass;
    }

    public void NotifyHazardousSituation(string message)
    {
        Console.WriteLine($"Hazard Alert for Liquid Container {SerialNumber}: {message}");
    }
}