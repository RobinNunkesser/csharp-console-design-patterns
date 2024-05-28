namespace Decorator.Starbuzz;

/// <summary>
///     Summary description for Beverage.
/// </summary>
public abstract class Beverage
{
    public BeverageSize Size { get; set; }

    public virtual string GetDescription()
    {
        return "Unknown Beverage";
    }

    public abstract double Cost();
}