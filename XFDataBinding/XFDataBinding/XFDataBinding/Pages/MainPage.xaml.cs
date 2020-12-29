using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFDataBinding.ViewModels;

namespace XFDataBinding.Pages
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
      BindingContext = new MainPageViewModel();
    }
  }
}
