using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class TrimString
    {
        public void trim()
        {
            string hello = " Hello this a string ";
            Console.WriteLine(hello.Trim());
            string someString = "*......Hello World.....*";
            char[] chars = { '*', '.' };
            string cleanstring=someString.Trim(chars);
            Console.WriteLine(cleanstring);
        }
        


//        string hello = " hello C# Corner has white spaces ";
//        // Remove whitespaces from both ends  
//        Console.WriteLine(hello.Trim());  
  
//// String with characters  
//string someString = ".....My name is Mahesh Chand****";
//        char[] charsToTrim = { '*', '.' };
//        string cleanString = someString.Trim(charsToTrim);
//        Console.WriteLine(cleanString);  
    }
}
