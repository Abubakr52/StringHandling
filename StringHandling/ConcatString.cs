using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class ConcatString
    {
        public void concat(string str1, string str2)
        {
            char space = ' ';
            string stringjoin = string.Concat($"{str1}{space}{str2}");
            Console.WriteLine(str1.Length);
            Console.WriteLine(stringjoin);
        }
    }
}
