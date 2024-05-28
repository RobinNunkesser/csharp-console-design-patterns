namespace Adapter.Birds;

/// <summary>
///     Summary description for TurkeyAdapter.
/// </summary>
public class DuckAdapter(IDuck duck) : ITurkey
{
    #region Turkey Members

    public string Gobble()
    {
        return duck.Quack();
    }

    public string Fly()
    {
        return duck.Fly();
    }

    #endregion
}