using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    internal class Program
	{/*
      
      Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
      */
		static void Main(string[] args)
        {
			Console.WriteLine("Please enter a number and get the factorial of it");

			int number = int.Parse(Console.ReadLine());
			long factorial = 1;



			for (int i = 1; i <= number; i++)
			{
				factorial = factorial * i;
			}

			Console.WriteLine("{0}! : {1}", number, factorial);
			Console.ReadKey();
		}
    }
}
