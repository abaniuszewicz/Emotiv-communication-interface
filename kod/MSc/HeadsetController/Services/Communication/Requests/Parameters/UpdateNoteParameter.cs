using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadsetController.Services.Communication.Requests.Parameters
{
    public class UpdateNoteParameter
    {
        public string Authentication { get; set; }
        public string Session { get; set; }
        public string Note { get; set; }
        public string Record { get; set; }

        public UpdateNoteParameter(string authentication, string session, string note, string record)
        {
            Authentication = authentication;
            Session = session;
            Note = note;
            Record = record;
        }
    }
}
