using ConsoleApp1.intefaces;

namespace ConsoleApp1.Containers;

public abstract class Container : IContainer 
{
    public double CargoMass { get; set; }

    protected Container(double cargoMass)
    {
        CargoMass = cargoMass;
    }

    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoMass)
    {
        throw new NotImplementedException();
    }
}


