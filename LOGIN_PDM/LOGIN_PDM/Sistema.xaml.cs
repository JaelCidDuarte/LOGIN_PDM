using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace LOGIN_PDM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sistema : ContentPage
    {
        public Sistema()
        {
            InitializeComponent();
        }


        private async void btn_VAMOS_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Principal());
        }

        private void btnLeerMa_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/ByL8OahDgL0?si=EDfGazNzN84IF0X0", BrowserLaunchMode.SystemPreferred);

        }

        private void btnLeerMas_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/CMjNBDq6lnQ?si=DKgcqohBsNcCmerJ", BrowserLaunchMode.SystemPreferred); 
        }

        private void btnLeerMas1_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/_U-_XfDGgDw?si=SrsnUHZKxznaIttC", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas2_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/4hVME3O9wf4?si=5Hp7U7v2Np8p1Apd", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas3_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/mtKt9UXJwbc?si=YSN6etC2BAgSRILp", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas4_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/8V2dTitXClU?si=d6CNEtLP7AcZaeTW", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLeerMas45_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://youtu.be/OWdZr6Ldlo8?si=aQakBlCXaZo-tDd1", BrowserLaunchMode.SystemPreferred);
        }
    }
}