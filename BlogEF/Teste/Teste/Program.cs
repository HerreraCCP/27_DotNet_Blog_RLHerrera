﻿using System;
using System.Text.RegularExpressions;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 100; i++)
            {
                
                Console.WriteLine($"{i}");
                if (i % 3 == 0 && i % 5 == 0)  Console.WriteLine($"Fizz Buzz");
                else if (i % 3 == 0) Console.WriteLine($"Fizz");
                else if (i % 5 == 0)  Console.WriteLine($"Buzz");
                else  Console.WriteLine($"");
            }
        }
        
    }
}