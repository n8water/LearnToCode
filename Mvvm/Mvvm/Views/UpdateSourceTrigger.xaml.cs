using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Mvvm.Views
{
  /// <summary>
  /// Interaction logic for UpdateSourceTrigger.xaml
  /// </summary>
  public partial class UpdateSourceTrigger : Window
  {
    public UpdateSourceTrigger()
    {
      InitializeComponent();
      this.DataContext = this;
    }

    private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
    {
      BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
      binding.UpdateSource();
    }
  }
}
