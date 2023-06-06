using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.DL
{
    class Change_Software
    {
        public static void Change_name(List<Add_Software> softwares, int idx)
        {
            Console.Write("Enter new Name: ");
            string nnew = Console.ReadLine();
            softwares[idx].name = nnew;
        }
        public static void Change_size(List<Add_Software> softwares, int idx)
        {
            Console.Write("Enter new size: ");
            string nnew = Console.ReadLine();
            softwares[idx].size = nnew;
        }
        public static void Change_price(List<Add_Software> softwares, int idx)
        {
            Console.Write("Enter new Price: ");
            string nnew = Console.ReadLine();
            softwares[idx].price = nnew;
        }
    }
}
