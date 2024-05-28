namespace Adapter.Birds;

/// <summary>
///     Summary description for MallardDuck.
/// </summary>
public class MallardDuck : IDuck
{
    #region Duck Members

    public string Quack()
    {
        return "Quack";
    }

    public string Fly()
    {
        return "I'm flying";
    }

    #endregion
}