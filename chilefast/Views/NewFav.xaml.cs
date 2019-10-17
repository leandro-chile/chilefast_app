using System;
using SQLite;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;
using chilefast.Models;

namespace chilefast.Views
{
    public partial class NewFav : ContentPage
    {
        public NewFav()
        {
            InitializeComponent();
        }
        public void SaveFav(object sender, EventArgs args)
        {
            if(String.IsNullOrEmpty(_titulo.Text) && String.IsNullOrEmpty(_direccion.Text))
            {
                DisplayAlert("Alerta", "Debe ingresar un titulo y una dirección", "Aceptar");
                return;
            }
            string tituloV = _titulo.Text;
            string regionV = _region.Text;
            string comunaV = _comuna.Text;
            string ciudadV = _ciudad.Text;
            string direcV = _direccion.Text;
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(App.FilePath))
                {
                    ListaFavoritos fav = new ListaFavoritos()
                    {
                        titulo = tituloV,
                        region = regionV,
                        comuna = comunaV,
                        ciudad = ciudadV,
                        dirección = direcV
                    };
                    con.Insert(fav);
                    Debug.WriteLine(fav.ToString() + "// " + fav.titulo);
                }
                DisplayAlert("Alerta", "Se ha generado el registro correctamente", "Aceptar");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
                DisplayAlert("Err0r", "Ocurrió un error, lo sentimos mucho", "Aceptar");
            }
            
            Navigation.PopAsync();
        }
    }
}
