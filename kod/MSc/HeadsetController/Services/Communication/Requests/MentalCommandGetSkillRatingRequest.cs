using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeadsetController.Services.Communication.Requests.Parameters;
using Newtonsoft.Json;

namespace HeadsetController.Services.Communication.Requests
{
    public class MentalCommandGetSkillRatingRequest : Request
    {
        public override string Method { get; } = "mentalCommandGetSkillRating";
        [JsonProperty("params")]
        public MentalCommandGetSkillRatingParameter Parameter { get; }

        public MentalCommandGetSkillRatingRequest(int id, MentalCommandGetSkillRatingParameter parameter) : base(id)
        {
            Parameter = parameter;
        }
    }
}
