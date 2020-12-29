using System.Windows;

namespace ReUsableUserControl
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      var model = new ModelObject()
      {
        Shoesize = 12,
        Height = 34.5
      };

      this.DataContext = model;
    }
  }
}
