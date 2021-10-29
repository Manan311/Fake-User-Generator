using System;
using System.Globalization;
using Xamarin.Forms;
using Assignment2.Model;

namespace Assignment2.Converter
{
    public class LinkToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return "defaultUser.jpg"; // Default user image
            }
            else
            {
                return value.ToString();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}