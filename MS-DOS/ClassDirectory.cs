using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_DOS_UTIL
{
    internal class Directory : FileSystem
    {
        string name;
        int size;
        List<File> files;
        DateTime createTime;
        List<char> attrib;

        internal string GetName() => name;
        internal void SetName(string value) => name = value;
        internal int GetSize() => size;
        internal List<File> GetFiles() => files;
        internal void SetFiles(List<File> value) => files = value;
        internal DateTime GetCreateTime() => createTime;
        internal List<char> GetAttrib() => attrib;
        internal void SetAttrib(List<char> value) => attrib = value;

        internal Directory(string name, List<File> files)
        {
            this.name = name;
            foreach (File file in files)
            {
                this.size += file.GetSize();
            }
            this.files = files;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.attrib = new List<char>() { 'D', 'S' };
        }

        internal Directory(string name, List<File> files, List<char> attrib)
        {
            this.name = name;
            foreach (File file in files)
            {
                this.size += file.GetSize();
            }
            this.files = files;
            this.createTime = new DateTime(1993, 3, 10, 6, 0, 0);
            this.attrib = attrib;
        }

        internal Directory(string name, List<File> files, DateTime createTime)
        {
            this.name = name;
            foreach (File file in files)
            {
                this.size += file.GetSize();
            }
            this.files = files;
            this.createTime = createTime;
            this.attrib = new List<char>() { 'D', 'S' };
        }

        internal Directory(string name, List<File> files, DateTime createTime, List<char> attrib)
        {
            this.name = name;
            foreach (File file in files)
            {
                this.size += file.GetSize();
            }
            this.files = files;
            this.createTime = createTime;
            this.attrib = attrib;
        }
    }
}
