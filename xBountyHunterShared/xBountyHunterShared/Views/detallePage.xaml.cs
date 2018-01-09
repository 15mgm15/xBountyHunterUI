using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xBountyHunterShared.Models;

namespace xBountyHunterShared.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detallePage : ContentPage
    {
        mFugitivos Fugitivo = new mFugitivos();
        public detallePage(mFugitivos fugitivo)
        {
            InitializeComponent();

            Fugitivo = fugitivo;
            Title = fugitivo.Name;
        }
    }
}