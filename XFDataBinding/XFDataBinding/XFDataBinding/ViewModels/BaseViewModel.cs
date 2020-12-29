using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XFDataBinding.ViewModels
{
  public class BaseViewModel : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged (string propertyName)
    {
      var changed = PropertyChanged;
      if(changed != null)
        PropertyChanged (this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
