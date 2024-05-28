namespace Adapter.Birds;

/// <summary>
///     Summary description for WildTurkey.
/// </summary>
public class WildTurkey : ITurkey
{
    #region Turkey Members

    public string Gobble()
    {
        return "Gobble, gobble";
    }

    public string Fly()
    {
        return "I'm flying a short distance";
    }

    #endregion
}