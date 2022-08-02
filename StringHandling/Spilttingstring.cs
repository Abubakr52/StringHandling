using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    public class Spilttingstring
    {
        public void spilt()
        {
            string s = "You win some. You lose some.";

            string[] substring = s.Split(' ');
            foreach (var item in substring)
            {
                Console.WriteLine($"Substring:{item}");
            }
        }
    }
}
