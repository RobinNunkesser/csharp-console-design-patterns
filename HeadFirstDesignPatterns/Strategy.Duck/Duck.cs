namespace Strategy.Duck
{
    /// <summary>
    /// abstract base class of Ducks
    /// </summary>
    public abstract class Duck
    {
        public IQuackBehavior QuackBehavior { get; set; }

        public IFlyBehavior FlyBehavior{ get; set; }

        public abstract object Display();

        public object PerformFly() => FlyBehavior.Fly();

        public object PerformQuack() => QuackBehavior.Quacking();

        public string Swim() => "All ducks float, even decoys!";
    }
}