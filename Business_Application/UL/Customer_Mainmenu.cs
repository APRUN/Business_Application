using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class Customer_Mainmenu
    {
        public static string c_choice;
        public static void View()
        {
            Console.WriteLine("0. Back.");
            Console.WriteLine("1. Add a Software to cart.");
            Console.WriteLine("2. View your Cart.");
            Console.WriteLine("3. Remove a Software from cart.");
            Console.WriteLine("4. View all Softwares.");
            Console.WriteLine("5. Enter a Feedback.");
            c_choice = Console.ReadLine();
        }
        
    }
}
