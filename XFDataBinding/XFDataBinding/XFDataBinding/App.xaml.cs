using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFDataBinding.Pages;

namespace XFDataBinding
{
  public partial class App : Application
  {
    public App()
    {
      InitializeComponent();

      MainPage = new ConverterPage();
    }

    protected override void OnStart()
    {
    }

    protected override void OnSleep()
    {
    }

    protected override void OnResume()
    {
    }
  }
}
