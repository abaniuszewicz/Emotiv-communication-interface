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

        private bool _isBusy;
        private HeadsetObject _selectedHeadset;
        private string _selectedProfile;

        #endregion

        #region Properties

        public Insight Insight { get; }

        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                NotifyOfPropertyChange(() => IsBusy);
            }
        }

        public bool CanCreateSession => !string.IsNullOrWhiteSpace(Insight.ClientId)
                                  && !string.IsNullOrWhiteSpace(Insight.ClientSecret)
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
            Insight = new Insight();
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

            if (Insight.IsSessionOpen)
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

            IsBusy = false;
        }

        #endregion
    }
}
