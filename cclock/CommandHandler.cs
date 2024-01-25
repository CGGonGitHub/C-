using System;

namespace cclock
{
    public class CommandHandler
    {
        Clock Clock = new Clock();
        private Dictionary<string, Action> commands;
        
        // Commands
        public CommandHandler()
        {
            commands = new Dictionary<string, Action>();
            commands["-n"] = () => PrintTimeNow();
            commands["-now"] = () => PrintTimeNow();
            commands["-wi"] = () => WhatTimeIsItIn();
            commands["-whenin"] = () => WhatTimeIsItIn();
        }

        public void ExecuteCommand(string command)
        {
            if (commands.ContainsKey(command))
            {
                commands[command].Invoke();
            } else
            {
                Console.WriteLine($"Command \"{command}\" does not exist.");
            }
        }

        // Command Functions
        public void PrintTimeNow()
        {
            var currentTime = Clock.GetTimeNow();
            Console.WriteLine("Current Time:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{currentTime.Item1}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{currentTime.Item2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(":");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{currentTime.Item3}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WhatTimeIsItIn(string inputTime)
        {

        }
    }
}
