using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LOGIN_PDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAcepto_Clicked(object sender, EventArgs e)
        {
           
                string sUsuario = txtUsuario.Text;
                string sPassword = txtPassword.Text;

                if ((sUsuario == "Jael") && (sPassword == "04220311"))
                {
                    Navigation.PushAsync(new Sistema());
                }
                else
                {
                    DisplayAlert("❌ Alerta", "El Usuario 🙋‍♂️👨‍💻 o el Password 🔐🤷‍♂️ Son Incorrectos", "Acepto ✔");
                }
            }

        private void btnProhibido_Clicked(object sender, EventArgs e)
        {

        }
    }
}
