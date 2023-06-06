using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class Sign_inview
    {
        static public string user;
        static public string passcode;
        public static void view()
        {
            Console.WriteLine("Enter Your Name: ");
            user = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            passcode = Console.ReadLine();
        }
    }
}
