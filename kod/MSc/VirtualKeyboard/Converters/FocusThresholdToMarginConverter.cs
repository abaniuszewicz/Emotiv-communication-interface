using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace VirtualKeyboard.Converters
{
    public class FocusThresholdToMarginConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var minMargin = 1;
            var maxMargin = 97;

            var threshold = System.Convert.ToDouble(value);
            var margin = threshold * (maxMargin - minMargin) + minMargin;
            return new Thickness(margin, 0, 0, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
