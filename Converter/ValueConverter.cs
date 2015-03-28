using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Converter
{
    public class ValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int _value;
            string valor = string.Empty;
            if (Int32.TryParse(value.ToString(), out _value))
            {
                if (_value == 1)
                    valor = "A";
                else if (_value == 2)
                    valor = "B";
                else if (_value == 3)
                    valor = "C";
       
            }
            return valor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
