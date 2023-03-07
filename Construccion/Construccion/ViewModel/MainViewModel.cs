using Construccion.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Construccion.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        //Constructor
        public MainViewModel() 
        {
            Ordenes = new ObservableCollection<Flowers>();

            Flores = GetFlowers();
        
        }

        public int OrdenCount => Ordenes.Count;

        public int TotalPrice => (int)Ordenes.Sum(x => x.Price);


        private ObservableCollection<Flowers> flores;

        public ObservableCollection<Flowers> Flores 
        { 
            get { return flores; } 

            set 
            { 
                flores = value;
                OnPropertyChanged();
            
            }
        }

        private ObservableCollection<Flowers> ordenes;

        public ObservableCollection<Flowers> Ordenes
        {
            get { return ordenes; }

            set
            {
                ordenes = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(OrdenCount));
                OnPropertyChanged(nameof(TotalPrice));
            }
        }

        private ObservableCollection<Flowers> GetFlowers()
        {
            return new ObservableCollection<Flowers>
            {

                new Flowers { Name = "Tulipanes", Image = "https://d3e3r3101xvs9k.cloudfront.net/ProductOriginalPhotos/Arreglo_de_Tulipanes_Rojos_40_Corazones_frontal1.jpg", Price = 89000, Description = "Son plantas que rara vez sobrepasan los 50 cm de altura, con llamativas flores de 6 pétalos, muy bonitas y en una vasta variedad de colores, tamaños y formas." },
                new Flowers { Name = "Girasoles", Image = "https://florerialiliana.com.mx/wp-content/uploads/2019/03/699-19.png", Price = 76000, Description = "Su popularidad se debe, sobre todo, a parecido con el sol y a su capacidad de orientarse siguiendo el desplazamiento de este en el cielo, de forma que recibe siempre toda la luz posible de él." },
                new Flowers { Name = "Verbena", Image = "https://instalartodo.com/wp-content/uploads/2015/11/VerbenasEnMacetas.jpg", Price = 57000, Description = "Se trata de una de las plantas más populares en el mundo entero, ya que son muy adaptables y tienen una gran cantidad de propiedades medicinales, además de resultar plantas ornamentales de gran valor." },
                new Flowers { Name = "Lavanda común", Image = "https://cdn2.actitudfem.com/media/files/styles/large/public/images/2020/06/bouquet-de-lavanda-decorar-aromatizar-casa-4.jpg", Price = 45000, Description = "Esta planta aromática posee tallos de tipo leñosos y de hojas opuestas." },
                new Flowers { Name = "Rosas", Image = "https://cdn.igp.com/f_auto,q_auto,t_prodl/products/p-beautiful-18-red-roses-bunch-4839-1.jpg", Price = 99000, Description = "Las rosas son todo un género de arbustos espinosos, ampliamente conocidos por la belleza de sus flores, de fragancia muy característica." },

            };
        }

        public void AddOrden(Flowers item) 
        {
            if (item != null)
            {
                Ordenes.Add(item);
                OnPropertyChanged(nameof(OrdenCount));
                OnPropertyChanged(nameof(TotalPrice));
            }

        }


    }
}
