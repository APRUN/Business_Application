using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.UL
{
    class General_Softwareview
    {
       public static void viewer(string name, string size, string price)
        {
            Console.WriteLine("Nmae: "+name);
            Console.WriteLine("Size: "+size);
            Console.WriteLine("Price: "+price);
            Console.WriteLine("\n Press any key to continue...");
            Console.ReadKey();
        }
    }
}
