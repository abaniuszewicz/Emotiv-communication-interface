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

namespace VirtualKeyboard.ViewModels
{
    public class SettingsViewModel : PropertyChangedBase
    {
        #region Fields

        private string _clientId = "BQhJjFmrJVcWqLmyU9XCIKmNdUOMrTG1eo9RNYwu";
        private string _clientSecret = "fCp33VZDrAj8zduFjJJvYWBaePAupZyBqzszdQfG9DlVPiVX87xPRkQDuPXNc7QAef2d1sJi6rMbO5SeoM14RYoP6uJRMxigk2dirdIduDg98EIKifOcmDqA6RfX5pNs";
        private bool _isBusy;
        private HeadsetObject _selectedHeadset;
        private string _selectedProfile;

        #endregion

        #region Properties

        public static Insight Insight { get; private set; }

        public string ClientId
        {
            get => _clientId;
            set
            {
                _clientId = value;
                Insight.ClientId = ClientId;
                NotifyOfPropertyChange(() => ClientId);
                NotifyOfPropertyChange(() => CanConnect);
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
                NotifyOfPropertyChange(() => CanConnect);
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

        public bool CanConnect => !string.IsNullOrWhiteSpace(ClientId)
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
                NotifyOfPropertyChange(() => CanConnect);
            }
        }

        public string SelectedProfile
        {
            get => _selectedProfile;
            set
            {
                _selectedProfile = value;
                NotifyOfPropertyChange(() => SelectedProfile);
                NotifyOfPropertyChange(() => CanConnect);
            }
        }

        public ObservableCollection<HeadsetObject> Headsets { get; } = new ObservableCollection<HeadsetObject>();
        public ObservableCollection<string> Profiles { get; } = new ObservableCollection<string>();

        #endregion

        #region Constructor

        public SettingsViewModel()
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

        public async void RefreshHeadsets()
        {
            IsBusy = true;

            await Task.Run(async () =>
            {
                var headsets = await Insight.GetAvailableHeadsets();
                
                Headsets.Clear();
                foreach (var headset in headsets)
                    Headsets.Add(headset);
            });
            NotifyOfPropertyChange(() => Headsets);
            IsBusy = false;
        }

        public async void RefreshProfiles()
        {
            IsBusy = true;

            await Task.Run(async () =>
            {
                await Insight.Authorize();
                var profiles = await Insight.GetAvailableProfiles();

                Profiles.Clear();
                foreach (var profile in profiles)
                    Profiles.Add(profile);
            });
            NotifyOfPropertyChange(() => Profiles);
            IsBusy = false;
        }

        public async void Connect()
        {
            IsBusy = true;

            await Task.Run(async () =>
            {
                await Insight.CreateSession();
                await Insight.LoadProfile(SelectedProfile);
            });

            IsBusy = false;
        }

        #endregion
    }
}
