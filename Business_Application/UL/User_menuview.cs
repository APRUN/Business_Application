using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class User_menuview
    {
        public static string choice;
        public static void user_view()
        {
            Console.WriteLine("0. Back.");
            Console.WriteLine("1. Add a Software.");
            Console.WriteLine("2. Remove a Software.");
            Console.WriteLine("3. Update a Software Info.");
            Console.WriteLine("4. View all Softwares.");
            choice = Console.ReadLine();
           
        }
    }
}
