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
	public partial class StartView : MasterDetailPage
	{
		public StartView ()
		{
			InitializeComponent ();
            MasterView.NavigationListView.ItemSelected += NavigationListView_ItemSelected;
        }
        private void NavigationListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterNavigationItem item)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.Target));
                MasterView.NavigationListView.SelectedItem = null;
                IsPresented = false;
            }
        }


    }
}