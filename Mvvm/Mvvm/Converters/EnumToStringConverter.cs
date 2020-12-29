using Mvvm.Enums;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Mvvm.Converters
{
  public class EnumToStringConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is ImageVisibility visibility)
      {
        return visibility.ToString();
      }

      return string.Empty;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
