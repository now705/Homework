using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week1Personal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void ClickedOne(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new ScorePage());
        }

        async void ClickedTwo(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new CharacterPage());
        }

        async void ClickedThree(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new ItemPage());
        }
    }
}
