using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Challenge 1. Write a program that reads a text file and displays the number of words.
            var path = @"F:\.Net frame work iTi\Labs\.Net-Framework-iTi-Tranning2022\Day5\P1\Text.txt";

            var wordNum = new List<string>(File.ReadAllText(path).Split(' '));

            Console.WriteLine(wordNum.Count());

            //Challenge 2. Write a program that reads a text file and displays the longest word in the file.

            int wordLenght = 0;
            var longestWord = "";

            foreach (var word in wordNum)
            {
                if (word.Length > wordLenght)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine(longestWord);
            Console.ReadKey();
        }
    }
}
