using System;
using System.Collections.Generic;
using System.Diagnostics;
using chilefast.Models;
using chilefast.ViewModels;
using SQLite;
using Xamarin.Forms;

namespace chilefast.Views
{
    public partial class Favoritos : ContentPage
    {
        public Favoritos()
        {
            InitializeComponent();
            BindingContext = new FavoritosViewModel();
        }
        protected override void OnAppearing()
        {
            BindingContext = new FavoritosViewModel();
            //using (SQLiteConnection con = new SQLiteConnection(App.FilePath))
            //{
            //    var favoritos = con.Table<ListaFavoritos>();
            //    ListaFavs.HeightRequest = 80 * favoritos.Count();
            //    Debug.WriteLine("tamaño: " + favoritos.Count());
            //}
        }
        public void NuevoFavorito(object sender, EventArgs args)
        {
            Navigation.PushAsync(new NewFav());
        }
    }
}
