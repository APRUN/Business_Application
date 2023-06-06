using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.DL
{
    class Delete_theSoftware
    {
        public static void Remove(int indx,List<Add_Software>softwares)
        {
            softwares.RemoveAt(indx);
            Console.WriteLine("Removed!!!");
            Console.ReadLine();
        }
    }
}
