using Franz.viewModels;
using System.Windows;

namespace Franz.views
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      Model = new MainWindowViewModel(new models.MyData());

      DataContext = Model;
    }

    public MainWindowViewModel Model;
    
  }
}
