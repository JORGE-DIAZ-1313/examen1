using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace examen1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //llenamos los campos de la lista
            var listapais = new List<string>();
            listapais.Add("Belice(501)");
            listapais.Add("Guatemala(502)");
            listapais.Add("El Salvador(503)");
            listapais.Add("Honduras(504)");
            listapais.Add("Nicaragua(505)");
            listapais.Add("Costa Rica(506)");
            listapais.Add("Panamá(507)");

            piker.ItemsSource = listapais;
        }
    }
}
