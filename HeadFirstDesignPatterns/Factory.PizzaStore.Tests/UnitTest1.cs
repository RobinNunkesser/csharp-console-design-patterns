using NUnit.Framework;

namespace Factory.PizzaStore.Tests
{
    public class Tests
    {
        #region TestNYStyleCheesePizza
        [Test]
        public void TestNYStyleCheesePizza()
        {
            PizzaStore nyStore =
                new NYPizzaStore();
            var pizza = nyStore.OrderPizza("cheese");
            const string pizzaPrepareReturn = "Preparing NY Style Sauce and Cheese Pizza\n" +
                                              "Tossing Thin Crust Dough\n" +
                                              "Adding Martinara Sauce\n" +
                                              "Adding toppings:\n" +
                                              "\tGreated Reggiano Cheese\n";

            Assert.AreEqual(pizzaPrepareReturn, pizza.Prepare());
            Assert.AreEqual("Bake for 25 minutes at 350 \n", pizza.Bake());
            Assert.AreEqual("Cutting the pizza into diagonal slices \n", pizza.Cut());
            Assert.AreEqual("Place pizza in official PizzaStore box \n", pizza.Box());
            Assert.AreEqual("NY Style Sauce and Cheese Pizza", pizza.GetName());
        }
        #endregion//TestNYStyleCheesePizza

        #region TestChicagoStyleCheesePizza
        [Test]
        public void TestChicagoStyleCheesePizza()
        {
            PizzaStore chicagoStore =
                new ChicagoPizzaStore();
            var pizza = chicagoStore.OrderPizza("cheese");

            const string pizzaPrepareReturn = "Preparing Chicago Style Deep Dish Cheese Pizza\n" +
                                              "Tossing Extra Thick Crust Dough\n" +
                                              "Adding Plum Tomato Sauce\n" +
                                              "Adding toppings:\n" +
                                              "\tShredded Mozzarella Cheese\n";

            Assert.AreEqual(pizzaPrepareReturn, pizza.Prepare());
            Assert.AreEqual("Bake for 25 minutes at 350 \n", pizza.Bake());
            Assert.AreEqual("Cutting the pizza into square slices \n", pizza.Cut());
            Assert.AreEqual("Place pizza in official PizzaStore box \n", pizza.Box());
            Assert.AreEqual("Chicago Style Deep Dish Cheese Pizza", pizza.GetName());
        }
        #endregion//TestChicagoStyleCheesePizza
    }
}