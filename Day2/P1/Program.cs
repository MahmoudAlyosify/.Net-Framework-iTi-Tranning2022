using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			/*
            When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern.
             */

			List<string> people = new List<string>();
			string names;
			while (true)
			{
				Console.WriteLine("Please enter a name then press enter to finish: ");
				names = Console.ReadLine();
				if ( string.IsNullOrWhiteSpace(names))
				{
					break;
				}
				else
				{
					people.Add(names);
				}
			}
			int other = people.Count - 2;
			switch (people.Count)
			{
				case 0:
					Console.WriteLine("No likes yet");
					break;
				case 1:
					Console.WriteLine("{0} likes your post.", people[0]);
					break;
				case 2:
					Console.WriteLine("{0} and {1} like your post.", people[0], people[1]);
					break;
				default:
					Console.WriteLine("{0}, {1}, and {2} other people like your post.", people[0], people[1], other
						);
					break;
			}
		
		Console.ReadKey();
        }
    }
}
