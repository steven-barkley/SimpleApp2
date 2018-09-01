﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Set up console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("******************************");
            Console.WriteLine("** Welcome to My Rocking App**");
            Console.WriteLine("******************************");
            Console.WriteLine("******************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // What for the Enter key to be pressed.
            Console.ReadLine();
        }
    }
}

