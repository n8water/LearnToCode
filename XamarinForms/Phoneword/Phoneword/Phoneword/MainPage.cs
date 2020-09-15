using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Forms;

namespace Phoneword
{
    public class MainPage : ContentPage
    {        
        // class fields
        Entry input;
        Button buttonTranslate;
        Button buttonCall;

        public MainPage()
        {
            this.Padding = new Thickness(20);

            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            // Controlelements
            //Label label = new Label();
            //label.Text = "Enter a Phoneword";

            panel.Children.Add(new Label
            {
                Text = "Enter a Phoneword",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });

            //Entry input = new Entry();
            //input.Text = "1-855-XAMARIN";

            panel.Children.Add(new Entry
            {
                Text = "1-855-XAMARIN"
            });

            //Button buttonTranslate = new Button();
            //buttonTranslate.Text = "Translate";

            panel.Children.Add(new Button
            {
                Text = "Translate",
                
            });

            //Button buttonCall = new Button();
            //buttonCall.Text = "Call";
            //buttonCall.IsEnabled = false;

            panel.Children.Add(new Button
            {
                Text = "Call",
                IsEnabled = false,
            });

            // Add controls to panel
            //panel.Children.Add(label);
            //panel.Children.Add(input);
            //panel.Children.Add(buttonTranslate);
            //panel.Children.Add(buttonCall);

            this.Content = panel;

            

        }

        public void OnTranslate(object sender, EventArgs e)
        {
            // something to be done
        }

    }
}
