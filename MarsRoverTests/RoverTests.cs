using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {   [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newPosition = new Rover (0);
            Assert.AreEqual(newPosition.Position, 0);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newMode = new Rover(0);
            Assert.AreEqual(newMode.Mode, "NORMAL");
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newGenerator = new Rover(0);
            Assert.AreEqual(newGenerator.GeneratorWatts, 110);
        }
        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover MODE_CHANGE = new Rover("LOW_POWER");
            Assert.AreEqual(MODE_CHANGE.Mode, "LOW_POWER");
        }
        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Rover myRover = new Rover(20);
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with one command", commands);
            myRover.ReceiveMessage(newMessage);
            Assert.AreEqual(myRover.Position, 20);
        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Rover myRover = new Rover(20);
            Command[] commands = { new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with one command", commands);
            myRover.ReceiveMessage(newMessage);
            Assert.AreEqual(myRover.Position, 5000);
        }
}
}
