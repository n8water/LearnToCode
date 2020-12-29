using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mvvm.Annotations;

namespace Mvvm.ViewModels
{
  public class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
    {
      if (Equals(storage, value))
      {
        return;
      }

      storage = value;
      OnPropertyChanged(propertyName);
    }

    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
