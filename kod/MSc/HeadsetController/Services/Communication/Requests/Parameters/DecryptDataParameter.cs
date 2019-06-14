using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class DecryptDataParameter
    {
        public string Authentication { get; set; }
        public string FolderPath { get; set; }
        public string OutputPath { get; set; }
        public string License { get; set; }

        public DecryptDataParameter(string authentication, string folderPath)
        {
            Authentication = authentication;
            FolderPath = folderPath;
        }
    }
}
