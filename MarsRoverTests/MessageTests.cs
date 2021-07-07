using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;


namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };
        
        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                new Message("New Rover", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message required", ex.Message);
            }
        }
        [TestMethod]
        public void ConstructorSetsName()
        {

            string testName = "Charles";
            Message message1 = new Message(testName);
            Assert.IsTrue(testName == message1.Name);
            Assert.AreEqual(testName, message1.Name);
            Console.WriteLine();
        }
        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message newMessage = new Message("Bar", commands);
            Assert.AreEqual(commands, newMessage.Commands);

                      

        }
    }
}
