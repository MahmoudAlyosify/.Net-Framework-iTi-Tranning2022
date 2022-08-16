using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{/*
  * Mahmoud Sayed Youssef
  1- Write a program and ask the user to enter a number. 
    The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
    (This logic is used a lot in applications where values entered into input boxes need to be validated.)
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Check;
            int Num;
            Console.WriteLine("Enter a number");
            Check = int.TryParse(Console.ReadLine(), out Num);
            if (Num >= 1 && Num <= 10 && Check) Console.WriteLine("Valid");
            else Console.WriteLine("Invalid");
            Console.ReadKey();
        }
    }
}
