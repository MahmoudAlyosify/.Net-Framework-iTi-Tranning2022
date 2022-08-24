using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class EnterName
    {

        public event EventHandler<BannedUserEventArgs> ev_BannedUser;
        public void User()
        {
            Console.Write("Enter You Name : ");
            string user = Console.ReadLine();

            if ((user == "Mahmoud" || user == "Sayed" || user == "Youssef") && (ev_BannedUser != null))
            {
                ev_BannedUser(this, new BannedUserEventArgs(user));
            }
            else
            {
                Console.WriteLine("Welcome to " + user);
            }
        }
    }
}
