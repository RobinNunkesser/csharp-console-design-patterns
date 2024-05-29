using System.Text;

namespace TemplateMethod.CaffeineBeverage
{
	/// <summary>
	/// Summary description for CaffeineBeverage.
	/// </summary>
	
	public abstract class CaffeineBeverage
	{
		public string PrepareRecipe()
		{
			var sb = new StringBuilder();
			sb.Append(BoilWater());
			sb.Append(Brew());
			sb.Append(PourInCup());
			sb.Append(AddCondiments());

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

	}
}
