namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for TeaWithHook.
	/// </summary>
	public class TeaWithHook : CaffeineBeverageWithHook
	{
		public TeaWithHook()
		{}

		protected override string Brew()
		{
			return "Steeping the tea\n";
		}

		protected override string AddCondiments()
		{
			return "Adding lemon\n";
		}

		public override bool CustomerWantsCondiments()
		{
			return true;
		}

	}
}
