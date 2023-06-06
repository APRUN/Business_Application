using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class Add_softwarename
    {
        public static string name;
        public static string lets_show()
        {
            Console.Write("Enter Software name: ");
            name = Console.ReadLine();
            return name;
        }
    }
}
