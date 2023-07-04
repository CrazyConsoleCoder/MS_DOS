using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MS_DOS_CONFIG;
using MS_DOS_PARSER;

namespace MS_DOS_MAIN
{
    internal class MAIN
    {
        internal static void Start(string[] args)
        {
            Console.WriteLine("Starting MS-DOS...");
            Thread.Sleep(new Random().Next(3000, 7000));

            if (CONFIG.echo)
            {
                Console.Write(CONFIG.prompt);
            }
            string? command = Console.ReadLine();
            while (command != null && command.ToUpper() != "EXIT")
            {
                PARSER.CommandParse(command.Trim());
                if (CONFIG.echo)
                {
                    Console.Write(CONFIG.prompt);
                }
                command = Console.ReadLine();
            }
        }
    }
}
