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
            string initial;
            double francis = 0;
            double danielle = 0;
            double edward = 0;
            double francisTotal = 0;
            double danielleTotal = 0;
            double edwardTotal = 0;
            double grandTotal = 0;
            do
            {
                WriteLine("Enter your initial brother>> ");
                initial = Convert.ToString(ReadLine());
                if(initial == "D" || initial == "d")
                {
                    WriteLine("enter amount of moonay");
                    danielle = Convert.ToDouble(ReadLine());
                    danielleTotal = danielle + danielleTotal;
                }
                else if (initial == "E" || initial == "e")
                {
                    WriteLine("enter amount of moonay");
                    edward = Convert.ToDouble(ReadLine());
                    edwardTotal = edward + edwardTotal;
                }
                else if (initial == "F" || initial == "f")
                {
                    WriteLine("enter amount of moonay");
                    francis = Convert.ToDouble(ReadLine());
                    francis = francis + francisTotal;
                }
            } while (initial != "z" && initial != "Z");

            if(danielleTotal > edwardTotal && danielleTotal > francisTotal)
            {
                WriteLine("Danielle had the most sales with " + danielleTotal);
            }
            else if(edwardTotal > danielleTotal && edwardTotal > francisTotal)
            {
                WriteLine("Edward had the most sales with " + edwardTotal);
            }
            else if (francisTotal > danielleTotal && francisTotal > edwardTotal)
            {
                WriteLine("Edward had the most sales with " + francisTotal);
            }

            grandTotal = francisTotal + danielleTotal + edwardTotal;
            WriteLine("Grand total is {0} ", grandTotal);
            WriteLine("Edward's sales were {0} ", edward);
            WriteLine("Danielle's sales were {0} ", danielle);
            WriteLine("Francis' sales were {0} ", francis);
        }
    }
}
