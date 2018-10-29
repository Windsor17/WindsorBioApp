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
        public ObservableCollection<Skill> Skills { get; set; }
		public SkillsPage ()
		{
			InitializeComponent ();

            this.Skills = new ObservableCollection<Skill>();
            this.Skills.Add(new Skill {Name = "Stuff", Description = "I like stuff"});
            this.Skills.Add(new Skill {Name = "Things", Description = "I also like things"});
            this.Skills.Add(new Skill {Name = "Rocket League", Description = "I got diamond skills"});
            SkillList.ItemsSource = this.Skills;
		}

        public class Skill
        {
            public string Icon { get; set; }
            public string Description { get; set; }
            public string Name { get; set; }
        }
    }
}