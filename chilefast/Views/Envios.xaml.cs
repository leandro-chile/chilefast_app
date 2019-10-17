using System;
using SQLite;
using System.Collections.Generic;

using Xamarin.Forms;
using chilefast.Models;

namespace chilefast.Views
{
    public partial class Envios : ContentPage
    {
        public Envios()
        {
            InitializeComponent();
            using (SQLiteConnection cone = new SQLiteConnection(App.FilePath))
            {
                var Envios = cone.Table<ListaEnvios>().ToList();
                ListaEnviosSt.ItemsSource = Envios;
                foreach (var en in Envios)
                {
                    System.Diagnostics.Debug.WriteLine("a: " + en.chofer);
                }
            }
        }
    }
}
