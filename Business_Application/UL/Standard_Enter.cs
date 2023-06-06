using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class Standard_Enter
    {
        public static string view_it()
        {
            string choice;
            Console.Write("Enter: ");
            choice=Console.ReadLine();
            return choice;
        }
    }
}
