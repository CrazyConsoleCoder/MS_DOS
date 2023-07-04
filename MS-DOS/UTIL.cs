using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_DOS_UTIL
{
    internal class UTIL
    {
        string DigitalClassifier(int num)
        {
            IEnumerable<char> numString = num.ToString().Reverse();
            string tempResult = "";
            string result = "";

            for (int i = 0; i < numString.Count(); i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    tempResult += ',';
                }
                tempResult += numString.ToArray()[i];
            }
            for (int i = tempResult.Count(); i >= 0; i--)
            {
                result += tempResult[i];
            }
            return result;
        }
    }

    internal class FileSystem { }
}
