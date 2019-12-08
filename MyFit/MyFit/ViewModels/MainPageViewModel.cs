using MyFit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyFit.ModelViews
{
    public class MainPageViewModel : ContentView, INotifyPropertyChanged
    {
        private MainPageModel mainPage;

        public MainPageViewModel()
        {
            this.mainPage = new MainPageModel();

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}