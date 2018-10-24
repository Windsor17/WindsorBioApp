using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WindsorBioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SkillsPage : ContentPage
	{
        public ObservableCollection<string> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<string>();
		}

        private void SkillButton_Clicked(object sender, EventArgs e)
        {
            this.Skills.Add(SkillEntry.Text);

            SkillEntry.Text = "";

            SkillList.ItemsSource = this.Skills;
        }
    }
}