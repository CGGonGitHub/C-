using cclock;
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        CommandHandler commandHandler = new CommandHandler();

        if (args.Length == 0)
        {
            Console.WriteLine("// CoolGermanGuy's custom clock (cclock) \\");
            Console.WriteLine();
            Console.WriteLine("use cclock -h or cclock -help for help");
            Console.WriteLine("use cclock -l or cclock -list for a list of commands");
        }
        else
        {
            string command = args[0];
            commandHandler.ExecuteCommand(command);
        }

    }
}
