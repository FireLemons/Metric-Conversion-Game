using System;
using System.Globalization;
using System.Windows.Data;

namespace ToMetric.BindingConversionClasses
{
    class DoubleToPercentageText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((double)value).ToString("0.##");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
