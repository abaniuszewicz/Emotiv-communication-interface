﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Caliburn.Micro;

namespace VirtualKeyboard.ViewModels
{
    public class MainViewModel : PropertyChangedBase
    {
        private bool _isDrawerOpen;

        public ObservableCollection<PropertyChangedBase> Views { get; } = new ObservableCollection<PropertyChangedBase>();

        public ConnectionViewModel ConnectionViewModel { get; } = new ConnectionViewModel();
        public SettingsViewModel SettingsViewModel { get; } = new SettingsViewModel();

        public bool IsDrawerOpen
        {
            get => _isDrawerOpen;
            set
            {
                _isDrawerOpen = value;
                NotifyOfPropertyChange(() => IsDrawerOpen);
            }
        }

        public void CloseDrawer()
        {
            IsDrawerOpen = false;
        }

        public MainViewModel()
        {
            Views.Add(new KeyboardViewModel(SettingsViewModel, ConnectionViewModel));
            Views.Add(new MessengerViewModel(ConnectionViewModel.Insight));
        }
    }
}
