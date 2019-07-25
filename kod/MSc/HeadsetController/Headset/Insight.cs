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
        public string ClientId { get; } = "BQhJjFmrJVcWqLmyU9XCIKmNdUOMrTG1eo9RNYwu";
        public string ClientSecret { get; } = "fCp33VZDrAj8zduFjJJvYWBaePAupZyBqzszdQfG9DlVPiVX87xPRkQDuPXNc7QAef2d1sJi6rMbO5SeoM14RYoP6uJRMxigk2dirdIduDg98EIKifOcmDqA6RfX5pNs";
        public string CortexToken { get; private set; }
        public HeadsetObject HeadsetObject { get; private set; }
        public SessionObject SessionObject { get; private set; }

        public async Task Initialize()
        {
            var authorizeResponse = SendRequest<AuthorizeResponse>(new AuthorizeRequest(new AuthorizeParameter(ClientId, ClientSecret)));
            var headsets = SendRequest<ListResponse<HeadsetObject>>(new QueryHeadsetsRequest(new QueryHeadsetsParameter()));

            CortexToken = (await authorizeResponse).result.cortexToken;
            HeadsetObject = (await headsets).result.FirstOrDefault();
        }

        public async Task CreateSession()
        {
            if (HeadsetObject?.status != Enums.StatusHeadsetEnum.connected)
                return; //no connected headset

            var createSessionResponse = SendRequest<SessionObject>(new CreateSessionRequest(new CreateSessionParameter(CortexToken, Enums.StatusCreateEnum.open)));
            SessionObject = (await createSessionResponse).result;
        }

        public async Task LoadProfile(string name)
        {
            var currentProfile = SendRequest<GetCurrentProfileResponse>(new GetCurrentProfileRequest(new GetCurrentProfileParameter(CortexToken, HeadsetObject?.id)));
            if ((await currentProfile).result.name == name)
                return; //profile already loaded

            var allProfiles = SendRequest<ListResponse<QueryProfileResponse>>(new QueryProfileRequest(new QueryProfileParameter(CortexToken)));
            if (!(await allProfiles).result.Exists(p => p.name == name))
                return; //there is no profile with specified name

            //load profile
            await SendRequest<SetupProfileResponse>(new SetupProfileRequest(new SetupProfileParameter(CortexToken, Enums.StatusSetupEnum.load, name)));
        }
    }
}
