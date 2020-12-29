using System.Collections.Generic;

namespace WPFFramework.viewModels
{
  public class MainWindowViewModel
  {
    private List<string> _names;
 
    public MainWindowViewModel()
    {
      InitCommands();
      SetNames();
    }

    private void InitCommands()
    {
      DoSomeThingCommand = new RelayCommand(ExecuteDoSomeThing, CanDoSomeThing);
    }

    public RelayCommand DoSomeThingCommand { get; set;}

    public List<string> Names 
      {
      get => _names;
      set => _names = value;
    }

    private void ExecuteDoSomeThing(object parameter)
    {

    }

    private bool CanDoSomeThing(object parameter)
    {
      return true;
    }


    private void SetNames()
    {
      var temp = new List<string>()
      {
        "Sabrina",
        "Franz",
        "Maria",
        "Norbert",
        "Raphael",
        "Jessica"
      };

      _names = temp;
    }
  }
}
