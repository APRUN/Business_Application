using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Business_Application.bl
{
    class Write_software_tofile
    {
        public Write_software_tofile(List<Add_Software> softwares)
        {
            string path = "C:\\Users\\OGGY\\repos\\Business_Application week5\\Softwares.txt";
            StreamWriter file = new StreamWriter(path, true);
            for (int i = 0; i < softwares.Count; i++)
            {
                file.WriteLine(softwares[i].name + "," + softwares[i].size+"," + softwares[i].price);
            }
            file.Flush();
            file.Close();
        }
    }
}
