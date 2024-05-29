namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for Tea.
	/// </summary>
	public class Tea : CaffeineBeverage
	{
		public Tea()
		{}

		protected override string Brew()
		{
			return "Steeping the tea\n";
		}

		protected override string AddCondiments()
		{
			return "Adding lemon\n";
		}
	}
}
