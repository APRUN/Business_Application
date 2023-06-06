using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.DL
{
    class Add_toUsercart
    {

        public static void add(List<Add_Software>User_Cart,Add_Software add)
        {
            User_Cart.Add(add);
            Console.WriteLine("Added to your cart.");
            Console.ReadKey();
        }
    }
}
