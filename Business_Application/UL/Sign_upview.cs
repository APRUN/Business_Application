using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.UL
{
    static public class Sign_upview
    {
            public static user add_new_user = new user();
        public static void view()
        {
            Console.WriteLine("Enter Your Name: ");
            add_new_user.username = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            add_new_user.password = Console.ReadLine();
            Console.WriteLine("Enter Your Role: ");
            add_new_user.role = Console.ReadLine();
            
        }
    }
}
