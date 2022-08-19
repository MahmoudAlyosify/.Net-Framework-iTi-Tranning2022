using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{/*
  Write a program and ask the user to enter a series of numbers separated by comma. Find the 
maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 
1, 4", the program should display 8
  
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Check=false;
            int Number;
            List<int> Numbers = new List<int>();
            Console.WriteLine("Enter series of Numbers separated by comma.");
            string series=Console.ReadLine();
            foreach (string N in series.Split(','))
            {
                Check=int.TryParse(N, out Number);
                if(Check)Numbers.Add(Number);
                else { Console.WriteLine("Your serie have char you must enter only Numbers OR you are type character in the end of series!!!");
                    break;
                }
            }
             if(Check)Console.WriteLine("The Maximum of the numbers is: " + Numbers.Max());
            Console.ReadKey();
        }
    }
}
