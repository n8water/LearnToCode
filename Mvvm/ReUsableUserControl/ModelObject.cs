using ReUsableUserControl.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ReUsableUserControl
{
  public class ModelObject : INotifyPropertyChanged
  {
    private int _shoesize;
    private double _height;

    public event PropertyChangedEventHandler PropertyChanged;

    public int Shoesize
    {
      get { return _shoesize;}
      set
      {
        _shoesize = value;
        OnPropertyChanged(nameof(Shoesize));
      }
    }
    public double Height
    {
      get { return _height; }
      set
      {
        _height = value;
        OnPropertyChanged(nameof(Height));
      }
    }


    [NotifyPropertyChangedInvocator]
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
