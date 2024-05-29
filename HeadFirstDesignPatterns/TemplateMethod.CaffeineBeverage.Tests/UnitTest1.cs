using System.Text;
using NUnit.Framework;

namespace TemplateMethod.CaffeineBeverage.Tests
{
    public class Tests
    {
        #region Members

        private Tea _tea = new();
        private Coffee _coffee = new();
        private CoffeeWithHook _coffeeWithHook = new();
        private TeaWithHook _teaWithHook = new();
        private StringBuilder _teaResult = new();
        private StringBuilder _coffeeResult = new();
        private StringBuilder _coffeeWithHookYesResult = new();
        private StringBuilder _coffeeWithHookNoResult = new();
        private StringBuilder _teaWithHookYesResult = new();
        private StringBuilder _teaWithHookNoResult = new();
        #endregion//Members

        #region TestCleanup Dispose()
        public void Dispose()
        {
            _tea = null;
            _coffee = null;
            _coffeeWithHook = null;
            _teaWithHook = null;
            _teaResult = null;
            _coffeeResult = null;
            _coffeeWithHookYesResult = null;
            _coffeeWithHookNoResult = null;
            _teaWithHookYesResult = null;
            _teaWithHookNoResult = null;
        }
        #endregion//TearDown Dispose()

        #region TestTea
        [Test]
        public void TestTea()
        {
            _teaResult.Append("Boiling water\n");
            _teaResult.Append("Steeping the tea\n");
            _teaResult.Append("Pouring into cup\n");
            _teaResult.Append("Adding lemon\n");
            Assert.AreEqual(_teaResult.ToString(), _tea.PrepareRecipe());
        }
        #endregion//TestTea

        #region TestCoffee
        [Test]
        public void TestCoffee()
        {
            _coffeeResult.Append("Boiling water\n");
            _coffeeResult.Append("Dripping coffee through filter\n");
            _coffeeResult.Append("Pouring into cup\n");
            _coffeeResult.Append("Adding sugar and milk\n");
            Assert.AreEqual(_coffeeResult.ToString(), _coffee.PrepareRecipe());
        }
        #endregion//TestCoffee

        #region TestCoffeeWithHook
        [Test]
        public void TestCoffeeWithHook()
        {
            if (_coffeeWithHook.CustomerWantsCondiments())
            {
                _coffeeWithHookYesResult.Append("Boiling water\n");
                _coffeeWithHookYesResult.Append("Dripping coffee through filter\n");
                _coffeeWithHookYesResult.Append("Pouring into cup\n");
                _coffeeWithHookYesResult.Append("Adding sugar and milk\n");
                Assert.AreEqual(_coffeeWithHookYesResult.ToString(),
                    _coffeeWithHook.PrepareRecipe());
            }
            else
            {
                _coffeeWithHookNoResult.Append("Boiling water\n");
                _coffeeWithHookNoResult.Append("Dripping coffee through filter\n");
                _coffeeWithHookNoResult.Append("Pouring into cup\n");
                Assert.AreEqual(_coffeeWithHookNoResult.ToString(),
                    _coffeeWithHook.PrepareRecipe());
            }
        }
        #endregion//TestCoffeeWithHook

        #region TestTeaWithHook
        [Test]
        public void TestTeaWithHook()
        {
            if (_teaWithHook.CustomerWantsCondiments())
            {
                _teaWithHookYesResult.Append("Boiling water\n");
                _teaWithHookYesResult.Append("Steeping the tea\n");
                _teaWithHookYesResult.Append("Pouring into cup\n");
                _teaWithHookYesResult.Append("Adding lemon\n");
                Assert.AreEqual(_teaWithHookYesResult.ToString(),
                    _teaWithHook.PrepareRecipe());
            }
            else
            {
                _teaWithHookNoResult.Append("Boiling water\n");
                _teaWithHookNoResult.Append("Steeping the tea\n");
                _teaWithHookNoResult.Append("Pouring into cup\n");
                Assert.AreEqual(_teaWithHookNoResult.ToString(),
                    _teaWithHook.PrepareRecipe());
            }
        }
        #endregion//TestTeaWithHook
        
    }
}