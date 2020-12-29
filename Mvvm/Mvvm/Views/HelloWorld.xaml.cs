using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Mvvm.Views
{
  /// <summary>
  /// Interaction logic for HelloWorld.xaml
  /// </summary>
  public partial class HelloWorld : Window
  {
    public HelloWorld()
    {
      InitializeComponent();
      
      //DataBinding in Code - behind
      Binding binding = new Binding("Text");
      binding.Source = txtValue;
      TextBlockValue.SetBinding(TextBlock.TextProperty, binding);
    }
  }
}
