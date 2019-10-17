using System;
using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using chilefast.Models;
using System.Diagnostics;

namespace chilefast.ViewModels
{
    public class FavoritosViewModel
    {
        public List<ListaFavoritos> listaFavoritos { get; set; }
        public int tamano { get; set; }
        private ObservableCollection<ListaFavoritos> items;
        public ObservableCollection<ListaFavoritos> Items
        {
            get { return items; }
            set
            {
                items = value;
            }
        }
        public FavoritosViewModel()
        {
            Items = new ObservableCollection<ListaFavoritos>() { };
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                var listafavs = conn.Table<ListaFavoritos>();
                tamano = 80 * listafavs.Count();
                foreach (ListaFavoritos item in listafavs)
                {
                    Items.Add(item);
                    Debug.WriteLine(item.titulo + " tamano: " + tamano);
                }
            }
        }
    }
}
