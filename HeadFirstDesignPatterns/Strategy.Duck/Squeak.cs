namespace Strategy.Duck
{
    /// <summary>
    /// Squeak
    /// </summary>
    public class Squeak : IQuackBehavior
    {
        public string Quacking() => "Squeak";
    }
}