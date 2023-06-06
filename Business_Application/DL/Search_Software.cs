using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Application.bl;

namespace Business_Application.DL
{
    class Search_Software
    {
        public static int searchnreturn(List<Add_Software> softwares, string name)
        {
            for (int i = 0; i < softwares.Count; i++)
            {
                if (name == softwares[i].name)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
