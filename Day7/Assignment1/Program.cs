using System;

namespace Assignment1
{
    /*
     Write a program in C# that take from the user the address of a web page then try to open it
     and download the inner content for this page 
     the program should fire an event to notify the  systtem when downloading completed 
     and then write it to text file
the application should be responsive during the whole process

     */
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string linkURL;
            Console.WriteLine("Enter the Link of Webpage ^__^ ");
            linkURL= Console.ReadLine();
            DownloaderPageContent downloaderPageContent = new DownloaderPageContent(linkURL);

            if ( Uri.IsWellFormedUriString(linkURL, UriKind.Absolute))
            {
                DownloaderPageContent.OpenBrowser(linkURL);
                downloaderPageContent.CheackAndDownload();

            }
            else
            {
                Console.WriteLine("Invalid Link Try Again !!");
            }

        }
    }
}
