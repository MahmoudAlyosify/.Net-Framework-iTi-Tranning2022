using System;
using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
        public static void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
        static void Main(string[] args)
        {
            string linkURL;
             WebClient myWebClient = new WebClient();
            Stream myStream = null;
            string path = @"C:\Users\Electronica Care\Desktop\The Page Contant.txt";
            
            Console.WriteLine("Enter the Link of Webpage ^__^ ");
            linkURL= Console.ReadLine();
            if(linkURL.Equals(""))
            linkURL = @"https://www.tesla.com/";
            bool CheckURLValid = Uri.TryCreate(linkURL, UriKind.Absolute, out Uri uriResult) && uriResult.Scheme == Uri.UriSchemeHttps;
            
            if (CheckURLValid&& Uri.IsWellFormedUriString(linkURL, UriKind.Absolute))
            {
                OpenBrowser(linkURL);
                try
                {
                    myStream=myWebClient.OpenRead(uriResult);
                    StreamReader myStreamReader = new StreamReader(myStream);
                    Collection<string> stringCollection = new Collection<string>();
                    string line;
                    while ((line=myStreamReader.ReadLine())!=null)
                    {
                        stringCollection.Add(line);
                    }
                    try
                    {
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter(path);
                        //Write a line of text
                        for (int i = 0; i < stringCollection.ToArray().Length; i++)
                        {
                            sw.WriteLine(stringCollection.ToArray()[i]);
                        }
                        
                        //Close the file
                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                }
                catch
                {
                    Console.WriteLine("Can't Download the file !!!");
                }
            }
            else { 
                Console.WriteLine("Invalid Link Try Again !!");
            }

        }
    }
}
