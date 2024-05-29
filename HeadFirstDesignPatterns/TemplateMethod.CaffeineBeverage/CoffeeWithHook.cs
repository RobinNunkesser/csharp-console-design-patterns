namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for CoffeeWithHook.
	/// </summary>
	public class CoffeeWithHook : CaffeineBeverageWithHook
	{
		public CoffeeWithHook()
		{}

		protected override string Brew()
		{
			return "Dripping coffee through filter\n";
		}

		protected override string AddCondiments()
		{
			return "Adding sugar and milk\n";
		}

		public override bool CustomerWantsCondiments()
		{
			return true;
		}

	}
}
