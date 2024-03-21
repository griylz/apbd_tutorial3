using ConsoleApp1.intefaces;

namespace ConsoleApp1.Containers;

public class GasContainer : Container,IHazardNotification
{
    public double Pressure { get; private set; }
    public GasContainer(int height, double containerWeight, int depth, double maxPayload,double pressure) : base(height, containerWeight, depth, maxPayload, "G")
    {
        Pressure = pressure;
    }

    public void NotifyHazardousSituation(string message)
    {
        Console.WriteLine($"Hazard Alert for Gas Container {SerialNumber}: {message}");
    }
    
    public override void Unload()
    {
        CargoMass *= 0.05;
    }
}