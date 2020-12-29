using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApplication.Model;

namespace DemoApplication.DataAccess
{
  /// <summary>
  /// Event arguments used by CustomerRepository's CustomerAdded event.
  /// </summary>
  public class CustomerAddedEventArgs : EventArgs
  {
    public CustomerAddedEventArgs(Customer newCustomer)
    {
      this.NewCustomer = newCustomer;
    }

    public Customer NewCustomer { get; private set; }
  }
}
