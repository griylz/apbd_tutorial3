using ConsoleApp1.Containers;

namespace ConsoleApp1.Ship;

using System;
using System.Collections.Generic;
using System.Linq;

public class ContainerShip
{
    private List<Container> containers = new List<Container>();
    public double MaxSpeed { get; private set; }
    public int MaxContainerCount { get; private set; }
    public double MaxWeight { get; private set; }

    public ContainerShip(double maxSpeed, int maxContainerCount, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainerCount = maxContainerCount;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (containers.Count >= MaxContainerCount)
        {
            throw new Exception("Ship is at full capacity and cannot load more containers.");
        }

        double currentWeight = containers.Sum(c => c.CargoMass + c.ContainerWeight) / 1000; 
        double newWeight = currentWeight + (container.CargoMass + container.ContainerWeight) / 1000; 
        if (newWeight > MaxWeight)
        {
            throw new Exception("Loading this container would exceed the ship's maximum weight capacity.");
        }

        containers.Add(container);
    }

    public bool UnloadContainer(string serialNumber)
    {
        var container = containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            containers.Remove(container);
            return true;
        }

        return false;
    }

    public void ReplaceContainer(string oldSerialNumber, Container newContainer)
    {
        var index = containers.FindIndex(c => c.SerialNumber.Equals(oldSerialNumber, StringComparison.OrdinalIgnoreCase));
        if (index != -1)
        {
            containers[index] = newContainer;
        }
        else
        {
            throw new Exception($"Container with serial number {oldSerialNumber} not found.");
        }
    }

    public void TransferContainer(string serialNumber, ContainerShip targetShip)
    {
        var container = containers.FirstOrDefault(c => c.SerialNumber == serialNumber);
        if (container == null)
        {
            throw new Exception($"Container with serial number {serialNumber} not found.");
        }

        UnloadContainer(serialNumber);
        targetShip.LoadContainer(container);
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"Ship Details: Max Speed = {MaxSpeed} knots, Max Container Count = {MaxContainerCount}, Max Weight = {MaxWeight} tons");
        Console.WriteLine("Currently loaded containers:");
        foreach (var container in containers)
        {
            Console.WriteLine($"- Serial: {container.SerialNumber}, Cargo Mass: {container.CargoMass} kg, Type: {container.GetType().Name}");
        }
    }
}
