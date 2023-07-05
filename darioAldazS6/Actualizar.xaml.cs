using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace darioAldazS6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actualizar : ContentPage
    {
        public Actualizar(Datos datos)
        {
            InitializeComponent();
            txtCodigo.Text = datos.Codigo.ToString();
            txtNombre.Text = datos.Nombre;
            txtApellido.Text = datos.Apellido;
            txtEdad.Text = datos.Edad;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();

                var parametros = new NameValueCollection();
                string url = $"http://192.168.8.102/ws_uisrael/post.php?codigo={txtCodigo.Text}&nombre={txtNombre.Text}&apellido={txtApellido.Text}&edad={txtEdad.Text}";


                client.UploadValues(url, "PUT", parametros);
                DisplayAlert("Alerta", "Datos actualizados correctamente", "Aceptar");
                Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {

                DisplayAlert("Error", "Detalle:" + ex.Message, "Aceptar");
            }
        }


        private void btbEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();

                var parametros = new NameValueCollection();
                string url = $"http://192.168.8.102/ws_uisrael/post.php?codigo={txtCodigo.Text}";


                client.UploadValues(url, "DELETE", parametros);
                DisplayAlert("Alerta", "Datos eliminados correctamente", "Aceptar");
                Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {

                DisplayAlert("Error", "Detalle:" + ex.Message, "Aceptar");
            }
        }

    }
}