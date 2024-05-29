namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for Coffee.
	/// </summary>
	public class Coffee : CaffeineBeverage
	{
		public Coffee()
		{}

		protected override string Brew()
		{
			return "Dripping coffee through filter\n";
		}

		protected override string AddCondiments()
		{
			return "Adding sugar and milk\n";
		}
	}
}
