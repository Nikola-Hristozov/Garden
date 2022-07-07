using System;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add Garden item as *name* *count* (optional)*beauty/energy* (optional)*water need*\nType end or send empty row to get the results.\n");
            Garden garden = new Garden();
            string command;
            do
            {
                Console.Write("Add an item or end: ");
                command = Console.ReadLine().ToLower();
                var commands = command.Trim().Split(' ');
                if (commands.Length == 2)
                    garden.Add(commands[0], int.Parse(commands[1]));
                else if (commands.Length == 4)
                    garden.Add(commands[0], int.Parse(commands[1]), int.Parse(commands[2]), int.Parse(commands[3]));

            }
            while (command != "end" && command!="");
            Console.WriteLine(garden.ToString());
        }
    }
}
