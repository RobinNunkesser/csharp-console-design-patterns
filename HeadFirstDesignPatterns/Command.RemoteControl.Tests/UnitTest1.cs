using NUnit.Framework;

namespace Command.RemoteControl.Tests;

public class Tests
{
    #region TestTurningSimpleOn

    [Test]
    public void TestTurningSimpleOn() //Command Pattern Client
    {
        //Command Pattern Invoker
        var remote = new SimpleRemoteControl();

        //Command Pattern Receivers
        var light = new Light("Kitchen");
        var garageDoor = new GarageDoor("");

        //Commands for the receivers
        var lightOn = new LightOnCommand(light);
        var garageDoorOpen =
            new GarageDoorUpCommand(garageDoor);

        //Passing the light on command to the invoker
        remote.SetCommand(lightOn);
        //Simulate the button being pressed on the invoker
        Assert.AreEqual("Kitchen light is on", remote.ButtonWasPressed());

        //Passing the garage door open command to the invoker
        remote.SetCommand(garageDoorOpen);
        //Simulate the button being pressed on the invoker
        Assert.AreEqual("Garage door is up", remote.ButtonWasPressed());
    }

    #endregion //TestTurningSimpleOn

    #region TestTurningOn

    [Test]
    public void TestTurningOn() //Command Pattern Client
    {
        //Command Pattern Invoker
        var remote = new Remote();

        var livingRoomLight = new Light("Living Room");
        var kitchenLight = new Light("Kitchen");
        var ceilingFan = new CeilingFan("Living Room");
        var garageDoor = new GarageDoor("");
        var stereo = new Stereo("Living Room");

        var livingRoomLightOn =
            new LightOnCommand(livingRoomLight);
        var livingRoomLightOff =
            new LightOffCommand(livingRoomLight);
        var kitchenLightOn =
            new LightOnCommand(kitchenLight);
        var kitchenLightOff =
            new LightOffCommand(kitchenLight);

        var ceilingFanOn =
            new CeilingFanOnCommand(ceilingFan);
        var ceilingFanOff =
            new CeilingFanOffCommand(ceilingFan);

        var garageDoorUp =
            new GarageDoorUpCommand(garageDoor);
        var garageDoorDown =
            new GarageDoorDownCommand(garageDoor);

        var stereoOnWithCD =
            new StereoOnWithCDCommand(stereo);
        var stereoOff =
            new StereoOffCommand(stereo);

        remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
        remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
        remote.SetCommand(2, ceilingFanOn, ceilingFanOff);
        remote.SetCommand(3, stereoOnWithCD, stereoOff);

        Assert.AreEqual("Living Room light is on",
            remote.OnButtonWasPushed(0));
        Assert.AreEqual("Living Room light is off",
            remote.OffButtonWasPushed(0));

        Assert.AreEqual("Kitchen light is on",
            remote.OnButtonWasPushed(1));
        Assert.AreEqual("Kitchen light is off",
            remote.OffButtonWasPushed(1));
        Assert.AreEqual("Living Room ceiling fan is on high",
            remote.OnButtonWasPushed(2));
        Assert.AreEqual("Living Room ceiling fan is off",
            remote.OffButtonWasPushed(2));
        Assert.AreEqual("Living Room stereo is on\n" +
                        "Living Room stereo is set for CD input\n" +
                        "Living Room Stereo volume set to 11",
            remote.OnButtonWasPushed(3));
        Assert.AreEqual("Living Room stereo is off",
            remote.OffButtonWasPushed(3));

        //          Console.WriteLine(remote.toString());
    }

    #endregion
}