using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ToMetric.BindingConversionClasses
{
    class IsGameToElementVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter.ToString() == "Options")
            {
                return !(bool)value ? Visibility.Visible : Visibility.Collapsed;
            }
            else if(parameter.ToString() == "Game")
            {
                return (bool)value ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                throw new ArgumentException("Unexpected Conversion Parameter");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {   
            throw new NotImplementedException();
        }
    }
}
