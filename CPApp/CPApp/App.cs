using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CPApp
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ContentPage
            {
                Title = "Fluo's movies",
                Content = new StackLayout
                {
                    Spacing = 20,
                    Padding= 50,
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new ListView { 
                            ItemsSource = new String[] {
                                "Game of Thrones",
                                "Walking Dead",
                                "Dexter",
                                "True Blood"
                            }
                        }
                    }
                }
            };
        }
    }
}
