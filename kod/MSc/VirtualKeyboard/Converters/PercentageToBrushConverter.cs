using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace VirtualKeyboard.Converters
{
    class PercentageToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var percent = System.Convert.ToInt32(value);
            if (percent < 25)
                return Brushes.Black;
            else if (percent < 50)
                return Brushes.Red;
            else if (percent < 75)
                return Brushes.Orange;
            else
                return Brushes.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
