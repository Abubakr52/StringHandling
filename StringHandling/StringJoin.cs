using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class StringJoin
    {
        public void join()
        {
            string[] starray = new string[]
            {
                "This is 1st string",
                "This is 2nd string",
                "This is 3rd string",
              
            };
             String str= String.Join("\n", starray);
            Console.WriteLine(str);
        }
    }
}
