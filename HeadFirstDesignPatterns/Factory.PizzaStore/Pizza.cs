using System.Collections;
using System.Text;

namespace Factory.PizzaStore
{
	/// <summary>
	/// Summary description for Pizza.
	/// </summary>
	public abstract class Pizza
	{
		#region Members
		protected string Name;
		protected string Dough;
		protected string Sauce;
		protected readonly ArrayList Toppings = [];
		#endregion//Members

		#region Constructor

		protected Pizza()
		{}
		#endregion//Constructor

		#region Prepare
		public string Prepare()
		{
			var sb = new StringBuilder();

			sb.Append("Preparing " + Name + "\n");
			sb.Append("Tossing " + Dough + "\n");
			sb.Append("Adding " + Sauce + "\n");
			sb.Append("Adding toppings:" + "\n");

			foreach(string topping in Toppings)
			{
				sb.Append("\t" + topping + "\n");
			}

			return sb.ToString();
		}
		#endregion//Prepare

		#region Bake
		public virtual string Bake()
		{
			return "Bake for 25 minutes at 350 \n";
		}
		#endregion//Bake

		#region Cut
		public virtual string Cut()
		{
			return "Cutting the pizza into diagonal slices \n";
		}
		#endregion//Cut

		#region Box
		public virtual string Box()
		{
			return "Place pizza in official PizzaStore box \n";
		}
		#endregion//Box

		#region GetName
		public string GetName()
		{
			return Name;
		}
		#endregion//GetName
	}
}
