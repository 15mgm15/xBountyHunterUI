using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using xBountyHunterShared.Extras;
using xBountyHunterShared.Models;

namespace xBountyHunterShared.Views
{
    public class fugitivosPage : ContentPage
    {
        ListView list = new ListView();
        public fugitivosPage()
        {
            Title = "Fugitivos";
            listaFugitivos listaFigitivos = new listaFugitivos();
            list.ItemTemplate = new DataTemplate(typeof(ListViewCell));
            list.ItemsSource = listaFigitivos.ocFugitivos;
            list.ItemTapped += List_ItemTapped;
            Content = list;
        }

        void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var fugitivo = e.Item as mFugitivos;
            Navigation.PushAsync(new capturarPage(fugitivo));
        }
    }
}