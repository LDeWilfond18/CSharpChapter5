﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCounter = 1;

            do
            {
                WriteLine("");
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 1);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 2);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 3);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 4);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 5);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 6);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 7);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 8);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 9);
                WriteLine("{0} times 1 is {1}", numCounter, numCounter * 10);
                numCounter++;
            } while (numCounter <= 10);
            
        }
    }
}
