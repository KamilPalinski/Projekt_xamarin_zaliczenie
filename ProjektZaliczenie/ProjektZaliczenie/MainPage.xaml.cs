﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProjektZaliczenie
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new StartView(), this);
            await Navigation.PopAsync();
        }
    }
}
