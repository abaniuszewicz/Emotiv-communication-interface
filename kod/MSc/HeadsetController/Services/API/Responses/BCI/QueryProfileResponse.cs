using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.BCI
{
    public class QueryProfileResponse : IResult
    {
        public string name { get; } //TODO

        [JsonConstructor]
        private QueryProfileResponse(string name)
        {
            this.name = name;
        }
    }
}
