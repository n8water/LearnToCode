using System.Windows;
using System.Windows.Controls;

namespace WPFFramework
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    { 
      InitializeComponent();
    }

    private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {      
      var temp = sender as ListBox;
     
      var result = temp.SelectedValue;
    }
  }
}
