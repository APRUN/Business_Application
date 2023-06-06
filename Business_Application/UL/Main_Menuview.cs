using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    static public class Main_Menuview
    {
        static public string choice;
        public static string Main_view()
        {
            Console.WriteLine("0. Exit.");
            Console.WriteLine("1. Sign Up.");
            Console.WriteLine("2. Sign In");
            Console.WriteLine("3. Exit");
            choice = Console.ReadLine();
            return choice;
        }
        
    }
}
