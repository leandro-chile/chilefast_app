using System;
using chilefast.Models;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace chilefast
{
    public partial class App : Application
    {
        public static string FilePath;
        public static bool loggedIn = false;
        public App(string filePath)
        {
            FilePath = filePath;
            InitializeComponent();
            CreaTablas();
            CreaRegistros();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        protected static void CreaTablas()
        {
            using (SQLiteConnection con = new SQLiteConnection(App.FilePath))
            {
                con.DropTable<ListaEnvios>();
                con.CreateTable<Usuario>();
                con.CreateTable<ListaEnvios>();
                con.CreateTable<ListaFavoritos>();
            }
        }
        protected static void CreaRegistros()
        {
            using (SQLiteConnection con = new SQLiteConnection(App.FilePath))
            {
                // -34.1685426,-70.7474913,17
                ListaEnvios le1 = new ListaEnvios()
                {
                    id = 1, estado = "En transito", direccion = "cuevas 756, Rancagua",
                    chofer = "Esteban Duque", lat_destino = "-34.1685426", lon_destino = "-70.7474913,17"
                };
                ListaEnvios le2 = new ListaEnvios()
                {
                    id = 2,
                    estado = "Finalizado",
                    direccion = "San Martin 122, Rancagua",
                    chofer = "Esteban Duque",
                    lat_destino = "-34.1685426",
                    lon_destino = "-70.7474913,17"
                };
                ListaEnvios le3 = new ListaEnvios()
                {
                    id = 3,
                    estado = "Sin enviar",
                    direccion = "Independencia 964, Rancagua",
                    chofer = "Esteban Duque",
                    lat_destino = "-34.1685426",
                    lon_destino = "-70.7474913,17"
                };
                con.Insert(le1);
                con.Insert(le2);
                con.Insert(le3);
            }
        }
    }
}
