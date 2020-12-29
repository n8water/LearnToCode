using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Mvvm.Annotations;

namespace Mvvm.Views
{
  public partial class ChangeNotificationSample : Window
  {
    private ObservableCollection<User> users = new ObservableCollection<User>();

    public ChangeNotificationSample()
    {
      InitializeComponent();

      users.Add(new User() { Name = "John Doe" });
      users.Add(new User() { Name = "Jane Doe" });

      lbUsers.ItemsSource = users;
    }

    private void btnAddUser_Click(object sender, RoutedEventArgs e)
    {
      users.Add(new User() { Name = "New user" });
    }

    private void btnChangeUser_Click(object sender, RoutedEventArgs e)
    {
      if (lbUsers.SelectedItem != null) 
        (lbUsers.SelectedItem as User).Name = "Random Name";
    }

    private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
    {
      if (lbUsers.SelectedItem != null)
        users.Remove(lbUsers.SelectedItem as User);
    }
  }

  public class User : INotifyPropertyChanged
  {
    private string _name;

    public string Name
    {
      get => _name;
      set
      {
        if (this._name == value) return;

        _name = value;
        OnPropertyChanged(nameof(Name));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
