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
	public partial class DetailView : ContentPage
	{
		public DetailView(Offers p)
		{
			InitializeComponent ();
            Binddata(p);
		}

        private void Binddata(Offers pp)
        {
            PieNameLabel.Text = pp.Model;
            PieImage.Source = pp.ImageUrl;
            DescriptionLabel.Text = pp.Description;
            PriceLabel.Text = pp.Price;
            InStockLabel.Text = pp.InStock ? "In stock" : "Not in stock";
        }

        private async  void Question_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionView());
            
        }
    }
}