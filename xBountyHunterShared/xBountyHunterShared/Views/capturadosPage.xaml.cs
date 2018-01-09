using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xBountyHunterShared.Extras;
using xBountyHunterShared.Models;

namespace xBountyHunterShared.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class capturadosPage : ContentPage
    {
        public capturadosPage()
        {
            InitializeComponent();

            listaFugitivos liistFugitivos = new listaFugitivos();
            List<mFugitivos> capturados = new List<mFugitivos>();
            list.ItemsSource = capturados;
        }

        private void list_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            mFugitivos fugitivo = e.Item as mFugitivos;
            Navigation.PushAsync(new detallePage(fugitivo));
        }
    }
}