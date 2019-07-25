using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace VirtualKeyboard.Converters
{
    public class BooleanToIntegerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterString = parameter as string;
            var parameters = parameterString?.Split('|').Select(s => System.Convert.ToInt32(s)).ToList();

            if (parameters == null || parameters.Count < 2)
                return 0; //invalid parameters
            
            return  value != null && (bool) value ? parameters[0] : parameters[1];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
