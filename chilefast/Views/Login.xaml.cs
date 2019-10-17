using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace chilefast.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public void login(object sender, EventArgs args)
        {
            v_correo.IsVisible = false;
            v_pass.IsVisible = false;
            string correo = Correo.Text;
            string pass = Password.Text;
            if (String.IsNullOrEmpty(correo) && String.IsNullOrEmpty(pass))
            {
                v_correo.IsVisible = true;
                v_pass.IsVisible = true;
            }
            else if (String.IsNullOrEmpty(correo))
            {
                v_correo.IsVisible = true;
            }
            else if (String.IsNullOrEmpty(pass))
            {
                v_pass.IsVisible = true;
            }
            else
            {
                Navigation.PopModalAsync();
            }
        }
    }
}
