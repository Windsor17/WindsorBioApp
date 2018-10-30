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
            this.Skills.Add(new Skill {Name = "C++", Description = "I have taken a class", Icon = "codingicon.png"});
            this.Skills.Add(new Skill {Name = "Technical Help Desk", Description = "I am a Gorilla Geek", Icon = "helpdeskicon.png"});
            this.Skills.Add(new Skill {Name = "Rocket League", Description = "I got diamond skills", Icon = "rocketleagueicon.png"});
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