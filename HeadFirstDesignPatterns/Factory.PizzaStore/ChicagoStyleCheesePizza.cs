namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for ChicagoStyleCheesePizza.
	/// </summary>
	public class ChicagoStyleCheesePizza : Pizza
	{
		#region Constructor
		public ChicagoStyleCheesePizza()
		{
			Name = "Chicago Style Deep Dish Cheese Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Shredded Mozzarella Cheese");
		}
		#endregion//Constructor

		#region Cut
		public override string Cut()
		{
			//base.Cut ();
			return "Cutting the pizza into square slices \n";
		}
		#endregion//Cut

	}
}
