using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class Program
    {
        static void WarningAlarm(object sender, BannedUserEventArgs e)
        {
            Console.WriteLine("{0} Users Found. Sending Email to Administration.", e.Name);
            Console.WriteLine("Email Sent.");
            Console.WriteLine("Warning Alarm Started.");
            Console.WriteLine("Press Ctrl + c to stop the alarm");
            for (; ; )
            {
                Console.Beep();
                System.Threading.Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            EnterName ename = new EnterName();
            ename.ev_BannedUser += WarningAlarm;
            ename.User();
            Console.Read();
        }
    }
}
