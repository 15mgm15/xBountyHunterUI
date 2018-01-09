using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xBountyHunterShared.Views
{
    public class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            ToolbarItem btnAgregar = new ToolbarItem("Agrear", string.Empty, btnAgregar_onClick);
            ToolbarItems.Add(btnAgregar);
            Title = "X Bounty Hunter";

            if(Device.RuntimePlatform == Device.iOS)
            {
                Padding = new Thickness(0,20,0,0);
            }

            Children.Add(new fugitivosPage());
            Children.Add(new capturadosPage());
            Children.Add(new acercaDePage());
        }

        public void btnAgregar_onClick()
        {
            Navigation.PushAsync(new agregarFugitivo());
        }

    }
}
