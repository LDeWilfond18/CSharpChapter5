using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            int exit;
            do
            {
                WriteLine("Enter a lowercase letter. ");
                letter = Convert.ToChar(ReadLine());

                if (letter >= 'a' && letter <= 's')
                {
                    WriteLine("Character is lowercase");
                }
                else
                    WriteLine("ERROR");

            } while (letter == '!');
        }
    }
}
