﻿using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }
        Command[] commands = { new Command("MOVE", 0), new Command("MOVE", 20) };


        public Message (string name)
        {
            this.Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Command type required.");
            }
        }
        public Message(string name, Command[] commands)
        {
            this.Name = name;
            this.Commands = commands;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Command type required.");
            }
        }


    }
}
