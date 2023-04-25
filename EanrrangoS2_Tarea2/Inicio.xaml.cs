using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EanrrangoS2_Tarea2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
		}

        private void btnAbrirNotas_Clicked(object sender, EventArgs e)
        {
			string usuario = txtUsuario.Text;

			Navigation.PushAsync(new Notas(usuario));

        }
    }
}