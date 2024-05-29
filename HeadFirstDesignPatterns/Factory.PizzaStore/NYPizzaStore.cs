namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for NYPizzaStore.
	/// </summary>
	public class NYPizzaStore : PizzaStore
	{
		#region Constructor
		public NYPizzaStore()
		{}
		#endregion//Constructor

		#region CreatePizza
		protected override Pizza CreatePizza(string type)
		{
			return type.Equals("cheese") ? new NYStyleCheesePizza() : null;
		}
		#endregion//CreatePizza
	}
}
