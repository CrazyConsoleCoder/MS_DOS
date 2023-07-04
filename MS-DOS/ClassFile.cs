using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_DOS_UTIL
{
    internal class File : FileSystem
    {
        string name;
        int size;
        DateTime createTime;
        string content;
        List<char> attrib;

        internal string GetName() => name;
        internal void SetName(string value) => name = value;
        internal int GetSize() => size;
        internal DateTime GetCreateTime() => createTime;
        internal string GetContent() => content;
        internal List<char> GetAttrib() => attrib;
        internal void SetAttrib(List<char> value) => attrib = value;

        string ContentGen()
        {
            string result = "";
            for (int i = 0; i < size; i++)
            {
                if (i % 99 != 0 && i != 0)
                {
                    result += '\n';
                }
                else
                {
                    result += (char)new Random().Next(128);
                }
            }
            return result;
        }

        internal File(string name, int size, string content, List<char> attrib)
        {
            this.name = name;
            this.size = size;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.content = content;
            this.attrib = attrib;
        }

        internal File(string name, int size, DateTime createTime, List<char> attrib)
        {
            this.name = name;
            this.size = size;
            this.createTime = createTime;
            this.content = ContentGen();
            this.attrib = attrib;
        }

        internal File(string name, int size, DateTime createTime, string content)
        {
            this.name = name;
            this.size = size;
            this.createTime = createTime;
            this.content = content;
            this.attrib = new List<char>() { 'S', 'R' };
        }

        internal File(string name, int size, List<char> attrib)
        {
            this.name = name;
            this.size = size;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.content = ContentGen();
            this.attrib = attrib;
        }

        internal File(string name, int size, DateTime createTime)
        {
            this.name = name;
            this.size = size;
            this.createTime = createTime;
            this.content = ContentGen();
            this.attrib = new List<char>() { 'S', 'R' };
        }

        internal File(string name, int size, string content)
        {
            this.name = name;
            this.size = size;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.content = content;
            this.attrib = new List<char>() { 'S', 'R' };
        }

        internal File(string name, int size)
        {
            this.name = name;
            this.size = size;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.content = ContentGen();
            this.attrib = new List<char>() { 'S', 'R' };
        }

        internal File(string name, int size, DateTime createTime, string content, List<char> attrib)
        {
            this.name = name;
            this.size = size;
            this.createTime = createTime;
            this.content = content;
            this.attrib = attrib;
        }
    }
}
