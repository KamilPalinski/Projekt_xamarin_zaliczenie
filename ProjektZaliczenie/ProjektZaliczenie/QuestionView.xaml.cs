using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjektZaliczenie
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuestionView : ContentPage
	{
		public QuestionView ()
		{
			InitializeComponent ();
		}

        

        private void ContactMeSwitch_Toggled(object sender, ToggledEventArgs e)
        {

        }


        private void SendMessageButton_Clicked_1(object sender, EventArgs e)
        {
            DisplayAlert("Success", "Message sent successfully", "Done");
        }
    }
}