using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.DL
{
    class All_softwares
    {
        public All_softwares(List<Add_Software> softwares)
        {
            Console.WriteLine("Name   \tSize\tPrice");
            for (int q = 0; q < softwares.Count; q++)
            {
                Console.WriteLine(softwares[q].name + "\t" + softwares[q].size + "\t" + softwares[q].price);
            }
                Console.ReadKey();
        }
    }
}
