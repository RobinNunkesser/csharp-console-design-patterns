using NUnit.Framework;

namespace Adapter.Birds.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestMallardDuck()
    {
        IDuck mallard = new MallardDuck();
        Assert.AreEqual("Quack", mallard.Quack());
        Assert.AreEqual("I'm flying", mallard.Fly());
    }

    [Test]
    public void TestWildTurkey()
    {
        ITurkey wildTurkey = new WildTurkey();
        Assert.AreEqual("Gobble, gobble", wildTurkey.Gobble());
        Assert.AreEqual("I'm flying a short distance", wildTurkey.Fly());
    }

    [Test]
    public void TestTurkeyAdapter()
    {
        ITurkey wildTurkey = new WildTurkey();
        IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);

        Assert.AreEqual("Gobble, gobble", turkeyAdapter.Quack());
        Assert.AreEqual("I'm flying a short distance\n" +
                        "I'm flying a short distance\n" +
                        "I'm flying a short distance\n" +
                        "I'm flying a short distance\n" +
                        "I'm flying a short distance\n", turkeyAdapter.Fly());
    }

    [Test]
    public void TestDuckAdapter()
    {
        IDuck mallard = new MallardDuck();
        ITurkey duckAdapter = new DuckAdapter(mallard);

        Assert.AreEqual("Quack", duckAdapter.Gobble());
        Assert.AreEqual("I'm flying", duckAdapter.Fly());
    }
}