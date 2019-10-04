using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Together.Mobile.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Together.Mobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RouteListPage : ContentPage
    {
        public RouteListPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var ctx = ((Button)sender).BindingContext;

            var listItem = ctx as RouteListItem;
            
            DisplayAlert("Alert", $"'{listItem.Name}' Passengers:{listItem.PassengersCount}/{listItem.MaxPassengers}", "OK");
        }

        private void RoutesList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            ((ListView)sender).SelectedItem = null;
        }
    }
}