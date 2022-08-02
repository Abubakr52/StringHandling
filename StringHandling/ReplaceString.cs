using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class ReplaceString
    {
        public void Replacing()
        {
            string str1 = "C-Sharp Console App";
            string result = str1.Replace("C-Sharp", "Asp.net Mvc");
            Console.WriteLine("After Replacing {0} \n The New String is : {1}", str1, result);
        }
    }
}
