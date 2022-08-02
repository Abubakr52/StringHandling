using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class ComparingStrings
    {
       char space=' ';
        public void compare(string str1,string str2)
        { 
       
        if(string.Compare(str1,str2)==0)
        {
                Console.WriteLine($"{str1}{space}and{space}{str2} Both are equal");
        }
                Console.WriteLine($"{str1}{space}and{space}{str2} Both are Not equal");
        }
    }
}
