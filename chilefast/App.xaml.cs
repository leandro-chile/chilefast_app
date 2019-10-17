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
                con.CreateTable<Usuario>();
                con.CreateTable<ListaEnvios>();
                con.CreateTable<ListaFavoritos>();
            }
        }
    }
}
