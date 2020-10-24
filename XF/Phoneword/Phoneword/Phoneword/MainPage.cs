using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Phoneword
{
    public class MainPage : ContentPage
    {        
        // class fields
        Entry phoneNumberText;
        Button translateButton;
        Button callButton;
        string translatedNumber;

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

            panel.Children.Add(phoneNumberText = new Entry
            {
                Text = "1-855-XAMARIN"
            });

            //Button buttonTranslate = new Button();
            //buttonTranslate.Text = "Translate";

            panel.Children.Add(translateButton = new Button
            {
                Text = "Translate",                
            });

            //Button buttonCall = new Button();
            //buttonCall.Text = "Call";
            //buttonCall.IsEnabled = false;

            panel.Children.Add(callButton = new Button
            {
                Text = "Call",
                IsEnabled = false,
            });

            // Add controls to panel
            //panel.Children.Add(label);
            //panel.Children.Add(input);
            //panel.Children.Add(buttonTranslate);
            //panel.Children.Add(buttonCall);

            translateButton.Clicked += OnTranslate;
            callButton.Clicked += OnCall;
            this.Content = panel;

            

        }

        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = phoneNumberText.Text;
            translatedNumber = PhonewordTranslator.ToNumber(enteredNumber);

            if(!string.IsNullOrEmpty(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }

        }

        private async void OnCall(object sender, EventArgs e)
        {
            if(await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"
                ))
            {
                try
                {
                    PhoneDialer.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
                }
                catch (FeatureNotSupportedException)
                {
                    await DisplayAlert("Unable to dial", "Phone dialing not supported.", "OK");
                }
                catch (Exception)
                {
                    // Other error has occured
                    await DisplayAlert("Unable to dial", "Phone dialing failed", "OK");
                }
                
            }

        }

    }
}
