using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace darioAldazS6
{
    public partial class MainPage : ContentPage
    {
        private const string url = "http://192.168.8.102/ws_uisrael/post.php";
        private HttpClient client = new HttpClient();
        private ObservableCollection<Datos> _post;

        public MainPage()
        {
            InitializeComponent();
            this.cargarDatos();
        }


        private void btnMostrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Nuevo());

        }

        private async void cargarDatos()
        {
            var content = await client.GetStringAsync(url);
            List<Datos> listPost = JsonConvert.DeserializeObject<List<Datos>>(content);
            _post = new ObservableCollection<Datos>(listPost);

            listaEstudiantes.ItemsSource = _post;
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var objetoEstudiante = (Datos)e.SelectedItem;
            Navigation.PushAsync(new Actualizar(objetoEstudiante));
        }
    }
}
