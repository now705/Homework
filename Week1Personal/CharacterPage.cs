using System;

using Xamarin.Forms;

namespace Week1Personal
{
    public class CharacterPage : ContentPage
    {
        public CharacterPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

