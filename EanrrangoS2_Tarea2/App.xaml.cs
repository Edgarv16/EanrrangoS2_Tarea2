using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EanrrangoS2_Tarea2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // NaNavigationPage -- habiliata lanavegacion entre paginas

            MainPage = new NavigationPage(new Inicio());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
