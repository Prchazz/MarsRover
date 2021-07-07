using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {

            Rover myRover = new Rover(20);
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 5000) };
            //Command[] commands = { new Command("MOVE", 5000) };
            //Console.WriteLine(myRover.ToString());
            Message newMessage = new Message("Test message with one command", commands);
            //Rover newRover = new Rover(98382);

            Console.WriteLine(myRover.ToString());
            //newRover.ReceiveMessage(newMessage);
            //Console.WriteLine(newRover.ToString());
            myRover.ReceiveMessage(newMessage);
            Console.WriteLine(myRover.ToString());
        }
    }
}
