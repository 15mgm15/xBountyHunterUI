using Xamarin.Forms;
using xBountyHunterShared.Models;

namespace xBountyHunterShared.Views
{
    public class capturarPage : ContentPage
    {
        mFugitivos Fugitivo = new mFugitivos();
        Label fugitivoSuelto;
        Button bcapturar;
        Button beliminar;
        StackLayout verticalStackLayout;

        public capturarPage(mFugitivos fugitivo)
        {
            Fugitivo.Name = fugitivo.Name;
            Fugitivo.ID = fugitivo.ID;

            fugitivoSuelto = new Label
            {
                Text = "El fugitivo sigue suelto ...",
                FontSize = 20,
                HorizontalOptions = LayoutOptions.Center
            };

            bcapturar = new Button
            {
                Text = "Capturar",
                WidthRequest = 200,
                HorizontalOptions = LayoutOptions.Center
            };

            beliminar = new Button
            {
                Text = "Eliminar",
                BorderColor = Color.Black,
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 200
            };

            verticalStackLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Title = Fugitivo.Name;

            verticalStackLayout.Children.Add(fugitivoSuelto);
            verticalStackLayout.Children.Add(bcapturar);
            verticalStackLayout.Children.Add(beliminar);

            Content = verticalStackLayout;
        }
    }
}