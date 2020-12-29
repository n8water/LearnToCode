
using System;
using System.Windows.Input;

namespace WPFFramework
{
  public class RelayCommand : ICommand
  {
    private Action<object> _executeAction;
    private Func<object, bool> _canExecute;

    public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute)
    {
      _executeAction = executeAction;
      _canExecute = canExecute;
    }

    public event EventHandler CanExecuteChanged;

    public void RaiseCanExecute()
    {
      CanExecute(null);
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    public bool CanExecute(object parameter)
    {
      return _canExecute.Invoke(parameter);
    }

    public void Execute(object parameter)
    {
      _executeAction?.Invoke(parameter);
    }
  }
}
