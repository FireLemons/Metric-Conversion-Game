using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ToMetric.BindingConversionClasses
{
    class CorrectnessToFeedbackColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? wasRight = (bool?)value;
            
            if (wasRight == null)
            {
                return new SolidColorBrush(Colors.White);
            }
            else if (wasRight.Value == true)
            {
                return (SolidColorBrush)(new BrushConverter().ConvertFrom("#4caf50"));
            }
            else if (wasRight.Value == false)
            {
                return (SolidColorBrush)(new BrushConverter().ConvertFrom("#b71c1c"));
            }
            else
            {
                return new SolidColorBrush(Colors.White);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
