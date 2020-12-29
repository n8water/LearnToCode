using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.ViewModels
{
  class LittleWpfProgramViewModel
  {
    private int _buttonClicksAmount;

    //public int GetButtonClicksAmount()
    //{
    //  if (_buttonClicksAmount > 1000)
    //    return 1000;

    //  return _buttonClicksAmount;
    //}

    //public void SetButtonClicksAmount(int newAmount)
    //{
    //  if (newAmount < 0)
    //    newAmount = 0;

    //  _buttonClicksAmount = newAmount;
    //}

    public int ButtonClicksAmount
    {
      get
      {
        if (_buttonClicksAmount > 1000)
          return 1000;

        return _buttonClicksAmount;
      }
      set
      {
        if (value < 0)
          value = 0;

        _buttonClicksAmount = value;
      }
    }
  }
}
