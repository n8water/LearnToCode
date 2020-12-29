using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mvvm;
using Mvvm.ViewModels;

namespace MvvMTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CommandButtonIsEnabledWhenCheckBoxIsChecked()
    {
      var model = new MainWindowViewModel();

      model.IsCheckBoxChecked = true;

      Assert.IsTrue(model.EnableButtonCommand.CanExecute());
    }

    [TestMethod]
    public void CommandButtonIsDisabledWhenCheckBoxIsUnchecked()
    {
      var model = new MainWindowViewModel();
      model.IsCheckBoxChecked = false;

      Assert.IsFalse(model.EnableButtonCommand.CanExecute());
    }

    [TestMethod]
    public void CanRelayCommandExecuteWithoutWhenCanExecuteFuncIsNotGiven()
    {
      bool isExecuted = false;

      var myCommand = new MyCommand(parameter => { });

      isExecuted = myCommand.CanExecute();

      Assert.IsTrue(isExecuted);
    }

    [TestMethod]
    public void SomeOtherTest()
    {
      bool isExecuted = false;

      var myCommand = new MyCommand(parameter => isExecuted = true);

      myCommand.Execute();
      myCommand.Execute(null);

      Assert.IsTrue(isExecuted);
    }

  }
}
