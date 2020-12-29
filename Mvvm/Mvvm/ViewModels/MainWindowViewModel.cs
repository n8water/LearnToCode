using Mvvm.Enums;
using System.IO;

namespace Mvvm.ViewModels
{
  public class MainWindowViewModel : BaseViewModel
  {
    private bool _isCheckBoxChecked;
    private ImageVisibility _pictureVisibility = ImageVisibility.Collapsed;
    private string _text = "Hallo!";
    private string _visibilityButtonText = showPicture;
    private byte[] _picture2;
    //private bool _isLoadImageButtonEnabled = true;

    private static string showPicture = "Show picture";
    private static string hidePicture = "Hide picture";
    //private ImageSource _avatarImageSource = new BitmapImage(new Uri("/Images/MangaFilleTriste.jpg", UriKind.Relative));

    //public event PropertyChangedEventHandler PropertyChanged;

    public MainWindowViewModel()
    {
      InitCommands();
    }

    private void InitCommands()
    {
      EnableButtonCommand = new MyCommand(ExecuteEnableButton,CanExecuteEnableButton);
      EnableButtonCommand2 = new MyCommand(ExecuteEnableButton);
      ChangePictureVisibilityCommand = new MyCommand(ExecuteChangePictureVisibility, CanExecuteChangePictureVisibility);
      LoadImageCommand = new MyCommand(ExecuteLoadImage, CanExecuteLoadImage);
    }

    public MyCommand EnableButtonCommand { get; set; }
    public MyCommand EnableButtonCommand2 { get; set; }

    public MyCommand ChangePictureVisibilityCommand { get; set; }
    public MyCommand LoadImageCommand { get; set; }
    
    public bool IsCheckBoxChecked
    {
      get => _isCheckBoxChecked;
      set
      {
        Set(ref _isCheckBoxChecked,value, propertyName: "IsCheckBoxChecked");
        //_isCheckBoxChecked = value;
        EnableButtonCommand.RaiseCanExecute();
        //OnPropertyChanged(nameof(IsCheckBoxChecked));
      }
    }

    public ImageVisibility PictureVisibility
    {
      get => _pictureVisibility;
      set
      {
        Set(ref _pictureVisibility, value, "PictureVisibility");
        //_pictureVisibility = value;
        ChangePictureVisibilityCommand.RaiseCanExecute();
        //OnPropertyChanged(nameof(PictureVisibility));
      }
    }

    public string VisibilityButtonText
    {
      get => _visibilityButtonText;
      set
      {
        Set(ref _visibilityButtonText, value, "VisibilityButtonText");
        //_visibilityButtonText = value;
        //OnPropertyChanged(nameof(VisibilityButtonText));
      }
    }
    public string Text 
    { 
      get => _text;
      set
      {
        Set(ref _text, value, "Text");
        //_text = value;
        //OnPropertyChanged(nameof(Text));
      }
    }
    
    public byte[] Picture
    {
      get
      {
        return File.ReadAllBytes(@"C:\Repositories\_mySamples\Mvvm\Mvvm\Images\MangaFilleTriste.jpg");
      }
    }

    //public bool IsLoadImageButtonEnabled
    //{
    //  get => _isLoadImageButtonEnabled;
    //  set
    //  {
    //    _isLoadImageButtonEnabled = value;
    //    LoadImageCommand.RaiseCanExecute();
    //    OnPropertyChanged(nameof(IsLoadImageButtonEnabled));
    //  }
    //}
    public byte[] Picture2 
    { get => _picture2;
      set
      {
        Set(ref _picture2, value, "Picture2");
        //_picture2 = value;
        //OnPropertyChanged(nameof(Picture2));
      }
    }

    /// <summary>
    /// Moved INotifyPropertyChanged implementation to BaseViewModel
    /// </summary>
    /// <param name="parameter"></param>
    //[NotifyPropertyChangedInvocator]
    //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //{
    //  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //}

    private void ExecuteEnableButton(object parameter)
    {
      Text = $"{Text} Sabrina / {parameter}";
    }

    private bool CanExecuteEnableButton(object parameter)
    {
      return IsCheckBoxChecked;
    }

    private void ExecuteChangePictureVisibility(object parameter)
    {
      switch (PictureVisibility)
      {
        // Collapsed not Hidden, because Hidden would reserve the space for the hidden element in the UI
        case (ImageVisibility.Collapsed):
          PictureVisibility = ImageVisibility.Visible;
          VisibilityButtonText = hidePicture;
          break;
        case (ImageVisibility.Visible):
          PictureVisibility = ImageVisibility.Collapsed;
          VisibilityButtonText = showPicture;
          break;
        default:
          PictureVisibility = ImageVisibility.Collapsed;
          VisibilityButtonText = showPicture;
          break;
      }
    }

    private bool CanExecuteChangePictureVisibility(object parameter)
    {
      return true;
    }

    private void ExecuteLoadImage(object parameter)
    {
      Picture2 = File.ReadAllBytes(@"C:\Repositories\_mySamples\Mvvm\Mvvm\Images\MangaFilleTriste.jpg");
      LoadImageCommand.RaiseCanExecute();
    }

    private bool CanExecuteLoadImage(object parameter)
    {
      return Picture2 == null;
    }
  }
}
