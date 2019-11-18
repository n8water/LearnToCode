using System;
using System.IO;
using Xamarin.Forms;

namespace Notes
{
   public partial class MainPage : ContentPage
    {
        string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();

            if(File.Exists(fileName))
            {
                editor.Text = File.ReadAllText(fileName);
            }

            
        }

        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, editor.Text);
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if(File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            editor.Text = string.Empty;
        }
    }
}
