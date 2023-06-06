using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Application.DL
{
    class Add_feedbackList
    {
        public static void add(List<string>Feedback,string content)
        {
            Feedback.Add(content);
        }
    }
}
