using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using MS_DOS_CONFIG;
using MS_DOS_UTIL;

namespace MS_DOS_PARSER
{
    internal class PARSER
    {
        internal static void CommandParse(string command, bool newline=true)
        {
            string[] GetArgs()
            {
                List<string> args = command.Split(' ').ToList();
                args.Remove(command.Split(' ')[0]);
                return args.ToArray();
            }
            
            List<FileSystem> GetFiles(string pos)
            {
                List<FileSystem> result = new List<FileSystem>();
                if (pos.Split('\\').Count() == 2)
                {
                    foreach (var file in CONFIG.part.GetFiles())
                    {
                        result.Add(file);
                    }
                }
                else {
                    foreach (var file in CONFIG.part.GetFiles())
                    {
                        if (ReferenceEquals(file.GetType(), typeof(MS_DOS_UTIL.Directory)))
                        {
                            if (((MS_DOS_UTIL.Directory)file).GetName() == pos.Split('\\')[1])
                            {
                                foreach (var file1 in ((MS_DOS_UTIL.Directory)file).GetFiles())
                                {
                                    result.Add(file1);
                                }
                            }
                        }
                    }
                }
                return result;
            }
            command = command.ToUpper();
            string[] args = GetArgs();

            void cd()
            {
                if (args.Length <= 1)
                {
                    if (command == "CD")
                    {
                        Console.WriteLine(CONFIG.pos);
                    }
                    else if (command.ToUpper() == "CD ..")
                    {
                        CONFIG.pos = CONFIG.pos.Split('\\')[CONFIG.pos.Split('\\').Count() - 2];
                    }
                    else if (Regex.IsMatch(args[0], @"(.+(\..+)\\)+\.\.") || Regex.IsMatch(args[0], @$"{CONFIG.part.GetDrive()}:(\\)?"))
                    {
                        CONFIG.pos = $"{CONFIG.part.GetDrive()}:\\";
                    }
                    else if (Regex.IsMatch(args[0], @".+(\..+)?(\\)?"))
                    {
                        bool loopLock = true;
                        foreach (var file in GetFiles(CONFIG.pos))
                        {
                            if (ReferenceEquals(file.GetType(), typeof(MS_DOS_UTIL.Directory)))
                            {
                                if (args[0] == ((MS_DOS_UTIL.Directory)file).GetName())
                                {
                                    CONFIG.pos = $"{CONFIG.part.GetDrive()}:\\{((MS_DOS_UTIL.Directory)file).GetName()}\\";
                                    loopLock = false;
                                    break;
                                }
                            }
                        }
                        if (loopLock)
                        {
                            Console.WriteLine("Invalid directory");
                        }
                    }
                    else if (Regex.IsMatch(args[0], @$"({CONFIG.part.GetDrive()}:\\)?.+(\..+)?(\\)?"))
                    {
                        bool loopLock = true;
                        foreach (var file in GetFiles(CONFIG.pos))
                        {
                            if (ReferenceEquals(file.GetType(), typeof(MS_DOS_UTIL.Directory)))
                            {
                                if (args[0].Remove(0, 3) == ((MS_DOS_UTIL.Directory)file).GetName())
                                {
                                    CONFIG.pos = $"{CONFIG.part.GetDrive()}:\\{((MS_DOS_UTIL.Directory)file).GetName()}\\";
                                    loopLock = false;
                                    break;
                                }
                            }
                        }
                        if (loopLock)
                        {
                            Console.WriteLine("Invalid directory");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Too many parameter - {args[1]}");
                }
            }

            Dictionary<string, Action> func = new Dictionary<string, Action>()
            {
                {"CD", cd},
                {"CHDIR", cd}
            };
            if (func.Keys.Contains(command.Split(' ')[0]))
            {
                func[command.Split(' ')[0]]();
            }
            else
            {
                bool loopLock = true;
                string[] path = CONFIG.envVar["PATH"].Split(';');
                foreach (var file in GetFiles(CONFIG.pos))
                {
                    if (ReferenceEquals(file.GetType(), typeof(MS_DOS_UTIL.File)))
                    {
                        if (command.Split(' ')[0] == ((MS_DOS_UTIL.File)file).GetName() || command.Split(' ')[0] == ((MS_DOS_UTIL.File)file).GetName().Split('.')[0])
                        {
                            loopLock = false;
                        }
                    }
                }
                foreach (var file in CONFIG.part.GetFiles())
                {
                    if (!loopLock)
                    {
                        break;
                    }
                    if (ReferenceEquals(file.GetType(), typeof(MS_DOS_UTIL.Directory)))
                    {
                        if (path.Contains($"{CONFIG.part.GetDrive()}:\\{((MS_DOS_UTIL.Directory)file).GetName()}"))
                        {
                            foreach (var file1 in GetFiles($"{CONFIG.part.GetDrive()}:\\{((MS_DOS_UTIL.Directory)file).GetName()}\\"))
                            {
                                if (command.Split(' ')[0] == ((MS_DOS_UTIL.File)file1).GetName() || command.Split(' ')[0] == ((MS_DOS_UTIL.File)file1).GetName().Split('.')[0])
                                {
                                    loopLock = false;
                                }
                            }
                        }
                    }
                }
                if (loopLock)
                {
                    if (!string.IsNullOrEmpty(command))
                    {
                        Console.WriteLine("Bad command or file name");
                    }
                }
            }
            if (!string.IsNullOrEmpty(command) && newline)
            {
                Console.WriteLine();
            }
        }
    }
}
