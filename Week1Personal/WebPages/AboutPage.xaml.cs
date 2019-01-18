using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week1Personal
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

        }
        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new MainPage());
        }
    }
}
