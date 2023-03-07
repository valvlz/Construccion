using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Construccion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            this.BindingContext = this;
            
        }

        public ObservableCollection<Album> MyImages { get; set; }

        private void Button_Config(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Configuracion());
        }

        
        private void Button_Catalogo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tienda());
        }

        private void Button_AboutUs(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nosotros());
        }

        private void Button_LogOut(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }

    public class Album
    {
        public string Image { get; set; }
        public string Description { get; set; }
    }

}