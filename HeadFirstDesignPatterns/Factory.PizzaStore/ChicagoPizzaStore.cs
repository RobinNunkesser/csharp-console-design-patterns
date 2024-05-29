namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for ChicagoPizzaStore.
	/// </summary>
	public class ChicagoPizzaStore : PizzaStore
	{
		#region Constructor
		public ChicagoPizzaStore()
		{}
		#endregion//Constructor

		#region CreatePizza
		protected override Pizza CreatePizza(string type)
		{
			return type.Equals("cheese") ? new ChicagoStyleCheesePizza() : null;
		}
		#endregion//CreatePizza
	}
}
