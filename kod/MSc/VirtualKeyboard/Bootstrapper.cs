﻿using System.Windows;
using Caliburn.Micro;
using VirtualKeyboard.ViewModels;

namespace VirtualKeyboard
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
