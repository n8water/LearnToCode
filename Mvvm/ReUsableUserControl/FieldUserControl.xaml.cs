using System.Windows;
using System.Windows.Controls;

namespace ReUsableUserControl
{
  /// <summary>
  /// Interaction logic for FieldUserControl.xaml
  /// </summary>
  public partial class FieldUserControl : UserControl
  {
    #region Label DP
    /// <summary>
    /// Gets or sets the Label which is displayed next to the field
    /// </summary>
    public string Label
    {
      get => (string)GetValue(LabelProperty);
      set => SetValue(LabelProperty, value);
    }

    /// <summary>
    /// Identified the Label dependency property
    /// </summary>
    public static readonly DependencyProperty LabelProperty =
        DependencyProperty.Register("Label", typeof(string),
          typeof(FieldUserControl), new PropertyMetadata(""));
    #endregion Label DP

    #region Value DP
    /// <summary>
    /// Gets or sets the Value which is being displayed
    /// </summary>
    public object Value
    {
      get => (object)GetValue(ValueProperty);
      set => SetValue(ValueProperty, value);
    }

    /// <summary>
    /// Identified the Label dependency property
    /// </summary>
    public static readonly DependencyProperty ValueProperty =
        DependencyProperty.Register("Value", typeof(object),
          typeof(FieldUserControl), new PropertyMetadata(null));

    #endregion

    public FieldUserControl()
    {
      InitializeComponent();

      //Not working if nested inside an other UserControl!
      //DataContext = this;

      //Alternative to setting DataContext in xaml
      //LayoutRoot.DataContext = this;
    }
  }
}
