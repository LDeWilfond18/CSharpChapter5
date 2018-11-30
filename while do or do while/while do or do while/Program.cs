using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace while_do_or_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while(i <= 9)
            {
                WriteLine(i);
                i++;
            }
            while (i >= 0)
            {
                WriteLine(i);
                i--;
            }
            do
            {
                WriteLine(i);
                i++;
            } while (i <= 5);

            for (int j = 0; j <= 5; ++j)
            {
                WriteLine(j);
            }
        }
    }
}
