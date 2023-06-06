using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Business_Application.bl
{
    class write_user
    {
        public write_user(List<user>users)
        {
            string path = "C:\\Users\\OGGY\\repos\\Business_Application week5\\user_info.txt";
            StreamWriter file = new StreamWriter(path, true);
            for (int i = 0; i < users.Count; i++)
            {
                file.WriteLine(users[i].username + "," + users[i].password);
            }
            file.Flush();
            file.Close();
        }
    }
}
