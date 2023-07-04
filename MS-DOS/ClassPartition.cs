using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_DOS_UTIL
{
    internal class Partition
    {
        char drive;
        string label;
        int size;
        List<FileSystem> files;
        string serialNum;

        internal char GetDrive() => drive;
        internal string GetLabel() => label;
        internal int GetSize() => size;
        internal List<FileSystem> GetFiles() => files;
        internal void SetFiles(List<FileSystem> value) => files = value;
        internal string GetSerialNum() => serialNum;

        string SerialNumGen()
        {
            string result = "";
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            for (int i = 0; i < 9; i++)
            {
                if (i == 4)
                {
                    result += '-';
                }
                else
                {
                    if (new Random().Next(2) == 0)
                    {
                        result += letters[new Random().Next(letters.Count())];
                    }
                    else
                    {
                        result += new Random().Next(10).ToString();
                    }
                }
            }
            return result;
        }

        internal Partition(char drive, string label, int size, List<FileSystem> files)
        {
            this.drive = drive;
            this.label = label;
            this.size = size;
            this.files = files;
            this.serialNum = SerialNumGen();
        }
    }
}
