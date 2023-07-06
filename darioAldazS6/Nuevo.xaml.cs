﻿using System;
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
    public partial class Nuevo : ContentPage
    {
        public Nuevo()
        {
            InitializeComponent();
        }

        private async void btbInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string url = "http://192.168.17.27/ws_uisrael/post.php";
                var parametros = new NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                client.UploadValues(url, "POST", parametros);
              
      

                var mensaje = "Dato Ingresado";
                DependencyService.Get<Mensaje>().LongAlert(mensaje);
                Navigation.PushAsync(new Nuevo());


            }
            catch (Exception ex)
            {

                await DisplayAlert("Error", "Detalle:" + ex.Message, "Aceptar");
            }
        }
    }
}