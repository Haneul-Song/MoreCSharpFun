using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff
    {
        private string language;

        // Contructor
        public PrintStuff ()
        {
            language = "EN";
        }
        public PrintStuff(string temp) 
        {
            language = temp;
        }
    
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "KR")
            {
            System.Console.WriteLine("안녕, " + n + "!");
            }
        }
    }
}
