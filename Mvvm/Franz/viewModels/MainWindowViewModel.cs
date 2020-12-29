
using Franz.models;
using System.Collections.Generic;

namespace Franz.viewModels
{
  public class MainWindowViewModel
  {
    private MyData _myData;    
    public MainWindowViewModel(MyData myData)
    {
      _myData = myData;
    }
    public List<string> Names => _myData.Names;
  }
}
