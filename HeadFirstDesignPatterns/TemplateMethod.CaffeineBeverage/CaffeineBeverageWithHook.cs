using System.Text;

namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for CaffeineBeverageWithHook.
	/// </summary>
	public abstract class CaffeineBeverageWithHook
	{
		public string PrepareRecipe()
		{
			var sb = new StringBuilder();

			sb.Append(BoilWater());
			sb.Append(Brew());
			sb.Append(PourInCup());
			if(CustomerWantsCondiments())
			{
				sb.Append(AddCondiments());
			}

			return sb.ToString();
		}

		protected abstract string Brew();
		protected abstract string AddCondiments();

		private string BoilWater()
		{
			return "Boiling water\n";
		}

		private string PourInCup()
		{
			return "Pouring into cup\n";
		}

		public virtual bool CustomerWantsCondiments()
		{
			return true;
		}
	}
}
