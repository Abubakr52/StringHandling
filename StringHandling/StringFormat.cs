using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class StringFormat
    {
        public void Formatstring(string str1,string str2)
        {
         string str3 = String.Format("The String 1 using left padding {0,20}\nString 2 padding {1,15}", str1, str2);
                Console.WriteLine(str3);
        }
       
    }
}
