﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektZaliczenie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            
        }
        private async void SaveSettingsButton_OnClicked(object sender, EventArgs e)
        {
            SavingActivityIndicator.IsRunning = true;

            await Task.Delay(2000);

            SavingActivityIndicator.IsRunning = false;

            await DisplayAlert("Success", "Your settings have been saved!", "Done");
        }
    }
}