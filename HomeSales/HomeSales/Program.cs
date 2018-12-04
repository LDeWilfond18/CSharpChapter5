using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            char initial;
            int francis = 0;
            int danielle = 0;
            int edward = 0;
            int total = 0;
            do
            {
                WriteLine("Enter your initial brother>> ");
                initial = Convert.ToChar(ReadLine());
                if(initial == 'D' || initial == 'd')
                {
                    WriteLine
                }
                else if (initial == 'E' || initial == 'e')
                {
                    edward++;
                    total++;
                }
                else if (initial == 'F' || initial == 'f')
                {
                    francis++;
                    total++;
                }
            } while (initial != 'z' && initial != 'Z');

            WriteLine("Edward sold {0} houses ", edward);
            WriteLine("Danielle sold {0} houses ", danielle);
            WriteLine("Francis sold {0} houses ", francis);
            WriteLine("The total houses sold is " + total);
        }
    }
}
