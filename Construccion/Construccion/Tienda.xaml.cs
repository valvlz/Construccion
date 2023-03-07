using Construccion.Model;
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
    public partial class Tienda : ContentPage
    {
        public Tienda()
        {
            InitializeComponent();
        }

        private void OpenOrden(object sender, EventArgs e)
        {
            if (OrdenVista.TranslationX >= 150)
            {
                Action<double> callback = input => OrdenVista.TranslationX = input;
                OrdenVista.Animate("anim", callback, 150, 0, 16, 300, Easing.CubicInOut);
            }
        }

        private void AddOrden(object sender, EventArgs e)
        {
            var item = (sender as Button).BindingContext as Flowers;
            viewmodel.AddOrden(item);
        }

        private void CloseOrden(object sender, EventArgs e)
        {
            if (OrdenVista.TranslationX == 0)
            {
                Action<double> callback = input => OrdenVista.TranslationX = input;
                OrdenVista.Animate("anim", callback, 0, 150, 16, 300, Easing.CubicOut);
            }
        }
    }
}