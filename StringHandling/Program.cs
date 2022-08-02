using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "hi";
          

            ////ComparingStrings comparingStrings = new ComparingStrings();
            ////comparingStrings.compare(str1,str2);

            //SubString subString = new SubString();
            //subString.substring();


            //StringJoin stringJoin = new StringJoin();
            //stringJoin.join();

            //ConcatString concatString = new ConcatString();
            //concatString.concat(str1,str2);

            //StringFormat stringFormat = new StringFormat();
            //stringFormat.Formatstring(str1,str2);

            //Spilttingstring spilttingstring = new Spilttingstring();
            //spilttingstring.spilt();

            // TrimString trimString = new TrimString();
            //trimString.trim();

            ReplaceString replaceString= new ReplaceString();
            replaceString.Replacing();

            Console.ReadLine();



















            //char space = ' ';
            //string firstname="Abubakr";
            //string lastname="Siddique";
            //string fullname=firstname+lastname;
            ////Console.WriteLine("Your Name is:"+firstname+" "+lastname);
            ////Console.WriteLine(fullname);
            ////Console.WriteLine($"Your Full Name is:{fullname}");
            //Console.WriteLine($"Your First Name is:{firstname}{space}Last Name is:{lastname} ");

        }
    }
}
