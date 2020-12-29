using System;
using System.Windows.Input;

namespace Mvvm
{
  public class MyCommand : ICommand
  {
    private readonly Action<object> _executeAction;
    private readonly Func<object, bool> _canExecuteAction;

    public event EventHandler CanExecuteChanged;

    public MyCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
    {
      _executeAction = executeAction;
      _canExecuteAction = canExecuteAction ;
    }

    /// <summary>
    /// Check if can create instance of RelayCommand without CanExecute
    /// </summary>
    /// <param name="executeAction"></param>
    public MyCommand(Action<object> executeAction)
    {
      _executeAction = executeAction;
      _canExecuteAction = CanExecuteAction;
    }

    private bool CanExecuteAction(object parameter)
    {
      return true;
    }

    public void RaiseCanExecute()
    {
      CanExecute(null);
      CanExecuteChanged?.Invoke(this,EventArgs.Empty);
    }

    /// <summary>
    /// Checks Execution of command within the ViewModel
    /// </summary>
    /// <returns></returns>
    public bool CanExecute()
    {
      return _canExecuteAction.Invoke(null);
    }

    public bool CanExecute(object parameter)
    {
      return _canExecuteAction.Invoke(parameter);
    }

    /// <summary>
    /// Executes command without parameter
    /// </summary>
    public void Execute()
    {
      _executeAction?.Invoke(null);
    }

    public void Execute(object parameter)
    {
      _executeAction?.Invoke(parameter);
    }
  }
}
