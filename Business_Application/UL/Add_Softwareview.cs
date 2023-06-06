using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.UL
{
    public class Add_Softwareview
    {
           public static Add_Software add = new Add_Software();
        static public void add_view()
        {
            Console.Write("Enter Software name: ");
            add.name = Console.ReadLine();
            Console.Write("Enter Software Size(Write MB/GB): ");
            add.size = Console.ReadLine();
            Console.Write("Enter the price in Dollars($): ");
            add.price = Console.ReadLine();
        }
    }
}
