namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Expresso.
/// </summary>
public class Expresso : Beverage
{
    public override double Cost()
    {
        return GetSize(Size);
    }

    public override string GetDescription()
    {
        return "Expresso";
    }

    private double GetSize(BeverageSize size)
    {
        return size switch
        {
            BeverageSize.Tall => 1.5,
            BeverageSize.Grande => 1.75,
            BeverageSize.Venti => 3,
            _ => 1.50
        };
    }
}