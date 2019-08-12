using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using HeadsetController.Annotations;
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
    public class Insight : Headset, INotifyPropertyChanged
    {
        #region Fields

        private string _clientId = "BQhJjFmrJVcWqLmyU9XCIKmNdUOMrTG1eo9RNYwu";
        private string _clientSecret = "fCp33VZDrAj8zduFjJJvYWBaePAupZyBqzszdQfG9DlVPiVX87xPRkQDuPXNc7QAef2d1sJi6rMbO5SeoM14RYoP6uJRMxigk2dirdIduDg98EIKifOcmDqA6RfX5pNs";
        private int _batteryLevel;
        private int _wirelessSignalLevel;
        private int _af3Quality, af4Quality, t7Quality, t8Quality, pzQuality;
        private double _pushLevel, _pullLevel, _leftLevel, _rightLevel;
        private double _blinkLevel;

        #endregion

        #region Properties

        public string ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value; 
                OnPropertyChanged(nameof(ClientId));
            }
        }

        public string ClientSecret
        {
            get => _clientSecret;
            set
            {
                _clientSecret = value; 
                OnPropertyChanged(nameof(ClientSecret));
            }
        }

        public string CortexToken { get; private set; }
        public HeadsetObject HeadsetObject { get; set; }
        public SessionObject SessionObject { get; private set; }

        public bool IsSessionOpen => SessionObject?.status == Enums.StatusSessionEnum.opened;
        public string CurrentProfile { get; set; }

        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                _batteryLevel = value;
                OnPropertyChanged(nameof(BatteryLevel));
            }
        }

        public int WirelessSignalLevel
        {
            get => _wirelessSignalLevel;
            set
            {
                _wirelessSignalLevel = value;
                OnPropertyChanged(nameof(WirelessSignalLevel));
            }
        }

        public int Af3Quality
        {
            get => _af3Quality;
            set
            {
                _af3Quality = value;
                OnPropertyChanged(nameof(Af3Quality));
            }
        }

        public int Af4Quality
        {
            get => af4Quality;
            set
            {
                af4Quality = value;
                OnPropertyChanged(nameof(Af4Quality));
            }
        }

        public int T7Quality
        {
            get => t7Quality;
            set
            {
                t7Quality = value;
                OnPropertyChanged(nameof(T7Quality));
            }
        }

        public int T8Quality
        {
            get => t8Quality;
            set
            {
                t8Quality = value;
                OnPropertyChanged(nameof(T8Quality));
            }
        }

        public int PzQuality
        {
            get => pzQuality;
            set
            {
                pzQuality = value;
                OnPropertyChanged(nameof(PzQuality));
            }
        }

        public double PushLevel
        {
            get => _pushLevel;
            set
            {
                _pushLevel = value;
                OnPropertyChanged(nameof(PushLevel));
            }
        }

        public double PullLevel
        {
            get => _pullLevel;
            set
            {
                _pullLevel = value;
                OnPropertyChanged(nameof(PullLevel));
            }
        }

        public double LeftLevel
        {
            get => _leftLevel;
            set
            {
                _leftLevel = value;
                OnPropertyChanged(nameof(LeftLevel));
            }
        }

        public double RightLevel
        {
            get => _rightLevel;
            set
            {
                _rightLevel = value;
                OnPropertyChanged(nameof(RightLevel));
            }
        }

        public double BlinkLevel
        {
            get => _blinkLevel;
            set
            {
                _blinkLevel = value;
                OnPropertyChanged(nameof(BlinkLevel));
            }
        }

        #endregion

        #region Constructor

        public Insight()
        {
            OnDeviceInformationUpdate += Insight_OnDeviceInformationUpdate;
            OnMentalCommandUpdate += Insight_OnMentalCommandUpdate;
        }

        #endregion

        #region Methods

        private void Insight_OnMentalCommandUpdate(ComDataSampleObject com)
        {
            //throw new NotImplementedException();
        }

        private void Insight_OnDeviceInformationUpdate(DevDataSampleObject dev)
        {
            var list = dev.dev.ToList();
            BatteryLevel = Convert.ToInt32(list[0]) * 25; //to get percentage result
            WirelessSignalLevel = Convert.ToInt32(list[1]);

            if (!(list[2] is List<int> contactQuality) || contactQuality.Count < 5)
                return; //corrupted data

            //possible values: 0-4, multiply *25 to get 0-100 (percentage)
            Af3Quality= contactQuality[0] * 25;
            T7Quality = contactQuality[1] * 25;
            PzQuality = contactQuality[2] * 25;
            T8Quality = contactQuality[3] * 25;
            Af4Quality = contactQuality[4] * 25;
        }

        public async Task<List<HeadsetObject>> GetAvailableHeadsets()
        {
            var headsets = SendRequest<ListResponse<HeadsetObject>>(new QueryHeadsetsRequest(new QueryHeadsetsParameter()));
            return (await headsets).result;
        }

        public async Task Authorize()
        {
            var authorizeResponse = SendRequest<AuthorizeResponse>(new AuthorizeRequest(new AuthorizeParameter(ClientId, ClientSecret)));
            CortexToken = (await authorizeResponse).result?.cortexToken;
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
            Subscribe(new List<Enums.StreamsEnum>() { Enums.StreamsEnum.dev, Enums.StreamsEnum.com, Enums.StreamsEnum.fac });
            OnPropertyChanged(nameof(IsSessionOpen));
        }

        public async Task CloseSession()
        {
            if (HeadsetObject?.status != Enums.StatusHeadsetEnum.connected || SessionObject?.status != Enums.StatusSessionEnum.opened)
                return; //headset not connected or session already closed

            var updateSessionResponse = SendRequest<SessionObject>(new UpdateSessionRequest(new UpdateSessionParameter(CortexToken, SessionObject.id, Enums.StatusUpdateEnum.close)));
            SessionObject = (await updateSessionResponse).result;
            OnPropertyChanged(nameof(IsSessionOpen));
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
            if (string.IsNullOrWhiteSpace(CurrentProfile))
            {
                CurrentProfile = (await SendRequest<GetCurrentProfileResponse>(new GetCurrentProfileRequest(new GetCurrentProfileParameter(CortexToken, HeadsetObject?.id)))).result.name;
                OnPropertyChanged(nameof(CurrentProfile));
            }

            if (CurrentProfile == name)
                return; //profile already loaded

            var allProfiles = await GetAvailableProfiles();
            if (!(allProfiles).Exists(p => p == name))
                return; //there is no profile with specified name

            //load profile
            await SendRequest<SetupProfileResponse>(new SetupProfileRequest(new SetupProfileParameter(CortexToken, Enums.StatusSetupEnum.load, name)));
            //update profile name
            CurrentProfile = (await SendRequest<GetCurrentProfileResponse>(new GetCurrentProfileRequest(new GetCurrentProfileParameter(CortexToken, HeadsetObject?.id)))).result.name;
            OnPropertyChanged(nameof(CurrentProfile));
        }

        #endregion

        #region PropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
