using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class UpdateNoteRequest : Request
    {
        public override string Method { get; } = "updateNote";
        [JsonProperty("params")]
        public UpdateNoteParameter Parameter { get; }

        public UpdateNoteRequest(int id, UpdateNoteParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
