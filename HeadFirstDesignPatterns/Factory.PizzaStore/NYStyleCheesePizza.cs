namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for NYStyleCheesePizza.
	/// </summary>
	public class NYStyleCheesePizza : Pizza
	{
		#region Constructor
		public NYStyleCheesePizza()
		{
			Name = "NY Style Sauce and Cheese Pizza";
			Dough = "Thin Crust Dough";
			Sauce = "Martinara Sauce";

			Toppings.Add("Greated Reggiano Cheese");
		}
		#endregion
	}
}
