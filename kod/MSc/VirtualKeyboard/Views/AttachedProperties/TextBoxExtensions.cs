using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace VirtualKeyboard.Views.AttachedProperties
{
    public class TextBoxExtensions
    {
        private static bool _autoScroll;
        public static readonly DependencyProperty AlwaysScrollToEndProperty = DependencyProperty.RegisterAttached("AlwaysScrollToEnd", typeof(bool), typeof(TextBoxExtensions), new PropertyMetadata(false, AlwaysScrollToEndChanged));

        private static void AlwaysScrollToEndChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is TextBox textBox))
                throw new InvalidOperationException("This property can be only used with Textbox");

            var alwaysScrollToEnd = (e.NewValue != null) && (bool)e.NewValue;
            if (alwaysScrollToEnd)
            {
                textBox.ScrollToEnd();
                textBox.TextChanged += TextChanged;
            }
            else
            {
                textBox.TextChanged -= TextChanged;
            }
        }

        private static void TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            textBox?.ScrollToEnd();
        }

        public static bool GetAlwaysScrollToEnd(TextBox textBox)
        {
            if (textBox == null) { throw new ArgumentNullException("scroll"); }
            return (bool)textBox.GetValue(AlwaysScrollToEndProperty);
        }

        public static void SetAlwaysScrollToEnd(TextBox textBox, bool alwaysScrollToEnd)
        {
            if (textBox == null) { throw new ArgumentNullException("scroll"); }
            textBox.SetValue(AlwaysScrollToEndProperty, alwaysScrollToEnd);
        }
    }
}
