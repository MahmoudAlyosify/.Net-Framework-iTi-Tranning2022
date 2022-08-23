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
    internal class DownloaderPageContent
    {
        string linkURL = @"https://www.tesla.com/";
        WebClient myWebClient = new WebClient();
        Stream myStream = null;
        string path = @"C:\Users\Electronica Care\Desktop\The Page Contant.txt";
        public DownloaderPageContent(string linkURL)
        {
            this.linkURL = linkURL;
        }
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
        public void CheackAndDownload() { 
        if(Uri.IsWellFormedUriString(linkURL, UriKind.Absolute)&& Uri.TryCreate(linkURL, UriKind.Absolute, out Uri uriResult) && uriResult.Scheme == Uri.UriSchemeHttps){

                OpenBrowser(linkURL);
                try
                {
                    myStream = myWebClient.OpenRead(uriResult);
                    StreamReader myStreamReader = new StreamReader(myStream);
                    Collection<string> stringCollection = new Collection<string>();
                    string line;
                    while ((line = myStreamReader.ReadLine()) != null)
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
        }
        }
    }
}
