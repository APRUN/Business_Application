using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class Update_softwaremenu_view
    {
        public static string choice;
        static public void update_view()
        {
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Size");
            Console.WriteLine("3. Price");
            choice = Console.ReadLine();          
        }
    }
}
