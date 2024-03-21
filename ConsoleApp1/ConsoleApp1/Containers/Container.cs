using ConsoleApp1.intefaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer 
{
    public double CargoMass { get; protected set; }
    public int Height { get; private set; }
    public double ContainerWeight { get; private set; }
    public int Depth { get; private set; }
    public string SerialNumber { get; private set; }
    public double MaxPayload { get; private set; }

    rotected Container(int height, double containerWeight, int depth, double maxPayload, string containerTypePrefix)
    {
        Height = height;
        ContainerWeight = containerWeight;
        Depth = depth;
        MaxPayload = maxPayload;
        SerialNumber = ContainerIdGenerator.GenerateId(containerTypePrefix);
    }

    public virtual void Unload()
    {
        CargoMass = 0;
    };

    public virtual void Load(double mass)
    {
        if (mass<MaxPayload)
        {
            CargoMass = mass;
        }
        else
        {
            throw new OverFillException("Weight of cargo is too high");
        }
    };
}


