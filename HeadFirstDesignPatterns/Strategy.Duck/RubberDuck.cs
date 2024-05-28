namespace Strategy.Duck;

/// <summary>
///     RubberDuck object
/// </summary>
public class RubberDuck : Duck
{
    public RubberDuck()
    {
        QuackBehavior = new Squeak();
        FlyBehavior = new FlyNoWay();
    }

    public override object Display()
    {
        return "I'm a rubber duck";
    }
}