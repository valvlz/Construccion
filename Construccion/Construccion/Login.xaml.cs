using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Construccion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Es para el link del registro
            Navigation.PushAsync(new Registro());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUserName.Text == "A" && txtPassword.Text == "12345")
            {
                Navigation.PushAsync(new Home());

            }
            else
            {

                DisplayAlert("Error", "Usuario o contraseña incorrecta", "Inténtalo nuevamente");

            }
        }
    }
}