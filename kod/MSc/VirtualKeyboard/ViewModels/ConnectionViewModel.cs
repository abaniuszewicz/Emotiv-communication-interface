using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Navigation;
using Caliburn.Micro;
using HeadsetController.Headset;
using HeadsetController.Services.API.Requests.Headsets;
using HeadsetController.Services.API.Responses;
using HeadsetController.Services.API.Responses.Headsets;
using HeadsetController.Services.API.Utils;

namespace VirtualKeyboard.ViewModels
{
    public class ConnectionViewModel : PropertyChangedBase
    {
        #region Fields

        private string _clientId = "BQhJjFmrJVcWqLmyU9XCIKmNdUOMrTG1eo9RNYwu";
        private string _clientSecret = "fCp33VZDrAj8zduFjJJvYWBaePAupZyBqzszdQfG9DlVPiVX87xPRkQDuPXNc7QAef2d1sJi6rMbO5SeoM14RYoP6uJRMxigk2dirdIduDg98EIKifOcmDqA6RfX5pNs";
        private bool _isBusy;
        private bool _isSessionOpen;
        private HeadsetObject _selectedHeadset;
        private string _selectedProfile;

        #endregion

        #region Properties

        public Insight Insight { get; }

        public string ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value;
                Insight.ClientId = ClientId;
                NotifyOfPropertyChange(() => ClientId);
                NotifyOfPropertyChange(() => CanCreateSession);
            }
        }

        public string ClientSecret
        {
            get => _clientSecret;
            set
            {
                _clientSecret = value;
                Insight.ClientSecret = ClientSecret;
                NotifyOfPropertyChange(() => ClientSecret);
                NotifyOfPropertyChange(() => CanCreateSession);
            }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                NotifyOfPropertyChange(() => IsBusy);
            }
        }

        public bool IsSessionOpen
        {
            get => _isSessionOpen;
            set
            {
                _isSessionOpen = value;
                NotifyOfPropertyChange(() => IsSessionOpen);
            }
        }

        public bool CanCreateSession => !string.IsNullOrWhiteSpace(ClientId)
                                  && !string.IsNullOrWhiteSpace(ClientSecret)
                                  && SelectedHeadset != null
                                  && !string.IsNullOrWhiteSpace(SelectedProfile);

        public HeadsetObject SelectedHeadset
        {
            get => _selectedHeadset;
            set
            {
                _selectedHeadset = value;
                Insight.HeadsetObject = SelectedHeadset;
                NotifyOfPropertyChange(() => SelectedHeadset);
                NotifyOfPropertyChange(() => CanCreateSession);
            }
        }

        public string SelectedProfile
        {
            get => _selectedProfile;
            set
            {
                _selectedProfile = value;
                NotifyOfPropertyChange(() => SelectedProfile);
                NotifyOfPropertyChange(() => CanCreateSession);
            }
        }

        public ObservableCollection<HeadsetObject> Headsets { get; } = new ObservableCollection<HeadsetObject>();
        public ObservableCollection<string> Profiles { get; } = new ObservableCollection<string>();

        #endregion

        #region Constructor

        public ConnectionViewModel()
        {
            BindingOperations.EnableCollectionSynchronization(Headsets, new object());
            BindingOperations.EnableCollectionSynchronization(Profiles, new object());
            Insight = new Insight()
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret
            };
        }

        #endregion

        #region Methods

        public async void RefreshInsight()
        {
            IsBusy = true;
            await Task.Run(async () =>
            {
                await Insight.Authorize();
                var headsets = Insight.GetAvailableHeadsets();
                var profiles = Insight.GetAvailableProfiles();

                Headsets.Clear();
                Profiles.Clear();
                NotifyOfPropertyChange(() => Headsets);
                NotifyOfPropertyChange(() => Profiles);

                await Task.WhenAll(headsets, profiles);

                foreach (var headset in headsets.Result)
                    Headsets.Add(headset);

                foreach (var profile in profiles.Result)
                    Profiles.Add(profile);
            });
            NotifyOfPropertyChange(() => Headsets);
            NotifyOfPropertyChange(() => Profiles);

            IsBusy = false;
        }

        public async void ChangeSessionStatus()
        {
            IsBusy = true;

            if (IsSessionOpen)
                await Task.Run(async () =>
                {
                    await Insight.CloseSession(); //close session
                });
            else
                await Task.Run(async () =>
                {
                    await Insight.CreateSession(); //open session
                    await Insight.LoadProfile(SelectedProfile);
                });

            IsSessionOpen = Insight.SessionObject?.status == Enums.StatusSessionEnum.opened;
            IsBusy = false;
        }

        #endregion
    }
}
