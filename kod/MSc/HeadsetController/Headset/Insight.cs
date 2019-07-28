using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeadsetController.Services.API.Requests.Authentication;
using HeadsetController.Services.API.Requests.BCI;
using HeadsetController.Services.API.Requests.DataSubscription;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Requests.Sessions;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Authentication;
using HeadsetController.Services.API.Responses.BCI;
using HeadsetController.Services.API.Responses.DataSubscriptions;
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
            if (HeadsetObject == null)
                return; //headset not detected

            if (HeadsetObject.status != Enums.StatusHeadsetEnum.connected)
            {
                await SendRequest<ControlDeviceResponse>(new ControlDeviceRequest(new ControlDeviceParameter(Enums.CommandEnum.connect) { headset = HeadsetObject.id }));
                HeadsetObject = (await SendRequest<ListResponse<HeadsetObject>>(new QueryHeadsetsRequest(new QueryHeadsetsParameter() { id = HeadsetObject.id }))).result.FirstOrDefault();
            }

            var createSessionResponse = SendRequest<SessionObject>(new CreateSessionRequest(new CreateSessionParameter(CortexToken, Enums.StatusCreateEnum.open)));
            SessionObject = (await createSessionResponse).result;
        }

        public async Task CloseSession()
        {
            if (HeadsetObject?.status != Enums.StatusHeadsetEnum.connected || SessionObject?.status != Enums.StatusSessionEnum.opened)
                return; //headset not connected or session already closed

            var updateSessionResponse = SendRequest<SessionObject>(new UpdateSessionRequest(new UpdateSessionParameter(CortexToken, SessionObject.id, Enums.StatusUpdateEnum.close)));
            SessionObject = (await updateSessionResponse).result;
        }

        public async Task<List<string>> GetAvailableProfiles()
        {
            var profiles = SendRequest<ListResponse<QueryProfileResponse>>(new QueryProfileRequest(new QueryProfileParameter(CortexToken)));
            return (await profiles).result?.Select(p => p.name).ToList() ?? new List<string>();
        }

        public async void Subscribe(IEnumerable<Enums.StreamsEnum> streams)
        {
            await SendRequest<SubscribeResponse>(new SubscribeRequest(new SubscribeParameter(CortexToken, SessionObject?.id, streams)));
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
