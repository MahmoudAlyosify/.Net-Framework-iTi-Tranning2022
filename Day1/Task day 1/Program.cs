using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_1
{
    /*
     
     Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string OK = "ok";
            string stringNumber;
            int numericValue;
            bool isNumber;
            int sum = 0;
            do
            {
                Console.WriteLine("Input a Number:");
                stringNumber = Console.ReadLine();
                isNumber = int.TryParse(stringNumber, out numericValue);
                if (isNumber) sum += numericValue;
                else if (!isNumber && stringNumber.ToLower() != OK) Console.WriteLine("Invalid input again\n");
            }
            while (stringNumber.ToLower() != OK);
            Console.WriteLine($"The sum: {sum}");
            Console.ReadKey();
        }
    }
}
