using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Events
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void OnButtonClicked(object o, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
