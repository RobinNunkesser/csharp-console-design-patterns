using System.Text;

namespace Adapter.Birds;

/// <summary>
///     Summary description for TurkeyAdapter.
/// </summary>
public class TurkeyAdapter(ITurkey turkey) : IDuck
{
    #region Duck Members

    public string Quack()
    {
        return turkey.Gobble();
    }

    public string Fly()
    {
        var sb = new StringBuilder();

        for (var i = 0; i < 5; i++)
        {
            sb.Append(turkey.Fly());
            sb.Append('\n');
        }

        return sb.ToString();
    }

    #endregion
}