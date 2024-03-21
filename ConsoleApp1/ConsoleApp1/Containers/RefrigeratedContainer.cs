namespace ConsoleApp1.Containers;

public class RefrigeratedContainer: Container
{
    public PossibleProducts ProductType { get; private set; }
    public double Temperature { get; private set; }
    
    private static readonly Dictionary<PossibleProducts, double> ProductTemperatureRequirements = new Dictionary<PossibleProducts, double>
    {
        { PossibleProducts.Banana, 13.3 },
        { PossibleProducts.Chocolate, 18 },
        { PossibleProducts.Milk, 4 },
        { PossibleProducts.Fish, 2 },
        { PossibleProducts.Meat, -15 },
        { PossibleProducts.IceCream, -18 },
        { PossibleProducts.FrozenPizza, -30 },
        { PossibleProducts.Cheese, 7.2 },
        { PossibleProducts.Sausages, 5 },
        { PossibleProducts.Butter, 20.5 },
        { PossibleProducts.Eggs, 19 }
    };
    public RefrigeratedContainer(int height, double tareWeight, int depth, double maxPayload, PossibleProducts productType)
        : base(height, tareWeight, depth, maxPayload, "R")
    {
        ProductType = productType;
        if (ProductTemperatureRequirements.ContainsKey(productType))
        {
            Temperature = ProductTemperatureRequirements[productType];
        }
        else
        {
            throw new Exception("Unsupported product type: " + productType);
        }
    }
}