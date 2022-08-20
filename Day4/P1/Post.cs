using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{ //This class models a StackOverflow post
    internal class Post
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime DateTimeOfCreation  { get; set; }
        public int CountOfVoting { get; private set; }


        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            DateTimeOfCreation = DateTime.UtcNow;
            CountOfVoting = 0;
        }

        public void VoteUp()
        {

                CountOfVoting++;
        }

        public void VoteDown()
        {
            if(CountOfVoting > 0)
                CountOfVoting--;
            else
            {
                throw new Exception("The Counter of Voting is less than or equal 0");
            }
        }
        public void PrintFullPost()
        {
            Console.WriteLine($"Title: {this.Title}");
            Console.WriteLine($"Description: {this.Description}");
            Console.WriteLine($"Date of Creatation: {this.DateTimeOfCreation.ToString("f")}");
            Console.WriteLine($"The Count: {this.CountOfVoting}");
        }
    }
}
