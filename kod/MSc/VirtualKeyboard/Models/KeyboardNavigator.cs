using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using HeadsetController.Headset;

namespace VirtualKeyboard.Models
{
    public class KeyboardNavigator
    {
        #region Fields

        private readonly DispatcherTimer _upTimer = new DispatcherTimer();
        private readonly DispatcherTimer _downTimer = new DispatcherTimer();
        private readonly DispatcherTimer _rightTimer = new DispatcherTimer();
        private readonly DispatcherTimer _leftTimer = new DispatcherTimer();
        private readonly DispatcherTimer _selectTimer = new DispatcherTimer();

        #endregion

        #region Events

        public event Action OnUpCommand;
        public event Action OnDownCommand;
        public event Action OnRightCommand;
        public event Action OnLeftCommand;
        public event Action OnSelectCommand;

        #endregion

        #region Properties

        public Insight Insight { get; }
        public Settings Settings { get; }

        #endregion

        #region Constructor

        public KeyboardNavigator(Insight insight, Settings settings)
        {
            Insight = insight;
            Settings = settings;

            Insight.PropertyChanged += Insight_PropertyChanged;
            Settings.PropertyChanged += Settings_PropertyChanged;

            _upTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _upTimer.Tick += _upTimer_Tick;
            _downTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _downTimer.Tick += _downTimer_Tick;
            _rightTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _rightTimer.Tick += _rightTimer_Tick;
            _leftTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _leftTimer.Tick += _leftTimer_Tick;
            _selectTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _selectTimer.Tick += _selectTimer_Tick;
        }

        #endregion

        #region Methods

        private void Insight_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "PushLevel" && Insight.PushLevel >= Settings.UpThreshold)
                _upTimer.Start();
            else if (e.PropertyName == "PushLevel")
                _upTimer.Stop();
            else if (e.PropertyName == "PullLevel" && Insight.PullLevel >= Settings.DownThreshold)
                _downTimer.Start();
            else if (e.PropertyName == "PullLevel")
                _downTimer.Stop();
            else if (e.PropertyName == "RightLevel" && Insight.RightLevel >= Settings.RightThreshold)
                _rightTimer.Start();
            else if (e.PropertyName == "RightLevel")
                _rightTimer.Stop();
            else if (e.PropertyName == "LeftLevel" && Insight.LeftLevel >= Settings.LeftThreshold)
                _leftTimer.Start();
            else if (e.PropertyName == "LeftLevel")
                _leftTimer.Stop();
            else if (e.PropertyName == "BlinkLevel" && Insight.BlinkLevel >= Settings.SelectThreshold)
                _selectTimer.Start();
            else if (e.PropertyName == "BlinkLevel")
                _selectTimer.Stop();
        }

        private void Settings_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "FocusTime")
                return;

            _upTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _downTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _rightTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
            _leftTimer.Interval = TimeSpan.FromMilliseconds(Settings.FocusTime);
        }

        private void _upTimer_Tick(object sender, EventArgs e) => OnUpCommand?.Invoke();
        private void _downTimer_Tick(object sender, EventArgs e) => OnDownCommand?.Invoke();
        private void _leftTimer_Tick(object sender, EventArgs e) => OnLeftCommand?.Invoke();
        private void _rightTimer_Tick(object sender, EventArgs e) => OnRightCommand?.Invoke();
        private void _selectTimer_Tick(object sender, EventArgs e) => Select(null);
        public void Select(RoutedEventArgs args)
        {
            if (args != null)
                args.Handled = true;
            OnSelectCommand?.Invoke();
        }

        #endregion
    }
}
