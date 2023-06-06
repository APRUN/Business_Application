using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;
using Business_Application.UL;

namespace Business_Application.DL
{
    class Add_SoftwaretoList
    {
        public static void Addin(List<Add_Software>softwares)
        {
            softwares.Add(Add_Softwareview.add);
        }
    }
}
