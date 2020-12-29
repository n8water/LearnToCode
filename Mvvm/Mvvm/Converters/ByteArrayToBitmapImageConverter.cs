using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Mvvm.Converters
{
  public class ByteArrayToBitmapImageConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {


      if (value is byte[] imageArray)
      {
        var image = (BitmapSource)new ImageSourceConverter().ConvertFrom(imageArray);

        // Alternative to the code line above.
        //using (var ms = new MemoryStream(imageArray))
        //{
        //  var image = new BitmapImage();
        //  image.BeginInit();
        //  image.CacheOption = BitmapCacheOption.OnLoad; // here
        //  image.StreamSource = ms;
        //  image.EndInit();

        return image;
      }

      return null;
    }

    //return DependencyProperty.UnsetValue;
  

  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
  {
    throw new NotImplementedException();
  }
}
}
