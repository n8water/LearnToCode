using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace XFDataBinding.ViewModels
{
  public class MainPageViewModel : BaseViewModel
  {
    string _forename;
    string _surname;

    public string Forename
    {
      get => _forename;
      set
      {
        if (_forename != value)
        {
          _forename = value;
          OnPropertyChanged("Forename");
        }
      }
    }

    public string Surname
    {
      get => _surname;
      set
      {
        if(_surname != value)
        {
          _surname = value;
          OnPropertyChanged("Surname");
        }
      }
    }
  }
}
