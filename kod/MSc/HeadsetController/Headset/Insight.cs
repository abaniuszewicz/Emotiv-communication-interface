using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadsetController.Services.API.Requests.Authentication;
using HeadsetController.Services.API.Requests.BCI;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Requests.Sessions;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Authentication;
using HeadsetController.Services.API.Responses.BCI;
using HeadsetController.Services.API.Responses.Headsets;
using HeadsetController.Services.API.Responses.Sessions;
using HeadsetController.Services.API.Utils;

namespace HeadsetController.Headset
{
    public class Insight : Headset
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string CortexToken { get; private set; }
        public HeadsetObject HeadsetObject { get; set; }
        public SessionObject SessionObject { get; private set; }

        public async Task<List<HeadsetObject>> GetAvailableHeadsets()
        {
            var headsets = SendRequest<ListResponse<HeadsetObject>>(new QueryHeadsetsRequest(new QueryHeadsetsParameter()));
            return (await headsets).result;
        }

        public async Task Authorize()
        {
            var authorizeResponse = SendRequest<AuthorizeResponse>(new AuthorizeRequest(new AuthorizeParameter(ClientId, ClientSecret)));
            CortexToken = (await authorizeResponse).result.cortexToken;
        }

        public async Task CreateSession()
        {
            if (HeadsetObject?.status != Enums.StatusHeadsetEnum.connected)
                return; //headset not connected

            var createSessionResponse = SendRequest<SessionObject>(new CreateSessionRequest(new CreateSessionParameter(CortexToken, Enums.StatusCreateEnum.open)));
            SessionObject = (await createSessionResponse).result;
        }

        public async Task<List<string>> GetAvailableProfiles()
        {
            var profiles = SendRequest<ListResponse<QueryProfileResponse>>(new QueryProfileRequest(new QueryProfileParameter(CortexToken)));
            return (await profiles).result?.Select(p => p.name).ToList() ?? new List<string>();
        }

        public async Task LoadProfile(string name)
        {
            var currentProfile = SendRequest<GetCurrentProfileResponse>(new GetCurrentProfileRequest(new GetCurrentProfileParameter(CortexToken, HeadsetObject?.id)));
            if ((await currentProfile).result?.name == name)
                return; //profile already loaded

            var allProfiles = await GetAvailableProfiles();
            if (!(allProfiles).Exists(p => p == name))
                return; //there is no profile with specified name

            //load profile
            await SendRequest<SetupProfileResponse>(new SetupProfileRequest(new SetupProfileParameter(CortexToken, Enums.StatusSetupEnum.load, name)));
        }
    }
}
