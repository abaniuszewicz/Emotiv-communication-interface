using Newtonsoft.Json;

namespace HeadsetController.Services.API.Responses.BCI
{
    public class GetCurrentProfileResponse : IResult
    {
        public string name { get; }
        public bool loadedByThisApp { get; }

        [JsonConstructor]
        private GetCurrentProfileResponse(string name, bool loadedByThisApp)
        {
            this.name = name;
            this.loadedByThisApp = loadedByThisApp;
        }
    }
}