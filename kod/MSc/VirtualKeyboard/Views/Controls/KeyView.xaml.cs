using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace VirtualKeyboard.Views.Controls
{
    /// <summary>
    /// Interaction logic for KeyView.xaml
    /// </summary>
    public partial class KeyView : UserControl, IKey
    {
        public static readonly DependencyProperty KeyProperty = DependencyProperty.Register("Key", typeof(string), typeof(KeyView), new PropertyMetadata());

        public static readonly DependencyProperty IsSelectedProperty = DependencyProperty.Register("IsSelected", typeof(bool), typeof(KeyView), new PropertyMetadata());

        public event EventHandler Pressed;

        public string Key
        {
            get => (string) GetValue(KeyProperty);
            set => SetValue(KeyProperty, value);
        }

        public bool IsSelected
        {
            get => (bool) GetValue(IsSelectedProperty);
            set => SetValue(IsSelectedProperty, value);
        }

        public KeyView()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) => Pressed?.Invoke(this, e);
        public void InvokePressed() => Pressed?.Invoke(this, EventArgs.Empty);

        public void MoveFocus(FocusNavigationDirection direction) => Button?.MoveFocus(new TraversalRequest(direction));

        private void Button_OnGotFocus(object sender, RoutedEventArgs e)
        {
            IsSelected = true;
        }
    }
}
