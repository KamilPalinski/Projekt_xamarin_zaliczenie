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
    public partial class Contact : ContentPage
    {
        public Contact()
        {
            InitializeComponent();
        }

        private  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
             Device.OpenUri(new Uri("https://tiny.pl/tlsjw")); ;
    }   }      
}