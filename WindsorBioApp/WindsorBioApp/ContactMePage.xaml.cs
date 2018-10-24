using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindsorBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMePage : ContentPage
	{
		public ContactMePage ()
		{
			InitializeComponent ();
		}

        private void ContactMeButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameEntry.Text))
            {
                DisplayAlert("Error", "Enter something", "Oh, ok");
                return;
            }

            if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                DisplayAlert("Error", "Enter something", "Oh, ok");
                return;
            }
            if (string.IsNullOrEmpty(MessageEntry.Text))
            {
                DisplayAlert("Error", "Enter something", "Oh, ok");
                return;
            }
            DisplayAlert("Alert", "You're message was sent.", "Woohoo");
        }
    }
}