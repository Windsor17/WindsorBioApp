using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WindsorBioApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void AboutMeIcon_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void AboutMeLabel_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMePage());
        }

        private void SkillsLabel_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void SkillsIcon_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SkillsPage());
        }

        private void ContactMeLabel_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMePage());
        }

        private void ContactMeIcon_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContactMePage());
        }
    }
}
