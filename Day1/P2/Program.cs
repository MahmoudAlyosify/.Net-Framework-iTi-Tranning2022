using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{/*
  *Mahmoud Sayed Youssef
  2- Write a program which takes two numbers from the console and displays the maximum of the two.
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Check1, Check2;
            int Num1,Num2;
            Console.WriteLine("Enter two numbers");
            Check1 = int.TryParse(Console.ReadLine(), out Num1);
            Check2 = int.TryParse(Console.ReadLine(), out Num2);
           var Result= Num1 > Num2 & Check1 & Check2 ? ($"{Num1} is greater.") : ($"{Num2} is greater.");
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
