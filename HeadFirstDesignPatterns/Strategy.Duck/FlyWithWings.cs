namespace Strategy.Duck
{
    /// <summary>
    /// FlyWithWings
    /// </summary>
    public class FlyWithWings : IFlyBehavior
    {
        public FlyWithWings()
        {
        }

        #region IFlyBehavior Members

        public object Fly() => "I'm flying!!";

        #endregion
    }
}